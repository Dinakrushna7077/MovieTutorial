using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieTutorial.Administration.LanguageRow>;
using MyRow = MovieTutorial.Administration.LanguageRow;

namespace MovieTutorial.Administration;
public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageRetrieveHandler
{
}