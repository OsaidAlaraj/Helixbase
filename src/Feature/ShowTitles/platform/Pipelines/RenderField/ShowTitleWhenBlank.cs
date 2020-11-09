using Sitecore.Pipelines.RenderField;

namespace Helixbase.Feature.ShowTitles.Platform.Pipelines.RenderField
{
    public class ShowTitleWhenBlank
    {
        public void Process(RenderFieldArgs args)
        {
            args.RenderParameters["show-title-when-blank"] = "true";
        }
    }
}
