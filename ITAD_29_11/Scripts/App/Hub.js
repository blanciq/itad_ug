window.hub = $.connection.pollHub;

hub.client.updateVotes = function (data) {
    viewModel.refreshVotes(data);
};