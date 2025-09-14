import { Decorators, EntityGrid, WidgetProps } from "@serenity-is/corelib";
import { MovieCastRow, MovieCastService, PersonMovieColumns } from "../../ServerTypes/MovieDB";

@Decorators.registerEditor("MovieTutorial.MovieDB.PersonMovieGrid")
export class PersonMovieGrid<P = {}> extends EntityGrid<MovieCastRow, P> {
    protected getColumnsKey() { return PersonMovieColumns.columnsKey; }
    protected getRowDefinition() { return MovieCastRow; }
    protected getService() { return MovieCastService.baseUrl; }

    constructor(props: WidgetProps<P>) {
        super(props);
    }

    protected getButtons() {
        return null;
    }

    protected getInitialTitle() {
        return null;
    }

    protected usePager() {
        return false;
    }

    protected getGridCanLoad() {
        return this.personId != null;
    }

    private _personId: number;

    get personId() {
        return this._personId;
    }

    set personId(value: number) {
        if (this._personId != value) {
            this._personId = value;
            this.setEquality(MovieCastRow.Fields.PersonId, value);
            this.refresh();
        }
    }
}