using ToDo;
using ToDo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundCornerEntry), typeof(RoundCornerEntryRenderer))]
namespace ToDo.Droid
{
    class RoundCornerEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.RoundCornerEditText);
            }
        } 
    }
}