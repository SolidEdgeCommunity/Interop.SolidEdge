using System;
using System.Collections.Generic;
using System.Text;

namespace SolidEdge
{
    /// <summary>
    /// Solid Edge category IDs imported from \sdk\include\secatids.h.
    /// </summary>
    public static class CATID
    {
        public const string SolidEdgeAddIn = "26B1D2D1-2B03-11d2-B589-080036E8B802";
        public const string SEApplication = "26618394-09D6-11d1-BA07-080036230602";
        public const string SEAssembly = "26618395-09D6-11d1-BA07-080036230602";
        public const string SEMotion = "67ED3F40-A351-11d3-A40B-0004AC969602";
        public const string SEPart = "26618396-09D6-11d1-BA07-080036230602";
        public const string SEProfile = "26618397-09D6-11d1-BA07-080036230602";
        public const string SEFeatureRecognition = "E6F9C8DC-B256-11d3-A41E-0004AC969602";
        public const string SESheetMetal = "26618398-09D6-11D1-BA07-080036230602";
        public const string SEDraft = "08244193-B78D-11D2-9216-00C04F79BE98";
        public const string SEWeldment = "7313526A-276F-11D4-B64E-00C04F79B2BF";
        public const string SEXpresRoute = "1661432A-489C-4714-B1B2-61E85CFD0B71";
        public const string SEExplode = "23BE4212-5810-478b-94FF-B4D682C1B538";
        public const string SESimplify = "CE3DCEBF-E36E-4851-930A-ED892FE0772A";
        public const string SEStudio = "D35550BF-0810-4f67-97D5-789EDBC23F4D";
        public const string SELayout = "27B34941-FFCD-4768-9102-0B6698656CEA";
        public const string SESketch = "0DDABC90-125E-4cfe-9CB7-DC97FB74CCF4";
        public const string SEProfileHole = "0D5CC5F7-5BA3-4d2f-B6A9-31D9B401FE30";
        public const string SEProfilePattern = "7BD57D4B-BA47-4a79-A4E2-DFFD43B97ADF";
        public const string SEProfileRevolved = "FB73C683-1536-4073-B792-E28B8D31146E";
        public const string SEDrawingViewEdit = "8DBC3B5F-02D6-4241-BE96-B12EAF83FAE6";
        public const string SERefAxis = "B21CCFF8-1FDD-4f44-9417-F1EAE06888FA";
        public const string SECuttingPlaneLine = "7C6F65F1-A02D-4c3c-8063-8F54B59B34E3";
        public const string SEBrokenOutSectionProfile = "534CAB66-8089-4e18-8FC4-6FA5A957E445";
        public const string SEFrame = "D84119E8-F844-4823-B3A0-D4F31793028A";
        public const string SE2dModel = "F6031120-7D99-48a7-95FC-EEE8038D7996";
        public const string SEEditBlockView = "892A1CDA-12AE-4619-BB69-C5156C929832";
        public const string SEComponentSketchInPart = "FAB8DC23-00F4-4872-8662-18DD013F2095";
        public const string SEComponentSketchInAsm = "86D925FB-66ED-40d2-AA3D-D04E74838141";
        public const string SEHarness = "5337A0AB-23ED-4261-A238-00E2070406FC";
        public const string SEAll = "C484ED57-DBB6-4a83-BEDB-C08600AF07BF";
        public const string SEAllDocumentEnvrionments = "BAD41B8D-18FF-42c9-9611-8A00E6921AE8";
        public const string SEDMPart = "D9B0BB85-3A6C-4086-A0BB-88A1AAD57A58";
        public const string SEDMSheetMetal = "9CBF2809-FF80-4dbc-98F2-B82DABF3530F";
        public const string SEDMAssembly = "2C3C2A72-3A4A-471d-98B5-E3A8CFA4A2BF";
        public const string SESimplifiedAssemblyPart = "E7350DC3-6E7A-4D53-A53F-5B1C7A0709B3";
        public const string Sketch3d = "07F05BA4-18CD-4B87-8E2F-49864E71B41F";

        public static readonly Guid SolidEdgeAddInGuid = new Guid(SolidEdgeAddIn);
        public static readonly Guid SEApplicationGuid = new Guid(SEApplication);
        public static readonly Guid SEAssemblyGuid = new Guid(SEAssembly);
        public static readonly Guid SEMotionGuid = new Guid(SEMotion);
        public static readonly Guid SEPartGuid = new Guid(SEPart);
        public static readonly Guid SEProfileGuid = new Guid(SEProfile);
        public static readonly Guid SEFeatureRecognitionGuid = new Guid(SEFeatureRecognition);
        public static readonly Guid SESheetMetalGuid = new Guid(SESheetMetal);
        public static readonly Guid SEDraftGuid = new Guid(SEDraft);
        public static readonly Guid SEWeldmentGuid = new Guid(SEWeldment);
        public static readonly Guid SEXpresRouteGuid = new Guid(SEXpresRoute);
        public static readonly Guid SEExplodeGuid = new Guid(SEExplode);
        public static readonly Guid SESimplifyGuid = new Guid(SESimplify);
        public static readonly Guid SEStudioGuid = new Guid(SEStudio);
        public static readonly Guid SELayoutGuid = new Guid(SELayout);
        public static readonly Guid SESketchGuid = new Guid(SESketch);
        public static readonly Guid SEProfileHoleGuid = new Guid(SEProfileHole);
        public static readonly Guid SEProfilePatternGuid = new Guid(SEProfilePattern);
        public static readonly Guid SEProfileRevolvedGuid = new Guid(SEProfileRevolved);
        public static readonly Guid SEDrawingViewEditGuid = new Guid(SEDrawingViewEdit);
        public static readonly Guid SERefAxisGuid = new Guid(SERefAxis);
        public static readonly Guid SECuttingPlaneLineGuid = new Guid(SECuttingPlaneLine);
        public static readonly Guid SEBrokenOutSectionProfileGuid = new Guid(SEBrokenOutSectionProfile);
        public static readonly Guid SEFrameGuid = new Guid(SEFrame);
        public static readonly Guid SE2dModelGuid = new Guid(SE2dModel);
        public static readonly Guid SEEditBlockViewGuid = new Guid(SEEditBlockView);
        public static readonly Guid SEComponentSketchInPartGuid = new Guid(SEComponentSketchInPart);
        public static readonly Guid SEComponentSketchInAsmGuid = new Guid(SEComponentSketchInAsm);
        public static readonly Guid SEHarnessGuid = new Guid(SEHarness);
        public static readonly Guid SEAllGuid = new Guid(SEAll);
        public static readonly Guid SEAllDocumentEnvrionmentsGuid = new Guid(SEAllDocumentEnvrionments);
        public static readonly Guid SEDMPartGuid = new Guid(SEDMPart);
        public static readonly Guid SEDMSheetMetalGuid = new Guid(SEDMSheetMetal);
        public static readonly Guid SEDMAssemblyGuid = new Guid(SEDMAssembly);
        public static readonly Guid SESimplifiedAssemblyPartGuid = new Guid(SESimplifiedAssemblyPart);
        public static readonly Guid Sketch3dGuid = new Guid(Sketch3d);
    }

    /// <summary>
    /// Solid Edge CLSIDs from registry.
    /// </summary>
    public static class CLSID
    {
        public const string SolidEdgeApplication = "DED89DB0-45B6-11CE-B307-0800363A1E02";
    }
    /// <summary>
    /// Solid Edge IIDs imported from \sdk\include\igl.h.
    /// </summary>
    public static partial class IID
    {
        // IGL Interface IIDs
        public const string IGL = "0002D280-0000-0000-C000-000000000046";
        public const string IGLU = "0002D283-0000-0000-C000-000000000046";
        public const string IWGL = "0002D282-0000-0000-C000-000000000046";
        public const string IGLControl = "0002D281-0000-0000-C000-000000000046";
        public const string IGLUControl = "0002D284-0000-0000-C000-000000000046";
        public const string IGLExtension = "66EEE92E-5AB5-11D1-A266-08003654E902";
        public const string IViewGLObject = "0002D201-0000-0000-C000-000000000046";

        public static readonly Guid IGLGuid = new Guid(IGL);
        public static readonly Guid IGLUGuid = new Guid(IGLU);
        public static readonly Guid IWGLGuid = new Guid(IWGL);
        public static readonly Guid IGLControlGuid = new Guid(IGLControl);
        public static readonly Guid IGLUControlGuid = new Guid(IGLUControl);
        public static readonly Guid IGLExtensionGuid = new Guid(IGLExtension);
        public static readonly Guid IViewGLObjectGuid = new Guid(IViewGLObject);
    }

    /// <summary>
    /// Solid Edge PROGIDs from registry.
    /// </summary>
    public static class PROGID
    {
        public const string Application = "SolidEdge.Application";
        public const string AssemblyDocument = "SolidEdge.AssemblyDocument";
        public const string DraftDocument = "SolidEdge.DraftDocument";
        public const string FileProperties = "SolidEdge.FileProperties";
        public const string InstallData = "SolidEdge.InstallData";
        public const string PartDocument = "SolidEdge.PartDocument";
        public const string SheetMetalDocument = "SolidEdge.SheetMetalDocument";
        public const string WeldmentDocument = "SolidEdge.WeldmentDocument";
    }
}
