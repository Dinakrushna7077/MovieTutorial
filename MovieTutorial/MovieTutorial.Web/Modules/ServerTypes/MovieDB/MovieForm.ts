import { StringEditor, TextAreaEditor, ImageUploadEditor, MultipleImageUploadEditor, IntegerEditor, DateEditor, EnumEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { MovieCastEditor } from "../../MovieDB/MovieCast/MovieCastEditor";
import { MovieKind } from "./MovieKind";

export interface MovieForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    CastList: MovieCastEditor;
    PrimaryImage: ImageUploadEditor;
    GalleryImages: MultipleImageUploadEditor;
    Storyline: TextAreaEditor;
    Year: IntegerEditor;
    ReleaseDate: DateEditor;
    Runtime: IntegerEditor;
    Kind: EnumEditor;
    GenreList: LookupEditor;
}

export class MovieForm extends PrefixedContext {
    static readonly formKey = 'MovieDB.Movie';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MovieForm.init)  {
            MovieForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = MovieCastEditor;
            var w3 = ImageUploadEditor;
            var w4 = MultipleImageUploadEditor;
            var w5 = IntegerEditor;
            var w6 = DateEditor;
            var w7 = EnumEditor;
            var w8 = LookupEditor;

            initFormType(MovieForm, [
                'Title', w0,
                'Description', w1,
                'CastList', w2,
                'PrimaryImage', w3,
                'GalleryImages', w4,
                'Storyline', w1,
                'Year', w5,
                'ReleaseDate', w6,
                'Runtime', w5,
                'Kind', w7,
                'GenreList', w8
            ]);
        }
    }
}

[MovieKind]; // referenced types