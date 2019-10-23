# Movie List continued
For this class, the students should continue building up the Movie List application from the previous lesson.

## Warm Up
Review WPF concepts to warm up (possibly a Kahoot or game)

## Practice
Students should continue following the instructions from Week3: [MovieListInstructions.md](../Week03/MovieListInstructions.md)

Additionally, students can work on MovieListExercises.md

## Challenges
If the students complete the Movie List, they can start to work on the Challenges from Week3: [MovieListChallengesBasic.md](../Week03/MovieListChallengesBasic.md).



<br>
<br>
<br>

## Review MovieList
Give the students access to the basic [MovieList.sln](../Week03/CompletedSolution/MovieApplication.sln) from the previous lesson. They should have built something similar in the previous lesson, but they should all get a chance to start fresh if they so choose.

Use the existing solution to review class concepts and WPF concepts.

## FollowAlong: Build to MovieListExercises
Add in a ListView and show how it can reflect the collection of movies. Do this as a class so that the students have an idea of how it works. Additionally, add a double click event to the ListView so that each row will show details about the movie when clicked.

### Adding the List View
1. Change the `List` of Movies to an `ObservableCollection`
1. Change `Title` and `ReleaseYear` to properties (instead of regular fields)
1. Add the `ListView` to the XAML file, giving it a Name, Height, Margin
1. Add the `ListView.View` and `GridView` inside the `ListView`
1. Add `GridViewColumns` for each property on the Movie (Title and Release Year)
    - Explain that the `Binding` specifies which property from the object will appear in the given column
1. In the `MainWindow` constructor, set the `ItemsSource` for the `ListView` to be the observable collection of Movies

### Adding the Double Click
1. In the XAML, in the `ListView` tag, start typing "MouseDoubleClick" and generate the event handler
1. In the `.cs` file, fill out the MouseDoubleClick method.
    - Get the selected movie using `SelectedItem` and cast it as a `Movie`
    - If the `Movie` is not null, show the details for the movie