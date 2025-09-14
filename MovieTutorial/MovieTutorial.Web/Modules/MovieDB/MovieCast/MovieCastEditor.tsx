import { Decorators, WidgetProps } from '@serenity-is/corelib';
import { GridEditorBase } from '@serenity-is/extensions';
import { MovieCastColumns, MovieCastRow } from '../../ServerTypes/MovieDB';
import { MovieCastEditDialog } from './MovieCastEditDialog';

@Decorators.registerEditor("MovieTutorial.MovieDB.MovieCastEditor")
export class MovieCastEditor<P = {}> extends GridEditorBase<MovieCastRow, P> {
    protected getColumnsKey() { return MovieCastColumns.columnsKey }
    protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

    constructor(props: WidgetProps<P>) {
        super(props);
    }
    protected getDialogType() { return MovieCastEditDialog; }
    protected getAddButtonCaption() {
        return "Add";
    }
}