﻿using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository(); //declared a field (_repo is naming convention)

        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content by Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower()) //to lower brings all letter lowercase to match
                {
                    case "1":
                    case "one":
                    case "banana":  //just showing it can be anything
                        CreateNewContent();  //calling methods that are created below
                        break;
                    case "2":
                    case "two":
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        Console.ReadLine();
                        break;
                }

                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewContent() //challenge - ask the user to confrim information before adding to directory
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

                //newContent.StarRating = Convert.ToDouble(Console.Readline()); this line does the same thing as the 3 lines above

            //Genre
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. Romantic Comedy\n" +
                "3. Science Fiction\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //newContent.TypeOfGenre = (GenreType)(Convert.ToInt32(Console.ReadLine())) same as above 3 lines combined

            //MaturityRatings
            Console.WriteLine("Enter the maturity rating number for this content\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            newContent.MaturityRating = (MaturityRating)(Convert.ToInt32(Console.ReadLine())); //the (MaturityRating) is the cast
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly!");
            }
            else
            {
                Console.WriteLine("Could not add the content.");
            }
        }

        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent)
            {
                Console.ForegroundColor = (ConsoleColor.Green);
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friend: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() //get a title from the user then display all properties of the content with that title
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("What is the title of the movie?");
            StreamingContent content = _repo.GetContentByTitle(Console.ReadLine()); //avoid writing method multiple times

            if(content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Star Rating: {content.StarRating}\n" +
                    $"Genre: {content.TypeOfGenre}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
            }
            else
            {
                Console.WriteLine("There is no content by that title.");
            }
        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("What is the title of the content would you like to update?");

            string oldTitle = Console.ReadLine();

            //copied from create new object
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the new title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the new description of the content");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the new Star Rating for this content (0.0 - 5.0");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.Readline()); this line does the same thing as the 3 lines above

            //Genre
            Console.WriteLine("Enter the new genre number for this content:\n" +
                "1. Horror\n" +
                "2. Romantic Comedy\n" +
                "3. Science Fiction\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //newContent.TypeOfGenre = (GenreType)(Convert.ToInt32(Console.ReadLine())) same as above 3 lines combined

            //MaturityRatings
            Console.WriteLine("Enter the new maturity rating number for this content\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            newContent.MaturityRating = (MaturityRating)(Convert.ToInt32(Console.ReadLine())); //the (MaturityRating) is the cast

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfully");
            }
            else
            {
                Console.WriteLine("No content by that title exists");
            }
        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.Write("Enter the title for the content you want to delete.");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted)
            {
                Console.WriteLine("Your content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Content could not be deleted.");
            }
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets accidentally transported back in time 30 years", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar saves the day", 2.5, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "A car tire comes to life and goes on a killing spree", 1.5, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);
        }
    }
}