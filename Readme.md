<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128651264/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3120)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Data Grid - Implement Custom Scroll Animation for Per-Pixel Scrolling

This example shows how to implement a custom animation displayed when a user vertically scrolls the [GridControl](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) (per-pixel scrolling):

1. Set the [TableView.AllowScrollAnimation](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.AllowScrollAnimation) property to `true`.
2. Set the [TableView.ScrollAnimationMode](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.ScrollAnimationMode) property to `Custom`.
3. Handle the [TableView.CustomScrollAnimation](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.CustomScrollAnimation) event and specify a custom scroll animation.

![Grid_CustomScrolling](https://user-images.githubusercontent.com/65009440/175501758-9fb2597f-3c39-4103-a964-21b53de0b19c.gif)

<!-- default file list -->

## Files to look at

* [MainWindow.xaml](./CS/DXGrid_CustomScrollAnimation/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXGrid_CustomScrollAnimation/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXGrid_CustomScrollAnimation/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXGrid_CustomScrollAnimation/MainWindow.xaml.vb))

<!-- default file list end -->

## Documentation

* [Per-Pixel Scrolling](http://docs.devexpress.com/WPF/9791/controls-and-libraries/data-grid/paging-and-scrolling/per-pixel-scrolling)
* [Data Scrolling](http://docs.devexpress.com/WPF/6120/controls-and-libraries/data-grid/paging-and-scrolling/data-scrolling-overview)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-implement-custom-scroll-animation-for-per-pixel-scrolling&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-implement-custom-scroll-animation-for-per-pixel-scrolling&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
