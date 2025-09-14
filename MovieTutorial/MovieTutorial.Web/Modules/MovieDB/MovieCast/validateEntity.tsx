import { Decorators } from "@serenity-is/corelib";
import { GridEditorBase } from "@serenity-is/extensions";
import { MovieCastColumns, MovieCastRow, PersonRow } from '../../ServerTypes/MovieDB';
import { MovieCastEditDialog } from "./MovieCastEditDialog";

@Decorators.registerEditor("MovieTutorial.MovieDB.MovieCastEditor")
export class MovieCastEditor extends GridEditorBase<MovieCastRow> {
    //...
    protected validateEntity(row: MovieCastRow, id: number) {
        if (!super.validateEntity(row, id))
            return false;

        var itemId = id ?? row[this.getIdProperty()];
        PersonRow.getLookupAsync().then(x => {
            var item = this.view?.getItemById(itemId);
            if (item) {
                item.PersonFullName = x.itemById[row.PersonId].FullName;
                this.view.updateItem(itemId, item);
            }
        });

        return true;
    }
}