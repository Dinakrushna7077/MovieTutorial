import { StringEditor, DateEditor, EnumEditor, IntegerEditor, ImageUploadEditor, MultipleImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { PersonMovieGrid } from "../../MovieDB/Person/PersonMovieGrid";
import { Gender } from "./Gender";

export interface PersonForm {
    FirstName: StringEditor;
    LastName: StringEditor;
    BirthDate: DateEditor;
    BirthPlace: StringEditor;
    Gender: EnumEditor;
    Height: IntegerEditor;
    PrimaryImage: ImageUploadEditor;
    GalleryImages: MultipleImageUploadEditor;
    MoviesGrid: PersonMovieGrid;
}

export class PersonForm extends PrefixedContext {
    static readonly formKey = 'MovieDB.Person';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PersonForm.init)  {
            PersonForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = EnumEditor;
            var w3 = IntegerEditor;
            var w4 = ImageUploadEditor;
            var w5 = MultipleImageUploadEditor;
            var w6 = PersonMovieGrid;

            initFormType(PersonForm, [
                'FirstName', w0,
                'LastName', w0,
                'BirthDate', w1,
                'BirthPlace', w0,
                'Gender', w2,
                'Height', w3,
                'PrimaryImage', w4,
                'GalleryImages', w5,
                'MoviesGrid', w6
            ]);
        }
    }
}

[Gender]; // referenced types