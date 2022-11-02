const url = "http://localhost:5256/Records"
// Change to another REST url to check it's availability (CORS etc)

Vue.createApp({
    data() {
        return {
            message: "",
            musicRecords: [],
            artistToGetBy: "",
            addData: { id: 0, title: "", duration: 0, artist: "" },
            addMessage: ""
        }
    },
    async created() {
        console.log("created")
        try {
            const response = await axios.get(url)
            this.message = response.data
        } catch (error) {
            this.message = error.message
        }
    },

    methods: {
        getAllRecords() {
            this.helperGetAndShow(url)
        },
        getByArtist(artist) {
            const url = baseUrl + "?vendor=" + artist
            this.helperGetAndShow(url)
        },
        async helperGetAndShow(url) { // helper metode: getAllCar + getByVendor are very similar
            try {
                const response = await axios.get(url)
                this.musicRecords = await response.data
            } catch (ex) {
                alert(ex.message) // https://www.w3schools.com/js/js_popup.asp
            }
        },
        async addCar() {
            try {
                response = await axios.post(url, this.addData)
                this.addMessage = "response " + response.status + " " + response.statusText
                this.getAllRecords()
            } catch (ex) {
                alert(ex.message)
            }
    }
}
}).mount("#app")