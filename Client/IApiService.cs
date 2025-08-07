using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using youtube_etl_do_zero.Models;

namespace youtube_etl_do_zero.Client
{
    public interface IApiService
    {
        [Get("/albums")]
        Task<List<Albums>> GetAlbums();

        [Get("/comments")]
        Task<List<Comments>> GetComments();

        [Get("/photos")]
        Task<List<Photos>> GetPhotos();

        [Get("/posts")]
        Task<List<Posts>> GetPosts();

        [Get("/todos")]
        Task<List<Todos>> GetTodos();

        [Get("/users")]
        Task<List<Users>> GetUsers();

        [Get("/addresses")]
        Task<List<Address>> GetAddresses();
    }
}