var ModelTest = {
    marker : [],
    maps: null,
    _LatLng : null,
    setMap : function(value){
        this.maps = value;
    },
    getMap: function () {
        return this.maps;
    },
    clearMap: function () {
        this.maps.setMap(null);
    },
    setMarker: function (value) {
        this.marker.push(value);
    },
    getMarker: function (i) {
        return this.marker[i];
    },
    markerRenderer : function(){
        for (var i = 0; i < this.marker.length; i++) {

            this.marker[i].setMap(this.maps);

            google.maps.event.addListener(this.marker[i], 'dragend', function () { ModelTest.dragOnMap(i, $("#lat"), $("#lng")) });
        }
    },
    initMap: function (el, options, lat, lng) {

        this._LatLng = new google.maps.LatLng(-22.01825761745315, -51.5138365293335);

        this.maps = new google.maps.Map(el, options);

        var markee = new google.maps.Marker({
            position: this._LatLng,
            draggable: true,
            title: 'teste api',
            animation: google.maps.Animation.DROP
        });

        this.setMarker(markee);
        
        ModelTest.moveToCenter(el, this._LatLng);
        this.markerRenderer();
    },
    dragOnMap: function (i, latTarget, lngTarget) {
        var _pLat = 0;
        var _pLng = 0;

        _pLat = this.marker[0].position.lat();
        _pLng = this.marker[0].position.lng();

        var _newLatLng = new google.maps.LatLng(_pLat, _pLng);

        $(latTarget).val(_pLat);
        $(lngTarget).val(_pLng);

        ModelTest.moveToCenter(i, _newLatLng);

    },
    moveToCenter: function (i, _newLatLng) {
        var distanceIN = google.maps.geometry.spherical.computeDistanceBetween(this._LatLng, _newLatLng);

        console.log(distanceIN);

        setTimeout(function () {
            ModelTest.getMap().panTo(_newLatLng);
        },
        1000);
        this._LatLng = _newLatLng;
    }

}