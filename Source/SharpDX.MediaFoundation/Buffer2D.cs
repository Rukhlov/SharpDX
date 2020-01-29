using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpDX.MediaFoundation
{
    public partial class Buffer2D
    {

        public unsafe void _ContiguousCopyFrom(IntPtr bSrcBufferRef, System.Int32 cbSrcBuffer)
        {
            SharpDX.Result __result__;
            //fixed (void* bSrcBufferRef_ = bSrcBufferRef)
            __result__ = SharpDX.MediaFoundation.LocalInterop.CalliStdCallint(this._nativePointer, (void*)bSrcBufferRef, cbSrcBuffer, (*(void***)this._nativePointer)[9]);
            __result__.CheckError();
        }
    }
}
