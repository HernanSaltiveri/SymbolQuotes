

var availableTags = ["AAPL", "MSFT"];

var Quote = function () {
    var self = this;
    self.Symbol = "AAPL";
    self.LastPrice = "100";
    self.SetData = function (data) {
        self.Symbol = data.Symbol;
        self.LastPrice = data.LastPrice;

        self.Name = data.Name;
        self.Change = data.Change;
        self.ChangePercent = data.ChangePercent;
        self.TimeStamp = data.TimeStamp;
        self.MSDate = data.MSDate;
        self.MarketCap = data.MarketCap;
        self.Volume = data.Volume;
        self.ChangeYTD = data.ChangeYTD;
        self.ChangePercentYTD = data.ChangePercentYTD;
        self.High = data.High;
        self.Low = data.Low;
        self.Open = data.Open;

    }
}
var UI = function () {
    var self = this;
    self.ShowQuote = function (data) {
        document.getElementById('qSymbol').innerHTML = data.Symbol;
        document.getElementById('qLastPrice').innerHTML = data.LastPrice;

        document.getElementById('qName').innerHTML = data.Name;
        document.getElementById('qChange').innerHTML = data.Change;
        document.getElementById('qChangePercent').innerHTML = data.ChangePercent;
        document.getElementById('qTimeStamp').innerHTML = data.TimeStamp;
        document.getElementById('qMSDate').innerHTML = data.MSDate;

        document.getElementById('qMarketCap').innerHTML = data.MarketCap;
        document.getElementById('qVolume').innerHTML = data.Volume;
        document.getElementById('qChangeYTD').innerHTML = data.ChangeYTD;
        document.getElementById('qChangePercentYTD').innerHTML = data.ChangePercentYTD;
        document.getElementById('qHigh').innerHTML = data.High;
        document.getElementById('qLow').innerHTML = data.Low;
        document.getElementById('qOpen').innerHTML = data.Open;


    };
    self.RefreshAutocomplete = function () {
        var url = "/apinew/quotes/GetSymbols?filter=aadl";
        $.get(url, null, function (data) {
            availableTags = [];
            var arr_from_json = JSON.parse(data);
            var arrayLength = arr_from_json.length;
            for (var i = 0; i < arrayLength; i++) {
                var tag = arr_from_json[i];
                availableTags.push(tag.Symbol);
            }
            $("#symbols").autocomplete({ source: availableTags });
        });
    }
    self.GetQuote = function () {
        var smbl = document.getElementById('symbols').value;
        document.getElementById('quoteLbl').innerHTML = smbl;
        var urlgetQuotes = "/apinew/quotes/getQuote?symbol=" + smbl;

        $.get(urlgetQuotes, null, function (data) {
            var qjson = JSON.parse(data);
            currentQuote.SetData(qjson);
            self.ShowQuote(currentQuote);

        });
    }
}

var currentQuote = new Quote();
var cUI = new UI();
cUI.ShowQuote(currentQuote);

$(document).ready(function () {
    cUI.RefreshAutocomplete();
});


$('#searchBtn').click(function () {
    cUI.GetQuote();
});

