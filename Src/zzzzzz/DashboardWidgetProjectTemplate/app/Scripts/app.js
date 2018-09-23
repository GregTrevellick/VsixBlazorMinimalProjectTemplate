//https://github.com/Microsoft/vss-web-extension-sdk

VSS.init({
    explicitNotifyLoaded: true,
    usePlatformStyles: true
});

VSS.require("TFS/Dashboards/WidgetHelpers", function (WidgetHelpers) {

    //https://docs.microsoft.com/en-us/vsts/extend/develop/styles-from-widget-sdk?view=vsts
    WidgetHelpers.IncludeWidgetStyles();
    WidgetHelpers.IncludeWidgetConfigurationStyles();

    var registerWidget = function () {
        return {
            load: function (widgetSettings) {
                return WidgetHelpers.WidgetStatusHelper.Success();
            }
        }
    }

    VSS.register("Your_VSS.register_JavascriptFunctionCallParamaterValue", registerWidget);

    VSS.notifyLoadSucceeded();
});
