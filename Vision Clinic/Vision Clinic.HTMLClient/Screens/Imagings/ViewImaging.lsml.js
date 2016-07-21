/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewImaging.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.Imaging.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.Imaging." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

