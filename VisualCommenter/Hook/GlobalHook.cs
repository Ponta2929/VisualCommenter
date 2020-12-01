using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VisualCommenter.Win32API;

namespace VisualCommenter.Hook
{
    public class GlobalHook : IDisposable
    {
        /// <summary>
        /// リソースが破棄されているか
        /// </summary>
        protected bool Disposed { get; private set; }

        /// <summary>
        /// Hookハンドル
        /// </summary>
        public IntPtr Handle { get; private set; }

        /// <summary>
        /// インスタンスハンドル
        /// </summary>
        public IntPtr Module { get; private set; }

        /// <summary>
        /// 関数生成
        /// </summary>
        private UnmanagedFunction emitter;

        /// <summary>
        /// GCによる回収保護
        /// </summary>
        private GCHandle @delegate;

        /// <summary>
        /// Unmanaged : 
        /// フックチェーンを次のフックプロシージャに渡します。
        /// </summary>
        protected Delegate callNextHook;

        public GlobalHook()
        {
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
                throw new PlatformNotSupportedException("Windows 98/Meではサポートされていません。");
        }

        /// <summary>
        /// 初期化を行います。
        /// </summary>
        /// <param name="hookType">インストールするフック手順のタイプ。</param>
        protected virtual void Initialize(int hookType, Delegate callback, Type callNextHook)
        {
            // エミッター生成
            emitter = new UnmanagedFunction("user32.dll");

            // Hook
            this.callNextHook = emitter.CreateFunction(callNextHook);

            // コールバック関数
            @delegate = GCHandle.Alloc(callback);

            // モジュールポインタ
            Module = IntPtr.Zero;
            Handle = API.SetWindowsHookEx(hookType, Marshal.GetFunctionPointerForDelegate(callback), Module, 0);
        }

        /// <summary>
        /// protected : dispose
        /// </summary>
        protected void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    // 使用したDLLを破棄します。
                    if (Handle != IntPtr.Zero)
                    {
                        API.UnhookWindowsHookEx(Handle);
                        Handle = IntPtr.Zero;
                    }

                    if (@delegate.IsAllocated)
                        @delegate.Free();

                    emitter.Dispose();
                }

                Disposed = true;
            }
        }

        /// <summary>
        /// 使用されたリソースを破棄します。
        /// </summary>
        public void Dispose()
        {
            // 使用したDLLを破棄します。
            Dispose(true);

            // GCを無効にします。
            GC.SuppressFinalize(this);
        }

        ~GlobalHook() => Dispose(false);
    }
}
