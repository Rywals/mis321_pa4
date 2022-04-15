var baseurl = "https://localhost:5401/Songs";
var sendSong = {};

function handleOnLoad(){
    populateList();
}

function populateList(){

    console.log(baseurl)

    fetch(baseurl).then(function(response) {
		console.log(response);
		return response.json();
	}).then(function(json) {
        console.log(json)
        let html = ``;
		json.forEach((song) => {
            html += `<div id = "cards" class = "container">`;
            html += `<div class = "row">`;
            html += `<div class="card col-md-4 bg-dark text-white">`;
			html += `<img src="./resources/images/music.jpeg" class="card-img" alt="...">`;
			html += `<div class="card-img-overlay">`;
			html += `<h5 class="card-title">`+song.songTitle+`</h5>`;
            html += `<div id = "buttonDelete" class = "button">`;
            html += `<button class="btn btn-dark" onclick="deleteSong(`+song.songID+`)">Delete Song</button>`;
            html += `<div id = "buttonFavorite" class = "button">`;
            html += `<button class="btn btn-dark" onclick="putSong(`+song.songID + `,`+ song.favorited+ `)">Favorite</button>`;
            html += `</div>`;
            html += `</div>`;
            html += `</div>`;
            html += `</div>`;
		});
		
        if(html === ``){
            html = "No Songs found :("
        }
		document.getElementById("cards").innerHTML = html;

	}).catch(function(error) {
		console.log(error);
	})
}

function putSong(id, favorited){
    var putAPISongUrl = baseurl + "/" + id+ "/" + favorited;
    console.log(id);
    console.log(favorited);
    sendSong = {
        id: id,
        songTimestamp: "2022-04-13T03:59:15",
        fav: favorited
    }
    fetch(putAPISongUrl,{
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendSong)
    })
    .then((response) => {
        populateList();
    })
}

function postSong(){
    var postAPISongUrl = baseurl;
    sendSong = {
        songTitle: document.getElementById("title").value,
        songTimestamp: "2022-04-13T03:59:15",
        deleted:"test"
    }
    fetch(postAPISongUrl,{
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendSong)
    })
    .then((response) => {
        populateList();
    })
}


function deleteSong(id){
    var deleteAPISongUrl = baseurl + "/"+ id;
    sendSong = {
        id: id,
        songTimestamp: "2022-04-13T03:59:15",
        deleted:"test"
    }
    fetch(deleteAPISongUrl,{
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendSong)
    })
    .then((response) => {
        populateList();
    })
}

