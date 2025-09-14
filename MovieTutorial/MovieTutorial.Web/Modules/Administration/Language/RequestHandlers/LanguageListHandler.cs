using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieTutorial.Administration.LanguageRow>;
using MyRow = MovieTutorial.Administration.LanguageRow;


namespace MovieTutorial.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler(IRequestContext context)
    : ListRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageListHandler
{
}