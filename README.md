## _AssistanceLibrary_


AssistanceLibrary - is a library to help beginners write code without delving into certain points of development, for example: searching or writing a json file, the same with a txt document.
This library, in theory, is somewhat similar to the System.Linq, but you can download and rewrite this. It's not full version of program, but i try to update this. 

## _Right now this application have:_
- 5 classes with 2 or more methods: 
ArrayHelper, DictionaryHelper, ListHelper, WriteAndReadFile. I won't tell name of method here, you can read this information ahead;
- All methods do functional without errors, if this not a syntax error from your side;
- Error handlers are not written, so errors will be highlighted as standard.
I tried to check this code, so that it does not break.

## _If you want use this code you must:__
- In main page repository click button with name "Code" and "Download ZIP". Wait for it to load;
-  After load you must unzip this program;
- Open your project in Visual Studio and in the solution explorer right mouse button click at "Dependencies" or what you see under the project name;
-  After item number 3 you can see "Add a link to the project". Left mouse button click on the button.
-  Did a new page fallout? Dont worry about it - it's good. Left-click on the button with the name "overview...";;
- Search progect in this dialog and go to "AssistanceLibrary\AssistanceLibrary\bin\Debug\net5.0\". Right now you can see dll file. Select him and click "Add";
- Click "OK" and lets'go to code.
- Write this line "using AssistanceLibrary" at the start position in cs file where you will use the methods of this library. You can write "using Helper = AssistanceLibrary".
- If you write ```using Helper = AssistanceLibrary"```, do this, for exemple : ```Helper.WriterAndReadFiles<user>.ReadJsonFile(parametrs)```, else you must write, for exemple :```WriterAndReadFiles<user>.ReadJsonFile(parametrs)```;


##
##

| Class  | methods |
| ------ | ------ |
| ArrayHelper | Append(T[], T) : T[] Append(T[], T[]) : T[] Append(T[], int, T) : T[]  TakeElement(T[], int, int) : T[]  TakeElement(T[], params int[]) : T[] |
| DictionaryHelper | CreateDictionary(K[], V[]) : Dictionary(K[], V[]) AddToDictionary(Dictionary<K, V>,K[], V[]) : Dictionary(K[], V[]) AddToDictionary(Dictionary<K, V>, Dictionary<K,V>) |
| ListHelper | TakeElement(List<T>, params int[]) : List<T> TakeElement(List<T>,int, int) : List<T> Append(List<T>, int, T) : List<T>|
| WriterAndReadFiles | 4.1 ReadTextFile(string) : string  ReadTextFile(string) : List<T> WriteToTextFile(string, bool, T[]) : void WriteToTextFile(string, bool, T) : void  WriteToTextFile(string, bool, T[,]) : void WriteToTextFile(string, bool, List<T>) : void CreateJsonFile(string, List<T>) : void CreateJsonFile(string, T[]) : void CreateJsonFile(string, T) : void |
| SortingMethods: | BubbleSort(T[]) : T[] HoareSort(T[], int, int) |

## Good luck!
