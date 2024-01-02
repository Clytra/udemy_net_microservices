using CQRS.Core.Commands;

namespace Post.Query.Api.Commands;

public class AddCommentCommand : BaseCommand
{
    public string Comment { get; set; }
    public string Username { get; set; }
}