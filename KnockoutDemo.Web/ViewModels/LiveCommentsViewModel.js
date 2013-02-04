function CommentType(type, icon) {
    var self = this;

    self.Type = type;
    self.Icon = icon;
}

function CommentModel(minute, commentType, comment) {
    var self = this;

    self.Minute = ko.observable(minute);
    self.CommentType = ko.observable(commentType); 
    self.Comment = ko.observable(comment);
}

function LiveCommentsViewModel(webapiUrl) {
    var self = this;

    self.IsEditable = ko.observable(true);
    self.Current = ko.observable(new CommentModel());

    self.SelectedCommentType = ko.observableArray();
    self.CommentTypes = ko.observableArray([new CommentType('COMMENT', ''),
                                            new CommentType('GOL', 'Content/images/Soccer_Ball_16x16.png'),
                                            new CommentType('FAULT', 'Content/images/Soccer_Fault_16x16.png'), 
                                            new CommentType('PENAL', 'Content/images/Soccer_Ball_12x12.png')]);

    self.Comments = ko.observableArray([
        new CommentModel("", new CommentType('COMMENT', ''), "El Partido comenzara a las 19:30"),
    ]);

    self.AddComment = function () {
        var newComment = new CommentModel(self.Current().Minute(),
                                          self.SelectedCommentType(), 
                                          self.Current().Comment());


        self.Comments.push(newComment);
        self.Current(new CommentModel());

        $.ajax({
            type: 'POST',
            url: webapiUrl + "/GameComments/SetGameComment",
            data: ko.toJSON(newComment),
            dataType: "json",
            contentType: "application/json"
        });
    };

    self.RemoveComment = function (comment) {
        self.Comments.remove(comment);
    };

    self.EditComment = function (comment) {

    };
}