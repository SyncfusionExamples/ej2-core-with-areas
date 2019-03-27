// Write your JavaScript code.

function onChange(args) {
    var scheduleObj = document.getElementById('schedule').ej2_instances[0];
    scheduleObj.selectedDate = args.value;
    scheduleObj.dataBind();
}
