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
        void glAccum(uint op, float value);

        void glAlphaFunc(uint func, float aRef);

        void glBegin(uint mode);

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

        void glBlendFunc(uint sfactor, uint dfactor);

        void glCallList(uint list);

        void glCallLists(
            int n,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] lists
            );

        void glClear(uint mask);

        void glClearAccum(float red, float green, float blue, float alpha);

        void glClearColor(float red, float green, float blue, float alpha);

        void glClearDepth(double depth);

        void glClearIndex(float c);

        void glClearStencil(int s);

        void glClipPlane(
            uint plane,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] equation
            );

        void glColor3b(sbyte red, sbyte green, sbyte blue);

        void glColor3bv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)]
            sbyte[] v
            );

        void glColor3d(double red, double green, double blue);

        void glColor3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glColor3f(float red, float green, float blue);

        void glColor3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glColor3i(int red, int green, int blue);

        void glColor3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glColor3s(short red, short green, short blue);

        void glColor3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glColor3ub(byte red, byte green, byte blue);

        void glColor3ubv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] v
            );

        void glColor3ui(uint red, uint green, uint blue);

        void glColor3uiv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] v
            );

        void glColor3us(ushort red, ushort green, ushort blue);

        void glColor3usv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2)]
            ushort[] v
            );

        void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

        void glColor4bv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)]
            sbyte[] v
            );

        void glColor4d(double red, double green, double blue, double alpha);

        void glColor4dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glColor4f(float red, float green, float blue, float alpha);

        void glColor4fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glColor4i(int red, int green, int blue, int alpha);

        void glColor4iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glColor4s(short red, short green, short blue, short alpha);

        void glColor4sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v)
            ;

        void glColor4ub(byte red, byte green, byte blue, byte alpha);

        void glColor4ubv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] v
            );

        void glColor4ui(uint red, uint green, uint blue, uint alpha);

        void glColor4uiv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] v
            );

        void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);

        void glColor4usv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2)]
            ushort[] v
            );

        void glColorMask(byte red, byte green, byte blue, byte alpha);

        void glColorMaterial(uint face, uint mode);

        void glCopyPixels(int x, int y, int width, int height, uint type);

        void glCullFace(uint mode);

        void glDeleteLists(uint list, int range);

        void glDepthFunc(uint func);

        void glDepthMask(byte flag);

        void glDepthRange(double zNear, double zFar);

        void glDisable(uint cap);

        void glDrawBuffer(uint mode);

        void glDrawPixels(
            int width,
            int height,
            uint format,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] pixels
            );

        void glEdgeFlag(byte flag);

        void glEdgeFlagv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] flag
            );

        void glEnable(uint cap);

        void glEnd();

        void glEndList();

        void glEvalCoord1d(double u);

        void glEvalCoord1dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] u
            );

        void glEvalCoord1f(float u);

        void glEvalCoord1fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] u
            );

        void glEvalCoord2d(double u, double v);

        void glEvalCoord2dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] u
            );

        void glEvalCoord2f(float u, float v);

        void glEvalCoord2fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] u
            );

        void glEvalMesh1(uint mode, int i1, int i2);

        void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);

        void glEvalPoint1(int i);

        void glEvalPoint2(int i, int j);

        void glFeedbackBuffer(
            int size,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] buffer
            );

        void glFinish();

        void glFlush();

        void glFogf(uint pname, float param);

        void glFogfv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glFogi(uint pname, int param);

        void glFogiv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glFrontFace(uint mode);

        void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

        uint glGenLists(int range);

        void glGetBooleanv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] someParams
            );

        void glGetClipPlane(
            uint plane,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] equation
            );

        void glGetDoublev(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] someParams
            );

        uint glGetError();

        void glGetFloatv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glGetIntegerv(uint pname, ref int someParams);

        void glGetLightfv(
            uint light,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glGetLightiv(
            uint light,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glGetMapdv(
            uint target,
            uint query,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v);

        void glGetMapfv(
            uint target,
            uint query,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glGetMapiv(
            uint target,
            uint query,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glGetMaterialfv(
            uint face,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glGetMaterialiv(
            uint face,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glGetPixelMapfv(
            uint map,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] values
            );

        void glGetPixelMapuiv(
            uint map,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] values
            );

        void glGetPixelMapusv(
            uint map,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2)]
            ushort[] values
            );

        void glGetPolygonStipple(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] mask
            );

        sbyte[] glGetString(uint name);

        void glGetTexEnvfv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glGetTexEnviv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glGetTexGendv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] someParams
            );

        void glGetTexGenfv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glGetTexGeniv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glGetTexImage(
            uint target,
            int level,
            uint format,
            uint type,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] pixels
            );

        void glGetTexLevelParameterfv(
            uint target,
            int level,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glGetTexLevelParameteriv(
            uint target,
            int level,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glGetTexParameterfv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glGetTexParameteriv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glHint(uint target, uint mode);

        void glIndexMask(uint mask);

        void glIndexd(double c);

        void glIndexdv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] c
            );

        void glIndexf(float c);

        void glIndexfv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] c
            );

        void glIndexi(int c);

        void glIndexiv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] c
            );

        void glIndexs(short c);

        void glIndexsv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] c
            );

        void glInitNames();

        byte glIsEnabled(uint cap);

        byte glIsList(uint list);

        void glLightModelf(uint pname, float param);

        void glLightModelfv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glLightModeli(uint pname, int param);

        void glLightModeliv(
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glLightf(uint light, uint pname, float param);

        void glLightfv(
            uint light,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glLighti(uint light, uint pname, int param);

        void glLightiv(
            uint light,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glLineStipple(int factor, ushort pattern);

        void glLineWidth(float width);

        void glListBase(uint aBase);

        void glLoadIdentity();

        void glLoadMatrixd(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] m
            );

        void glLoadMatrixf(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] m
            );

        void glLoadName(uint name);

        void glLogicOp(uint opcode);

        void glMap1d(
            uint target,
            double u1,
            double u2,
            int stride,
            int order,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] points
            );

        void glMap1f(
            uint target,
            float u1,
            float u2,
            int stride,
            int order,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] points
            );

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

        void glMapGrid1d(int un, double u1, double u2);

        void glMapGrid1f(int un, float u1, float u2);

        void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

        void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

        void glMaterialf(uint face, uint pname, float param);

        void glMaterialfv(
            uint face,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glMateriali(uint face, uint pname, int param);

        void glMaterialiv(
            uint face,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glMatrixMode(uint mode);

        void glMultMatrixd(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] m
            );

        void glMultMatrixf(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] m
            );

        void glNewList(uint list, uint mode);

        void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

        void glNormal3bv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)]
            sbyte[] v
            );

        void glNormal3d(double nx, double ny, double nz);

        void glNormal3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glNormal3f(float nx, float ny, float nz);

        void glNormal3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glNormal3i(int nx, int ny, int nz);

        void glNormal3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glNormal3s(short nx, short ny, short nz);

        void glNormal3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

        void glPassThrough(float token);

        void glPixelMapfv(
            uint map,
            int mapsize,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] values
            );

        void glPixelMapuiv(
            uint map,
            int mapsize,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] values
            );

        void glPixelMapusv(
            uint map,
            int mapsize,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2)]
            ushort[] values
            );

        void glPixelStoref(uint pname, float param);

        void glPixelStorei(uint pname, int param);

        void glPixelTransferf(uint pname, float param);

        void glPixelTransferi(uint pname, int param);

        void glPixelZoom(float xfactor, float yfactor);

        void glPointSize(float size);

        void glPolygonMode(uint face, uint mode);

        void glPolygonStipple(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
            byte[] mask
            );

        void glPopAttrib();

        void glPopMatrix();

        void glPopName();

        void glPushAttrib(uint mask);

        void glPushMatrix();

        void glPushName(uint name);

        void glRasterPos2d(double x, double y);

        void glRasterPos2dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glRasterPos2f(float x, float y);

        void glRasterPos2fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glRasterPos2i(int x, int y);

        void glRasterPos2iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glRasterPos2s(short x, short y);

        void glRasterPos2sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glRasterPos3d(double x, double y, double z);

        void glRasterPos3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glRasterPos3f(float x, float y, float z);

        void glRasterPos3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glRasterPos3i(int x, int y, int z);

        void glRasterPos3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glRasterPos3s(short x, short y, short z);

        void glRasterPos3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glRasterPos4d(double x, double y, double z, double w);

        void glRasterPos4dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glRasterPos4f(float x, float y, float z, float w);

        void glRasterPos4fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glRasterPos4i(int x, int y, int z, int w);

        void glRasterPos4iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glRasterPos4s(short x, short y, short z, short w);

        void glRasterPos4sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glReadBuffer(uint mode);

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

        void glRectd(double x1, double y1, double x2, double y2);

        void glRectdv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v1,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v2
            );

        void glRectf(float x1, float y1, float x2, float y2);

        void glRectfv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v1,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v2
            );

        void glRecti(int x1, int y1, int x2, int y2);

        void glRectiv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v1,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v2
            );

        void glRects(short x1, short y1, short x2, short y2);

        void glRectsv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v1,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v2
            );

        int glRenderMode(uint mode);

        void glRotated(double angle, double x, double y, double z);

        void glRotatef(float angle, float x, float y, float z);

        void glScaled(double x, double y, double z);

        void glScalef(float x, float y, float z);

        void glScissor(int x, int y, int width, int height);

        void glSelectBuffer(
            int size,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
            uint[] buffer
            );

        void glShadeModel(uint mode);

        void glStencilFunc(uint func, int aRef, uint mask);

        void glStencilMask(uint mask);

        void glStencilOp(uint fail, uint zfail, uint zpass);

        void glTexCoord1d(double s);

        void glTexCoord1dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glTexCoord1f(float s);

        void glTexCoord1fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glTexCoord1i(int s);

        void glTexCoord1iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glTexCoord1s(short s);

        void glTexCoord1sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glTexCoord2d(double s, double t);

        void glTexCoord2dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glTexCoord2f(float s, float t);

        void glTexCoord2fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glTexCoord2i(int s, int t);

        void glTexCoord2iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glTexCoord2s(short s, short t);

        void glTexCoord2sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glTexCoord3d(double s, double t, double r);

        void glTexCoord3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glTexCoord3f(float s, float t, float r);

        void glTexCoord3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glTexCoord3i(int s, int t, int r);

        void glTexCoord3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glTexCoord3s(short s, short t, short r);

        void glTexCoord3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glTexCoord4d(double s, double t, double r, double q);

        void glTexCoord4dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glTexCoord4f(float s, float t, float r, float q);

        void glTexCoord4fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glTexCoord4i(int s, int t, int r, int q);

        void glTexCoord4iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glTexCoord4s(short s, short t, short r, short q);

        void glTexCoord4sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glTexEnvf(uint target, uint pname, float param);

        void glTexEnvfv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glTexEnvi(uint target, uint pname, int param);

        void glTexEnviv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glTexGend(uint coord, uint pname, double param);

        void glTexGendv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] someParams
            );

        void glTexGenf(uint coord, uint pname, float param);

        void glTexGenfv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glTexGeni(uint coord, uint pname, int param);

        void glTexGeniv(
            uint coord,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

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

        void glTexParameterf(uint target, uint pname, float param);

        void glTexParameterfv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] someParams
            );

        void glTexParameteri(uint target, uint pname, int param);

        void glTexParameteriv(
            uint target,
            uint pname,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] someParams
            );

        void glTranslated(double x, double y, double z);

        void glTranslatef(float x, float y, float z);

        void glVertex2d(double x, double y);

        void glVertex2dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glVertex2f(float x, float y);

        void glVertex2fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glVertex2i(int x, int y);

        void glVertex2iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glVertex2s(short x, short y);

        void glVertex2sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glVertex3d(double x, double y, double z);

        void glVertex3dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glVertex3f(float x, float y, float z);

        void glVertex3fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glVertex3i(int x, int y, int z);

        void glVertex3iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glVertex3s(short x, short y, short z);

        void glVertex3sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glVertex4d(double x, double y, double z, double w);

        void glVertex4dv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R8)]
            double[] v
            );

        void glVertex4f(float x, float y, float z, float w);

        void glVertex4fv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
            float[] v
            );

        void glVertex4i(int x, int y, int z, int w);

        void glVertex4iv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
            int[] v
            );

        void glVertex4s(short x, short y, short z, short w);

        void glVertex4sv(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)]
            short[] v
            );

        void glViewport(int x, int y, int width, int height);

        void glPolygonOffset(float factor, float units);

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
        IntPtr wglCreateContext(IntPtr hdc);

        int wglDeleteContext(IntPtr hglrc);

        IntPtr wglGetCurrentContext();

        IntPtr wglGetCurrentDC();

        int wglMakeCurrent(IntPtr hdc, IntPtr hglrc);

        int wglUseFontBitmapsA(IntPtr hDC, uint first, uint count, uint listbase);

        int wglUseFontBitmapsW(IntPtr hDC, uint first, uint count, uint listbase);

        int SwapBuffers(IntPtr hdc);
    }

    /// <summary>
    /// IGLU Graphics Library Utility Interface
    /// </summary>
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