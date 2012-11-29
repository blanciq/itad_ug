window.PollViewModel = function () {
    var self = this;

    self.Question = ko.observable();
    self.Answers = ko.observableArray();
    self.Votes = ko.observableArray();
    self.Answer = ko.observable();
    self.Percentage = ko.computed(function () {
        if (self.Votes().length === 0)
            return 50;
        var sum = self.Votes()[0].Count() + self.Votes()[1].Count();
        if (sum === 0)
            return 50;
        return parseInt(self.Votes()[0].Count() * 100 / (sum), 10);
    });


    self.refresh = function(data) {
        self.Question(data.Question);
        self.Answers(data.Answers);
        self.refreshVotes(data.Votes);
    };

    self.refreshVotes = function(votes) {
        self.Votes($.map(votes, function(vote) { return new Vote(vote); }));
    };
    
    self.vote = function() {
        //DAL.vote(self.Answer).done(self.refreshVotes);
        hub.server.vote(self.Answer());
    };
};

window.Vote = function (vote) {
    var self = this;
    self.Answer = vote.Answer;
    self.Count = ko.observable(vote.Count);
};