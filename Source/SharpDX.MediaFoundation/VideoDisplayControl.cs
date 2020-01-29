using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpDX.MediaFoundation
{
    public partial class VideoDisplayControl
    {
        //public unsafe SharpDX.Result TryGetCurrentImage([In, Out] IntPtr bihRef, out IntPtr dibRef, out int cbDibRef, out long timeStampRef)
        //{
        //    Result __result__;

        //    //bihRef = IntPtr.Zero;
        //    dibRef = IntPtr.Zero;
        //    cbDibRef = 0;
        //    timeStampRef = 0;

        //    fixed (void* cbDibRef_ = &cbDibRef)
        //    {
        //        fixed (void* timeStampRef_ = &timeStampRef)
        //        {
        //            __result__ = SharpDX.MediaFoundation.LocalInterop.CalliStdCallint(this._nativePointer, (void*)bihRef, (void*)dibRef, cbDibRef_, timeStampRef_, (*(void***)this._nativePointer)[12]);
        //        }

        //    }

        //    return __result__;
        //}


        //public unsafe void _GetCurrentImage([In, Out] IntPtr bihRef, IntPtr dibRef, out int cbDibRef, out long timeStampRef)
        //{
        //    SharpDX.Result __result__;


        //    fixed (void* cbDibRef_ = &cbDibRef)
        //    //fixed (void* dibRef_ = dibRef)
        //    //fixed (void* bihRef_ = &bihRef)
        //        __result__ = SharpDX.MediaFoundation.LocalInterop.CalliStdCallint(this._nativePointer, (void*)bihRef, (void*)dibRef, cbDibRef_, (void*)timeStampRef, (*(void***)this._nativePointer)[12]);
        //    __result__.CheckError();
        //}
    }
}
