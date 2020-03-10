using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;
using System.ComponentModel.Composition;

namespace Deployment
{
    [Export(typeof(IImportExtensions))]
    public class Featuretest : ImportExtension
    {
        public override string GetLongNameOfImport => "Featuretest";

        public override string GetImportPackageDataFolderName => "Featuretest";

        public override string GetImportPackageDescriptionText => "Featuretest";

        public override bool AfterPrimaryImport()
        {
            return true;
        }

        public override bool BeforeImportStage()
        {
            return true;
        }

        public override string GetNameOfImport(bool plural)
        {
            return "Featuretest";
        }

        public override void InitializeCustomExtension()
        {
            //Do Nothing
        }

    }
}
