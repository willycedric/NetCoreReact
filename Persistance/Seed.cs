using System;
using System.Collections.Generic;
using Domain;
using System.Linq;

namespace Persistance
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            //Seeding the Activity table
            if(!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Past Activity 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Activity 2 months ago",
                        Category = "drinks",
                        City = "London",
                        Venue = "Pub",
                    },
                    new Activity
                    {
                        Title = "Past Activity 2",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "Activity 1 month ago",
                        Category = "culture",
                        City = "Paris",
                        Venue = "Louvre",
                    },
                    new Activity
                    {
                        Title = "Future Activity 1",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Activity 1 month in future",
                        Category = "culture",
                        City = "London",
                        Venue = "Natural History Museum",
                    },
                    new Activity
                    {
                        Title = "Future Activity 2",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Activity 2 months in future",
                        Category = "music",
                        City = "London",
                        Venue = "O2 Arena",
                    },
                    new Activity
                    {
                        Title = "Future Activity 3",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "Activity 3 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Another pub",
                    },
                    new Activity
                    {
                        Title = "Future Activity 4",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "Activity 4 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Yet another pub",
                    },
                    new Activity
                    {
                        Title = "Future Activity 5",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "Activity 5 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Just another pub",
                    },
                    new Activity
                    {
                        Title = "Future Activity 6",
                        Date = DateTime.Now.AddMonths(6),
                        Description = "Activity 6 months in future",
                        Category = "music",
                        City = "London",
                        Venue = "Roundhouse Camden",
                    },
                    new Activity
                    {
                        Title = "Future Activity 7",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "Activity 2 months ago",
                        Category = "travel",
                        City = "London",
                        Venue = "Somewhere on the Thames",
                    },
                    new Activity
                    {
                        Title = "Future Activity 8",
                        Date = DateTime.Now.AddMonths(8),
                        Description = "Activity 8 months in future",
                        Category = "film",
                        City = "London",
                        Venue = "Cinema",
                    }
                };

                context.Activities.AddRange(activities);
                context.SaveChanges();
            }

            //Seeding the Post table
            if(!context.Posts.Any()){

                    var posts = new List<Post>()
                    {
                        new Post {
                            Author = "Martin Dupuis",
                            Tilte = "Resolve issues with github"
                        }, 
                        new Post{
                            Author = "Panisilva Djarta",
                            Tilte = "StackOverflow overflow"
                        },
                        new Post {
                            Author = "Mad coder",
                            Tilte = "have a balance diet event when we are inspired"
                        },
                        new Post{
                            Author = "Pricilia Janet",
                            Tilte = "Empowering woman in tech"
                        },
                        new Post{
                            Author = "Jean Mukuam",
                            Tilte = "How software could help a country to develop his economu"
                        },
                        new Post{
                            Author = "Pascral Monji",
                            Tilte = "What if the Wakanda really exist"
                        },
                        new Post{
                            Author = "Lorine Pattyet",
                            Tilte = "How to manage long distance relation ship and entrepreneurship"
                        }
                    };
                    context.Posts.AddRange(posts);
                    context.SaveChanges();
            }
        }
    }
}