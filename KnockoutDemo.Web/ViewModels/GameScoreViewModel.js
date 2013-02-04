function GameScoreViewModel(webapiUrl) {
    var self = this;

    self.TeamName1 = ko.observable("");
    self.TeamScore1 = ko.observable("");
    self.TeamName2 = ko.observable("");
    self.TeamScore2 = ko.observable("");
    self.Status = ko.observable("");

    $.ajax({
        type: 'GET',
        url: webapiUrl + "/GameComments/GetGameScore",
        data: { id: "{6FD4950C-9D4D-418F-A71B-DC3A6A546FC2}" },
        dataType: "jsonp",
        success: function (data) {
            self.TeamName1(data.TeamName1);
            self.TeamScore1(data.TeamScore1);
            self.TeamName2(data.TeamName2);
            self.TeamScore2(data.TeamScore2);
            self.Status(data.Status);
        },
        error: function (errorData, exception) {
            alert(exception);
        }
    });
}