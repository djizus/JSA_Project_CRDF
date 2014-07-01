function DisableFollowingCbo(ref) {
    var temp;
    switch (ref.name) {
        case 'SelectRegion':
            temp = document.getElementById("Organisation");
            temp.setAttribute("disabled", "disabled");
            temp.selectedIndex = 0;
            temp = document.getElementById("Supervisor");
            temp.setAttribute("disabled", "disabled");
            temp.selectedIndex = 0;
            break;

        case "Organisation":
            temp = document.getElementById("Supervisor");
            temp.setAttribute("disabled", "disabled");
            temp.selectedIndex = 0;
            break;

        default:
            break;
    }
}

function deleteAssDoc() {
    var id = document.getElementById("Task_ID").value;
    $.ajax({
        url: "deleteAssDoc",
        data: { taskid: id },
        cache: false,
        success: function (html) {
            alert(html);
            location.reload();
        }
    });
    return false;
}

//ADMIN PART
function Add(displayThis) {
    var item1 = document.getElementById(displayThis + "add").value;
    var args = null;
    var urlajax = null;
    var error = "";
    if (item1 != "") {
        switch (displayThis) {
            case "admin":
                args = { nameAdmin: item1 };
                urlajax = "addAdmin";
                break;

            case "branch":
                var item2 = document.getElementById(displayThis + "add2").value;
                if (item2.value == "")
                    error = "Fill in the blank"
                args = { nameFR: item1, nameEng: item2 };
                urlajax = "addBranch";
                break;

            case "region":
                var item2 = document.getElementById(displayThis + "add2").value;
                if (item2.value == "")
                    error = "Fill in the blank"
                args = { nameFR: item1, nameEng: item2 };
                urlajax = "addRegion";
                break;

            case "Organisation":
                var item2 = document.getElementById(displayThis + "add2").value;
                if (item2.value == "")
                    error = "Fill in the blank"
                var div = document.getElementById("DivOrganisation");
                var select = div.getElementsByTagName('select');
                var item3 = select[0].value;
                if (item3 == 0)
                    error = "Pick a region"
                args = { nameFR: item1, nameEng: item2, nameRegion: item3 };
                urlajax = "addOrganisation";
                break;

            case "env":
                var item2 = document.getElementById(displayThis + "add2").value;
                if (item2.value == "")
                    error = "Fill in the blank"
                args = { nameFR: item1, nameEng: item2 };
                urlajax = "addEnv";
                break;

            case "supervisor":
                var div = document.getElementById("supervisorDiv");
                var select = div.getElementsByTagName('select');
                var item2 = select[1].value;
                if (item2 == 0)
                    error = "Pick an organisation !"
                args = { namesupervisor: item1, idOrganisation: item2 };
                urlajax = "addSupervisor";
                break;

            default:
                s = "Error, undefined choice";
                break;
        }
        if (error == "") {
            $.ajax({
                type: 'GET',
                data: args,
                datatype: "json",
                url: urlajax,
                success: function (result) {
                    alert(result);
                    location.reload();
                }
            });
        }
        else
            alert(error);
    }
    else
        alert('Fill in the blank !');
}


function Delete(displayThis) {
    var args = null;
    var urlajax = null;
    var error = "";
    switch (displayThis) {
        case "admin":
            var item = document.getElementById("adminAjax").value;
            args = { nameAdmin: item };
            urlajax = "deleteAdmin";
            break;

        case "branch":
            var item = document.getElementById("BranchEnv").value;
            if (item == 0)
                error = "Pick a branch !"
            args = { idBranch: item };
            urlajax = "deleteBranch";
            break;

        case "region":
            var item = document.getElementById("SelectRegion").value;
            if (item == 0)
                error = "Pick a region !"
            args = { idRegion: item };
            urlajax = "deleteRegion";
            break;

        case "Organisation":
            var item = document.getElementById("Organisation").value;
            if (item == 0)
                error = "Pick an organisation !"
            args = { idOrganisation: item };
            urlajax = "deleteOrganisation";
            break;

        case "env":
            var item = document.getElementById("WorkEnv").value;
            if (item == 0)
                error = "Pick an environment !"
            args = { idEnv: item };
            urlajax = "deleteEnv";
            break;

        case "supervisor":
            var item = document.getElementById("Supervisor").value;
            if (item == 0)
                error = "Pick a supervisor !"
            args = { idSupervisor: item };
            urlajax = "deleteSupervisor";
            break;

        default:
            s = "Error, undefined choice";
            break;
    }
    if (error != "")
        alert(error);
    else {
        if (confirm('Are you sure ? This CANNOT be reversed !')) {
            $.ajax({
                type: 'GET',
                data: args,
                datatype: "json",
                url: urlajax,
                success: function (result) {
                    alert(result);
                    location.reload();
                }
            });
        }

    }
}

function Modify(choice) {
    var args = null;
    var urlajax = null;
    var error = "";
    var item = null;
    switch (choice) {

        case "branch":
            item = document.getElementById("BranchEnv").value;
            if (item == 0) {
                error = "Pick a branch !";
                break;
            }
            var envEN = prompt("Please enter the English Name of the branch :");
            var envFR = prompt("Entrez le nom Francais de la direction générale :");
            args = { idBranch: item, nameFR: envFR, nameEN: envEN };
            urlajax = "modifyBranch";
            break;

        case "region":
            item = document.getElementById("SelectRegion").value;
            if (item == 0) {
                error = "Pick a region !";
                break;
            }
            var envEN = prompt("Please enter the English Name of the region :");
            var envFR = prompt("Entrez le nom Francais de la région :");
            args = { idRegion: item, nameFR: envFR, nameEN: envEN };
            urlajax = "modifyRegion";
            break;

        case "Organisation":
            item = document.getElementById("Organisation").value;
            if (item == 0) {
                error = "Pick an organisation !";
                break;
            }
            var envEN = prompt("Please enter the English Name of the organisation :");
            var envFR = prompt("Entrez le nom Francais de l'organisation :");
            args = { idOrganisation: item, nameFR: envFR, nameEN: envEN };
            urlajax = "modifyOrganisation";
            break;

        case "env":
            item = document.getElementById("Supervisor").value;
            if (item == 0) {
                error = "Pick an environment !";
                break;
            }
            var envEN = prompt("Please enter the English Name of the environment :");
            var envFR = prompt("Entrez le nom Francais de l'environnement :");
            args = { idEnv: item, nameFR: envFR, nameEN: envEN };
            urlajax = "modifyEnv";
            break;

        case "supervisor":
            item = document.getElementById("Supervisor").value;
            if (item == 0) {
                error = "Pick a supervisor !";
                break;
            }
            var supname = prompt("Please enter the name of the new supervisor :");
            args = { idSupervisor: item, newName: supname };
            urlajax = "modifySupervisor";
            break;

        default:
            s = "Error, undefined choice";
            break;
    }
    if (error != "")
        alert(error);
    else {
        $.ajax({
            type: 'GET',
            data: args,
            datatype: "json",
            url: urlajax,
            success: function (result) {
                alert(result);
                location.reload();
            }
        });
    }
}

//END OF ADMIN PART


//-------------------------------------//
//              Header                 //
//-------------------------------- ----//
function EditJSAHeader() {
    document.getElementById("SelectRegion").removeAttribute("disabled");
    document.getElementById("BranchEnv").removeAttribute("disabled");
    document.getElementById("Organisation").removeAttribute("disabled");
    document.getElementById("WorkEnv").removeAttribute("disabled");
    document.getElementById("Supervisor").removeAttribute("disabled");
    document.getElementById("Task_Name").removeAttribute("disabled");
    ToggleEditSave("header", true);
    return false;
}

//-------------------------------------//
//                 MISC                //
//-------------------------------- ----//
function ShowHideTaskButtons(show) {
    var i = 0;
    var j = 0;
    for (i = 0; i < document.styleSheets.length; i++) {
        var sheet = document.styleSheets[i];
        var rules = new Array();
        try {
            if (sheet.cssRules)
                rules = sheet.cssRules;
            else if (sheet.rules)
                rules = sheet.rules;
            for (j = 0; j < rules.length; j++) {
                switch (rules[j].selectorText) {
                    case ".TasksButtonsBlock":
                        rules[j].style.display = show ? 'block' : 'none';
                        break;
                    case ".TasksButtons":
                        rules[j].style.display = show ? 'inline' : 'none';
                        break;
                    case ".MoveUpDown":
                        rules[j].style.display = show ? 'inline-block' : 'none';
                        break;
                }
            }
        }
        catch (err) {
        }
    }
    return false;
}

function ToggleEditSave(sectionName, SaveVisible) {
    var i = parseInt(document.getElementById("CurrentStage").value);
    switch (i) {
        case 3:
            document.getElementById("CompletedSection2").style.display = "inline-block";
            document.getElementById("divGenInfos").style.display = "inline-block";
            document.getElementById("Steps345").style.display = "none";
        case 2:
            document.getElementById("aEditTasks").style.display = SaveVisible ? "none" : "inline-block";
            document.getElementById("aFinishTasks").style.display = SaveVisible && sectionName == "tasks" ? "inline-block" : "none";
            ShowHideTaskButtons(SaveVisible && (sectionName == "tasks"));
            document.getElementById("EditJSAHeader").style.display = SaveVisible ? "none" : "inline-block";
            document.getElementById("SaveJSAHeader").style.display = SaveVisible && sectionName == "header" ? "inline-block" : "none";
            break;
        case 1:
            ShowHideTaskButtons(SaveVisible && (sectionName == "tasks"));
            document.getElementById("aFinishTasks").style.display = SaveVisible && sectionName == "tasks" ? "inline-block" : "none";
            document.getElementById("EditJSAHeader").style.display = SaveVisible && sectionName == "header" ? "none" : "inline-block";
        case 0:
            document.getElementById("SaveJSAHeader").style.display = SaveVisible && sectionName == "header" ? "inline-block" : "none";
    }
    return false;
}

function SaveTasks() {
    if (parseInt(document.getElementById("TaskCnt").value) > 0) {
        ToggleEditSave("tasks", false);
    }
    return false;
}

function EditTasks() {
    ToggleEditSave("tasks", true);
    return false;
}

function PrintJSA() {
    $('#FullJSA').printElement({ printMode: 'popup' });
    return false;
}

function HeaderResponse(response, status, xhr) {
    var d = document.getElementById("HeaderWaiting");
    d.style.display = "none";
    d = document.getElementById("LanguageChange");
    var href = d.getAttribute("href");
    d.setAttribute("href", href);
}

function saveInfGen() {
    var text = document.getElementById("InfoGen").value;
    var id = document.getElementById("Task_ID").value;
    if (text != "") {
        var args = { InfoGen: text, JSAID: id };
        $.ajax({
            url: "saveInfGen",
            data: args,
            cache: false,
            success: function (html) {
                alert(html);
            }
        });
    }
    else
        alert("Fill in the blank !");
}