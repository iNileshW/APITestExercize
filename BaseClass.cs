﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercizeAPITest.DataEntities
{
    public class BaseClass
    {
        public readonly string baseURL = "https://jsonplaceholder.typicode.com/";
        public readonly string postsEndPoint = "/posts/";
        public readonly string commentsPostsEndPoint = "/comments";
        public readonly string commentsEndPoint = "/comments/";
        public readonly string albumsEndPoint = "/albums/";
        public readonly string photosEndPoint = "/photos/";
        public readonly string usersEndPoint = "/users/";
        public readonly string todosEndPoint = "/todos/";
        public readonly int firstId = 1;
        public readonly int lastId = 100;
        public readonly string contentType = "application/json; charset=utf-8";
    }
}
