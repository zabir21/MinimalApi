﻿using Application.Abstractions;
using Application.Posts.Commands;
using MediatR;

namespace Application.Posts.CommandHandlers
{
    public class DeletePostHandler : IRequestHandler<DeletePost>
    {
        private readonly IPostRepository _postsRepo;
        public DeletePostHandler(IPostRepository postsRepo)
        {
            _postsRepo = postsRepo;
        }

        public async Task Handle(DeletePost request, CancellationToken cancellationToken)
        {
            await _postsRepo.DeletePost(request.PostId);
        }
    }
}
