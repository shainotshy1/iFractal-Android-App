//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("SkiaSharpFormsDemos.Transforms.CenteredScalePage.xaml", "Transforms/CenteredScalePage.xaml", typeof(global::SkiaSharpFormsDemos.Transforms.CenteredScalePage))]

namespace SkiaSharpFormsDemos.Transforms {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Transforms\\CenteredScalePage.xaml")]
    public partial class CenteredScalePage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Slider xScaleSlider;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Slider yScaleSlider;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SkiaSharp.Views.Forms.SKCanvasView canvasView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(CenteredScalePage));
            xScaleSlider = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Slider>(this, "xScaleSlider");
            yScaleSlider = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Slider>(this, "yScaleSlider");
            canvasView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SkiaSharp.Views.Forms.SKCanvasView>(this, "canvasView");
        }
    }
}