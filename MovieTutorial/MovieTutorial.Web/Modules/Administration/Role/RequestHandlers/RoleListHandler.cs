using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieTutorial.Administration.RoleRow>;
using MyRow = MovieTutorial.Administration.RoleRow;


namespace MovieTutorial.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler(IRequestContext context)
    : ListRequestHandler<MyRow, MyRequest, MyResponse>(context), IRoleListHandler
{
}