var blazorInterop = blazorInterop || {};

blazorInterop.showAlert = function showAlert(message) {
    alert(message)
};

blazorInterop.logToConsoleTable = function (obj) {
    console.table(obj);
}

blazorInterop.showPrompt = function (message, defaultValue) {
    return prompt(message, defaultValue)
}

blazorInterop.createEmployee = function (firstName, lastName) {
    return {
        firstName,
        lastName,
        email: firstName + "@test.com",
    };
}

blazorInterop.focusElement = function (element) {
    element.focus();
}

blazorInterop.focusElementById = function (id) {
    var element = document.getElementById(id)
    if (element) element.focus();
}

blazorInterop.throwsError = function () {
    throw Error("function was not implemented");
}