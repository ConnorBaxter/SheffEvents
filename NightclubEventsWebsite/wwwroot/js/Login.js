//Login stuff

//wish this was php
function checkDetails()
{
    var user = document.getElementById("username").value;
    var pass = document.getElementById("password").value;

    // I want to use this but async breaks e v e r y t h i n g
    //var passHash = await sha256(pass);
    //console.log("PassHash: " + passHash);

    //how can i read this from a database
    //can i do this without php????
    var correct_username = "admin";
    var correct_hash = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8";

    console.log("Username: " + user);
    console.log("Password: " + pass);

    //fix this before submission                                   this is terrible dont use this
    if (user === correct_username /*&& passHash === correct_hash*/ && pass === "password")
    {
        event.preventDefault();
        console.log("Correct details");
        document.getElementById("loginBtn").click();
        return false;
    }
    else
    {
        console.log("Incorrect details!");

        alert("Incorrect username or password");

        // cant have this and no page refresh, use alert even though its annoying 
        //incorrectPasswordDiv.style = "display: block";
        return false;
    }
  
}

// I dont like this being async but doesn't work synchronously
async function sha256(message) {
    // encode as UTF-8
    const msgBuffer = new TextEncoder().encode(message);

    // hash the message
    const hashBuffer = await crypto.subtle.digest('SHA-256', msgBuffer);

    // convert ArrayBuffer to Array
    const hashArray = Array.from(new Uint8Array(hashBuffer));

    // convert bytes to hex string                  
    const hashHex = hashArray.map(b => b.toString(16).padStart(2, '0')).join('');
    return hashHex;
}