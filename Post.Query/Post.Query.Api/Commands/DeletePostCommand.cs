using CQRS.Core.Commands;

namespace Post.Query.Api.Commands;

public class DeletePostCommand : BaseCommand
{
    public string Username { get; set; }
}