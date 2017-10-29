// Ported from \sdk\include\igl.h

using System;
using System.Runtime.InteropServices;

namespace SolidEdgeSDK
{
    /// <summary>
    /// IGL Graphics Library Interface
    /// </summary>
    [ComImport]
    [Guid("0002D280-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGL
    {
        /// <summary>
        /// 
        /// </summary>
        void glAccum(uint op, float value);

        /// <summary>
        /// 
        /// </summary>
        void glAlphaFunc(uint func, float aRef);

        /// <summary>
        /// 
        /// </summary>
        void glBegin(uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glBitmap(
            int width,
            int height,
            float xorig,
            float yorig,
            float xmove,
            float ymove,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] bitmap
            );

        /// <summary>
        /// 
        /// </summary>
        void glBlendFunc(uint sfactor, uint dfactor);

        /// <summary>
        /// 
        /// </summary>
        void glCallList(uint list);

        /// <summary>
        /// 
        /// </summary>
        void glCallLists(
            int n,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] lists
            );

        /// <summary>
        /// 
        /// </summary>
        void glClear(uint mask);

        /// <summary>
        /// 
        /// </summary>
        void glClearAccum(float red, float green, float blue, float alpha);

        /// <summary>
        /// 
        /// </summary>
        void glClearColor(float red, float green, float blue, float alpha);

        /// <summary>
        /// 
        /// </summary>
        void glClearDepth(double depth);

        /// <summary>
        /// 
        /// </summary>
        void glClearIndex(float c);

        /// <summary>
        /// 
        /// </summary>
        void glClearStencil(int s);

        /// <summary>
        /// 
        /// </summary>
        void glClipPlane(
            uint plane,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] equation
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor3b(sbyte red, sbyte green, sbyte blue);

        /// <summary>
        /// 
        /// </summary>
        void glColor3bv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)]
            sbyte[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor3d(double red, double green, double blue);

        /// <summary>
        /// 
        /// </summary>
        void glColor3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor3f(float red, float green, float blue);

        /// <summary>
        /// 
        /// </summary>
        void glColor3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor3i(int red, int green, int blue);

        /// <summary>
        /// 
        /// </summary>
        void glColor3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor3s(short red, short green, short blue);

        /// <summary>
        /// 
        /// </summary>
        void glColor3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor3ub(byte red, byte green, byte blue);

        /// <summary>
        /// 
        /// </summary>
        void glColor3ubv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor3ui(uint red, uint green, uint blue);

        /// <summary>
        /// 
        /// </summary>
        void glColor3uiv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor3us(ushort red, ushort green, ushort blue);

        /// <summary>
        /// 
        /// </summary>
        void glColor3usv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2)]
            ushort[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColor4bv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)]
            sbyte[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor4d(double red, double green, double blue, double alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColor4dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor4f(float red, float green, float blue, float alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColor4fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor4i(int red, int green, int blue, int alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColor4iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor4s(short red, short green, short blue, short alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColor4sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v)
            ;

        /// <summary>
        /// 
        /// </summary>
        void glColor4ub(byte red, byte green, byte blue, byte alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColor4ubv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor4ui(uint red, uint green, uint blue, uint alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColor4uiv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColor4usv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2)]
            ushort[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glColorMask(byte red, byte green, byte blue, byte alpha);

        /// <summary>
        /// 
        /// </summary>
        void glColorMaterial(uint face, uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glCopyPixels(int x, int y, int width, int height, uint type);

        /// <summary>
        /// 
        /// </summary>
        void glCullFace(uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glDeleteLists(uint list, int range);

        /// <summary>
        /// 
        /// </summary>
        void glDepthFunc(uint func);

        /// <summary>
        /// 
        /// </summary>
        void glDepthMask(byte flag);

        /// <summary>
        /// 
        /// </summary>
        void glDepthRange(double zNear, double zFar);

        /// <summary>
        /// 
        /// </summary>
        void glDisable(uint cap);

        /// <summary>
        /// 
        /// </summary>
        void glDrawBuffer(uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glDrawPixels(
            int width,
            int height,
            uint format,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] pixels
            );

        /// <summary>
        /// 
        /// </summary>
        void glEdgeFlag(byte flag);

        /// <summary>
        /// 
        /// </summary>
        void glEdgeFlagv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] flag
            );

        /// <summary>
        /// 
        /// </summary>
        void glEnable(uint cap);

        /// <summary>
        /// 
        /// </summary>
        void glEnd();

        /// <summary>
        /// 
        /// </summary>
        void glEndList();

        /// <summary>
        /// 
        /// </summary>
        void glEvalCoord1d(double u);

        /// <summary>
        /// 
        /// </summary>
        void glEvalCoord1dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] u
            );

        /// <summary>
        /// 
        /// </summary>
        void glEvalCoord1f(float u);

        /// <summary>
        /// 
        /// </summary>
        void glEvalCoord1fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] u
            );

        /// <summary>
        /// 
        /// </summary>
        void glEvalCoord2d(double u, double v);

        /// <summary>
        /// 
        /// </summary>
        void glEvalCoord2dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] u
            );

        /// <summary>
        /// 
        /// </summary>
        void glEvalCoord2f(float u, float v);

        /// <summary>
        /// 
        /// </summary>
        void glEvalCoord2fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] u
            );

        /// <summary>
        /// 
        /// </summary>
        void glEvalMesh1(uint mode, int i1, int i2);

        /// <summary>
        /// 
        /// </summary>
        void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);

        /// <summary>
        /// 
        /// </summary>
        void glEvalPoint1(int i);
        
        /// <summary>
        /// 
        /// </summary>
        void glEvalPoint2(int i, int j);

        /// <summary>
        /// 
        /// </summary>
        void glFeedbackBuffer(
            int size,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] buffer
            );

        /// <summary>
        /// 
        /// </summary>
        void glFinish();

        /// <summary>
        /// 
        /// </summary>
        void glFlush();

        /// <summary>
        /// 
        /// </summary>
        void glFogf(uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glFogfv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glFogi(uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glFogiv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glFrontFace(uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

        /// <summary>
        /// 
        /// </summary>
        uint glGenLists(int range);

        /// <summary>
        /// 
        /// </summary>
        void glGetBooleanv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetClipPlane(
            uint plane,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] equation
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetDoublev(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        uint glGetError();

        /// <summary>
        /// 
        /// </summary>
        void glGetFloatv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetIntegerv(uint pname, ref int someParams);

        /// <summary>
        /// 
        /// </summary>
        void glGetLightfv(
            uint light,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetLightiv(
            uint light,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetMapdv(
            uint target,
            uint query,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v);

        /// <summary>
        /// 
        /// </summary>
        void glGetMapfv(
            uint target,
            uint query,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetMapiv(
            uint target,
            uint query,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetMaterialfv(
            uint face,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetMaterialiv(
            uint face,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetPixelMapfv(
            uint map,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] values
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetPixelMapuiv(
            uint map,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] values
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetPixelMapusv(
            uint map,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2)]
            ushort[] values
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetPolygonStipple(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] mask
            );

        /// <summary>
        /// 
        /// </summary>
        sbyte[] glGetString(uint name);

        /// <summary>
        /// 
        /// </summary>
        void glGetTexEnvfv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexEnviv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexGendv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexGenfv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexGeniv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexImage(
            uint target,
            int level,
            uint format,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] pixels
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexLevelParameterfv(
            uint target,
            int level,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexLevelParameteriv(
            uint target,
            int level,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexParameterfv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glGetTexParameteriv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glHint(uint target, uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glIndexMask(uint mask);

        /// <summary>
        /// 
        /// </summary>
        void glIndexd(double c);

        /// <summary>
        /// 
        /// </summary>
        void glIndexdv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] c
            );

        /// <summary>
        /// 
        /// </summary>
        void glIndexf(float c);

        /// <summary>
        /// 
        /// </summary>
        void glIndexfv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] c
            );

        /// <summary>
        /// 
        /// </summary>
        void glIndexi(int c);

        /// <summary>
        /// 
        /// </summary>
        void glIndexiv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] c
            );

        /// <summary>
        /// 
        /// </summary>
        void glIndexs(short c);

        /// <summary>
        /// 
        /// </summary>
        void glIndexsv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] c
            );

        /// <summary>
        /// 
        /// </summary>
        void glInitNames();

        /// <summary>
        /// 
        /// </summary>
        byte glIsEnabled(uint cap);

        /// <summary>
        /// 
        /// </summary>
        byte glIsList(uint list);

        /// <summary>
        /// 
        /// </summary>
        void glLightModelf(uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glLightModelfv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glLightModeli(uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glLightModeliv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glLightf(uint light, uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glLightfv(
            uint light,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glLighti(uint light, uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glLightiv(
            uint light,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glLineStipple(int factor, ushort pattern);

        /// <summary>
        /// 
        /// </summary>
        void glLineWidth(float width);

        /// <summary>
        /// 
        /// </summary>
        void glListBase(uint aBase);

        /// <summary>
        /// 
        /// </summary>
        void glLoadIdentity();

        /// <summary>
        /// 
        /// </summary>
        void glLoadMatrixd(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] m
            );

        /// <summary>
        /// 
        /// </summary>
        void glLoadMatrixf(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] m
            );

        /// <summary>
        /// 
        /// </summary>
        void glLoadName(uint name);

        /// <summary>
        /// 
        /// </summary>
        void glLogicOp(uint opcode);

        /// <summary>
        /// 
        /// </summary>
        void glMap1d(
            uint target,
            double u1,
            double u2,
            int stride,
            int order,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] points
            );

        /// <summary>
        /// 
        /// </summary>
        void glMap1f(
            uint target,
            float u1,
            float u2,
            int stride,
            int order,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] points
            );

        /// <summary>
        /// 
        /// </summary>
        void glMap2d(
            uint target,
            double u1,
            double u2,
            int ustride,
            int uorder,
            double v1,
            double v2,
            int vstride,
            int vorder,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] points
            );

        /// <summary>
        /// 
        /// </summary>
        void glMap2f(
            uint target,
            float u1,
            float u2,
            int ustride,
            int uorder,
            float v1,
            float v2,
            int vstride,
            int vorder,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] points
            );

        /// <summary>
        /// 
        /// </summary>
        void glMapGrid1d(int un, double u1, double u2);

        /// <summary>
        /// 
        /// </summary>
        void glMapGrid1f(int un, float u1, float u2);

        /// <summary>
        /// 
        /// </summary>
        void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

        /// <summary>
        /// 
        /// </summary>
        void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

        /// <summary>
        /// 
        /// </summary>
        void glMaterialf(uint face, uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glMaterialfv(
            uint face,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glMateriali(uint face, uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glMaterialiv(
            uint face,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glMatrixMode(uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glMultMatrixd(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] m
            );

        /// <summary>
        /// 
        /// </summary>
        void glMultMatrixf(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] m
            );

        /// <summary>
        /// 
        /// </summary>
        void glNewList(uint list, uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

        /// <summary>
        /// 
        /// </summary>
        void glNormal3bv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)]
            sbyte[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glNormal3d(double nx, double ny, double nz);

        /// <summary>
        /// 
        /// </summary>
        void glNormal3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glNormal3f(float nx, float ny, float nz);

        /// <summary>
        /// 
        /// </summary>
        void glNormal3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glNormal3i(int nx, int ny, int nz);

        /// <summary>
        /// 
        /// </summary>
        void glNormal3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glNormal3s(short nx, short ny, short nz);

        /// <summary>
        /// 
        /// </summary>
        void glNormal3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

        /// <summary>
        /// 
        /// </summary>
        void glPassThrough(float token);

        /// <summary>
        /// 
        /// </summary>
        void glPixelMapfv(
            uint map,
            int mapsize,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] values
            );

        /// <summary>
        /// 
        /// </summary>
        void glPixelMapuiv(
            uint map,
            int mapsize,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] values
            );

        /// <summary>
        /// 
        /// </summary>
        void glPixelMapusv(
            uint map,
            int mapsize,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2)]
            ushort[] values
            );

        /// <summary>
        /// 
        /// </summary>
        void glPixelStoref(uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glPixelStorei(uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glPixelTransferf(uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glPixelTransferi(uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glPixelZoom(float xfactor, float yfactor);

        /// <summary>
        /// 
        /// </summary>
        void glPointSize(float size);

        /// <summary>
        /// 
        /// </summary>
        void glPolygonMode(uint face, uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glPolygonStipple(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] mask
            );

        /// <summary>
        /// 
        /// </summary>
        void glPopAttrib();

        /// <summary>
        /// 
        /// </summary>
        void glPopMatrix();

        /// <summary>
        /// 
        /// </summary>
        void glPopName();

        /// <summary>
        /// 
        /// </summary>
        void glPushAttrib(uint mask);

        /// <summary>
        /// 
        /// </summary>
        void glPushMatrix();

        /// <summary>
        /// 
        /// </summary>
        void glPushName(uint name);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos2d(double x, double y);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos2dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos2f(float x, float y);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos2fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos2i(int x, int y);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos2iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos2s(short x, short y);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos2sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos3d(double x, double y, double z);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos3f(float x, float y, float z);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos3i(int x, int y, int z);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos3s(short x, short y, short z);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos4d(double x, double y, double z, double w);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos4dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos4f(float x, float y, float z, float w);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos4fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos4i(int x, int y, int z, int w);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos4iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos4s(short x, short y, short z, short w);

        /// <summary>
        /// 
        /// </summary>
        void glRasterPos4sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glReadBuffer(uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glReadPixels(
            int x,
            int y,
            int width,
            int height,
            uint format,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] pixels
            );

        /// <summary>
        /// 
        /// </summary>
        void glRectd(double x1, double y1, double x2, double y2);

        /// <summary>
        /// 
        /// </summary>
        void glRectdv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v1,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v2
            );

        /// <summary>
        /// 
        /// </summary>
        void glRectf(float x1, float y1, float x2, float y2);

        /// <summary>
        /// 
        /// </summary>
        void glRectfv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v1,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v2
            );

        /// <summary>
        /// 
        /// </summary>
        void glRecti(int x1, int y1, int x2, int y2);

        /// <summary>
        /// 
        /// </summary>
        void glRectiv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v1,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v2
            );

        /// <summary>
        /// 
        /// </summary>
        void glRects(short x1, short y1, short x2, short y2);

        /// <summary>
        /// 
        /// </summary>
        void glRectsv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v1,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v2
            );

        /// <summary>
        /// 
        /// </summary>
        int glRenderMode(uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glRotated(double angle, double x, double y, double z);

        /// <summary>
        /// 
        /// </summary>
        void glRotatef(float angle, float x, float y, float z);

        /// <summary>
        /// 
        /// </summary>
        void glScaled(double x, double y, double z);

        /// <summary>
        /// 
        /// </summary>
        void glScalef(float x, float y, float z);

        /// <summary>
        /// 
        /// </summary>
        void glScissor(int x, int y, int width, int height);

        /// <summary>
        /// 
        /// </summary>
        void glSelectBuffer(
            int size,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] buffer
            );

        /// <summary>
        /// 
        /// </summary>
        void glShadeModel(uint mode);

        /// <summary>
        /// 
        /// </summary>
        void glStencilFunc(uint func, int aRef, uint mask);

        /// <summary>
        /// 
        /// </summary>
        void glStencilMask(uint mask);

        /// <summary>
        /// 
        /// </summary>
        void glStencilOp(uint fail, uint zfail, uint zpass);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord1d(double s);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord1dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord1f(float s);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord1fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord1i(int s);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord1iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord1s(short s);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord1sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord2d(double s, double t);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord2dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord2f(float s, float t);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord2fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord2i(int s, int t);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord2iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord2s(short s, short t);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord2sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord3d(double s, double t, double r);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord3f(float s, float t, float r);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord3i(int s, int t, int r);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord3s(short s, short t, short r);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord4d(double s, double t, double r, double q);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord4dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord4f(float s, float t, float r, float q);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord4fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord4i(int s, int t, int r, int q);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord4iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord4s(short s, short t, short r, short q);

        /// <summary>
        /// 
        /// </summary>
        void glTexCoord4sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexEnvf(uint target, uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glTexEnvfv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexEnvi(uint target, uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glTexEnviv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexGend(uint coord, uint pname, double param);

        /// <summary>
        /// 
        /// </summary>
        void glTexGendv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexGenf(uint coord, uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glTexGenfv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexGeni(uint coord, uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glTexGeniv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexImage1D(
            uint target,
            int level,
            int components,
            int width,
            int border,
            uint format,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] pixels
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexImage2D(
            uint target,
            int level,
            int components,
            int width,
            int height,
            int border,
            uint format,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] pixels
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexParameterf(uint target, uint pname, float param);

        /// <summary>
        /// 
        /// </summary>
        void glTexParameterfv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glTexParameteri(uint target, uint pname, int param);

        /// <summary>
        /// 
        /// </summary>
        void glTexParameteriv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        /// <summary>
        /// 
        /// </summary>
        void glTranslated(double x, double y, double z);

        /// <summary>
        /// 
        /// </summary>
        void glTranslatef(float x, float y, float z);

        /// <summary>
        /// 
        /// </summary>
        void glVertex2d(double x, double y);

        /// <summary>
        /// 
        /// </summary>
        void glVertex2dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex2f(float x, float y);

        /// <summary>
        /// 
        /// </summary>
        void glVertex2fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex2i(int x, int y);

        /// <summary>
        /// 
        /// </summary>
        void glVertex2iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex2s(short x, short y);

        /// <summary>
        /// 
        /// </summary>
        void glVertex2sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex3d(double x, double y, double z);

        /// <summary>
        /// 
        /// </summary>
        void glVertex3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex3f(float x, float y, float z);

        /// <summary>
        /// 
        /// </summary>
        void glVertex3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex3i(int x, int y, int z);

        /// <summary>
        /// 
        /// </summary>
        void glVertex3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex3s(short x, short y, short z);

        /// <summary>
        /// 
        /// </summary>
        void glVertex3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex4d(double x, double y, double z, double w);

        /// <summary>
        /// 
        /// </summary>
        void glVertex4dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex4f(float x, float y, float z, float w);

        /// <summary>
        /// 
        /// </summary>
        void glVertex4fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex4i(int x, int y, int z, int w);

        /// <summary>
        /// 
        /// </summary>
        void glVertex4iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glVertex4s(short x, short y, short z, short w);

        /// <summary>
        /// 
        /// </summary>
        void glVertex4sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        /// <summary>
        /// 
        /// </summary>
        void glViewport(int x, int y, int width, int height);

        /// <summary>
        /// 
        /// </summary>
        void glPolygonOffset(float factor, float units);

        /// <summary>
        /// 
        /// </summary>
        void glBindTexture(uint target, uint texture);
    }

    /// <summary>
    /// IWGL Windows Graphics Layer Interface
    /// </summary>
    [ComImport]
    [Guid("0002D282-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWGL
    {
        /// <summary>
        /// 
        /// </summary>
        IntPtr wglCreateContext(IntPtr hdc);

        /// <summary>
        /// 
        /// </summary>
        int wglDeleteContext(IntPtr hglrc);

        /// <summary>
        /// 
        /// </summary>
        IntPtr wglGetCurrentContext();

        /// <summary>
        /// 
        /// </summary>
        IntPtr wglGetCurrentDC();

        /// <summary>
        /// 
        /// </summary>
        int wglMakeCurrent(IntPtr hdc, IntPtr hglrc);

        /// <summary>
        /// 
        /// </summary>
        int wglUseFontBitmapsA(IntPtr hDC, uint first, uint count, uint listbase);

        /// <summary>
        /// 
        /// </summary>
        int wglUseFontBitmapsW(IntPtr hDC, uint first, uint count, uint listbase);

        /// <summary>
        /// 
        /// </summary>
        int SwapBuffers(IntPtr hdc);
    }

    //[ComImport]
    //[Guid(IID.IID_IGLU)]
    //[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    //public interface IGLU
    //{
    // TODO
    //STDMETHOD_(const GLu[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]byte[], gluErrorString)(THIS_ GLenum errCode) PURE;
    //STDMETHOD_(const wchar_t*, gluErrorUnicodeStringEXT)(THIS_ GLenum errCode) PURE;
    //STDMETHOD_(void, gluOrtho2D)(THIS_ GLdouble left, GLdouble right, GLdouble bottom, GLdouble top) PURE;
    //STDMETHOD_(void, gluPerspective)(THIS_ GLdouble fovy, GLdouble aspect, GLdouble zNear, GLdouble zFar) PURE;
    //STDMETHOD_(void, gluPickMatrix)(THIS_ GLdouble x, GLdouble y, GLdouble width, GLdouble height, GLint viewport[4]) PURE;
    //STDMETHOD_(void, gluLookAt)(THIS_ GLdouble eyex, GLdouble eyey, GLdouble eyez, GLdouble centerx, GLdouble centery, GLdouble centerz, GLdouble upx, GLdouble upy, GLdouble upz) PURE;
    //STDMETHOD_(int, gluProject)(THIS_ GLdouble objx, GLdouble objy, GLdouble objz, const GLdouble modelMatrix[16], const GLdouble projMatrix[16], const GLint viewport[4], GLdouble *winx, GLdouble *winy, GLdouble *winz) PURE;
    //STDMETHOD_(int, gluUnProject)(THIS_ GLdouble winx, GLdouble winy, GLdouble winz, const GLdouble modelMatrix[16], const GLdouble projMatrix[16], const GLint viewport[4], GLdouble *objx, GLdouble *objy, GLdouble *objz) PURE;
    //STDMETHOD_(int, gluScaleImage)(THIS_ GLenum format, GLint widthin, GLint heightin, GLenum typein, const void *datain, GLint widthout, GLint heightout, GLenum typeout, void *dataout) PURE;
    //STDMETHOD_(int, gluBuild1DMipmaps)(THIS_ GLenum target, GLint components, GLint width, GLenum format, GLenum type, const void *data) PURE;
    //STDMETHOD_(int, gluBuild2DMipmaps)(THIS_ GLenum target, GLint components, GLint width, GLint height, GLenum format, GLenum type, const void *data) PURE;
    //STDMETHOD_(GLUquadricObj*, gluNewQuadric)(THIS) PURE;
    //STDMETHOD_(void, gluDeleteQuadric)(THIS_ GLUquadricObj *state) PURE;
    //STDMETHOD_(void, gluQuadricNormals)(THIS_ GLUquadricObj *quadObject, GLenum normals) PURE;
    //STDMETHOD_(void, gluQuadricTexture)(THIS_ GLUquadricObj *quadObject, GLboolean textureCoords) PURE;
    //STDMETHOD_(void, gluQuadricOrientation)(THIS_ GLUquadricObj *quadObject, GLenum orientation) PURE;
    //STDMETHOD_(void, gluQuadricDrawStyle)(THIS_ GLUquadricObj *quadObject, GLenum drawStyle) PURE;
    //STDMETHOD_(void, gluCylinder)(THIS_ GLUquadricObj *qobj, GLdouble baseRadius, GLdouble topRadius, GLdouble height, GLint slices, GLint stacks) PURE;
    //STDMETHOD_(void, gluDisk)(THIS_ GLUquadricObj *qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops) PURE;
    //STDMETHOD_(void, gluPartialDisk)(THIS_ GLUquadricObj *qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops, GLdouble startAngle, GLdouble sweepAngle) PURE;
    //STDMETHOD_(void, gluSphere)(THIS_ GLUquadricObj *qobj, GLdouble radius, GLint slices, GLint stacks) PURE;
    //STDMETHOD_(void, gluQuadricCallback)(THIS_ GLUquadricObj *qobj, GLenum which, void (CALLBACK* fn)() ) PURE;
    //STDMETHOD_(GLUtriangulatorObj*, gluNewTess)(THIS) PURE;
    //STDMETHOD_(void, gluTessCallback)(THIS_ GLUtriangulatorObj *tobj, GLenum which, void (CALLBACK* fn)() ) PURE;
    //STDMETHOD_(void, gluDeleteTess)(THIS_ GLUtriangulatorObj *tobj) PURE;
    //STDMETHOD_(void, gluBeginPolygon)(THIS_ GLUtriangulatorObj *tobj) PURE;
    //STDMETHOD_(void, gluEndPolygon)(THIS_ GLUtriangulatorObj *tobj) PURE;
    //STDMETHOD_(void, gluNextContour)(THIS_ GLUtriangulatorObj *tobj, GLenum type) PURE;
    //STDMETHOD_(void, gluTessVertex)(THIS_ GLUtriangulatorObj *tobj, GLdouble v[3], void *data) PURE;
    //STDMETHOD_(GLUnurbsObj*, gluNewNurbsRenderer)(THIS) PURE;
    //STDMETHOD_(void, gluDeleteNurbsRenderer)(THIS_ GLUnurbsObj *nobj) PURE;
    //STDMETHOD_(void, gluBeginSurface)(THIS_ GLUnurbsObj *nobj) PURE;
    //STDMETHOD_(void, gluBeginCurve)(THIS_ GLUnurbsObj *nobj) PURE;
    //STDMETHOD_(void, gluEndCurve)(THIS_ GLUnurbsObj *nobj) PURE;
    //STDMETHOD_(void, gluEndSurface)(THIS_ GLUnurbsObj *nobj) PURE;
    //STDMETHOD_(void, gluBeginTrim)(THIS_ GLUnurbsObj *nobj) PURE;
    //STDMETHOD_(void, gluEndTrim)(THIS_ GLUnurbsObj *nobj) PURE;
    //STDMETHOD_(void, gluPwlCurve)(THIS_ GLUnurbsObj *nobj, GLint count, GLfloat *array, GLint stride, GLenum type) PURE;
    //STDMETHOD_(void, gluNurbsCurve)(THIS_ GLUnurbsObj *nobj, GLint nknots, GLfloat *knot, GLint stride, GLfloat *ctlarray, GLint order, GLenum type) PURE;
    //STDMETHOD_(void, gluNurbsSurface)(THIS_ GLUnurbsObj *nobj, GLint sknot_count, GLfloat *sknot, GLint tknot_count, GLfloat *tknot, GLint s_stride, GLint t_stride, GLfloat *ctlarray, GLint sorder, GLint torder, GLenum type) PURE;
    //STDMETHOD_(void, gluLoadSamplingMatrices)(THIS_ GLUnurbsObj *nobj, const GLfloat modelMatrix[16], const GLfloat projMatrix[16], const GLint viewport[4]) PURE;
    //STDMETHOD_(void, gluNurbsProperty)(THIS_ GLUnurbsObj *nobj, GLenum property, GLfloat value) PURE;
    //STDMETHOD_(void, gluGetNurbsProperty)(THIS_ GLUnurbsObj *nobj, GLenum property, GLfloat *value) PURE;
    //STDMETHOD_(void, gluNurbsCallback)(THIS_ GLUnurbsObj *nobj, GLenum which, void (CALLBACK* fn)() ) PURE;
    //}
}