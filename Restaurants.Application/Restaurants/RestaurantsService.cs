using AutoMapper;
using Microsoft.Extensions.Logging;
using Restaurants.Application.Restaurants.Dtos;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Restaurants
{
    public class RestaurantsService(
        IRestaurantsRepository restaurantsRepository,
        ILogger<RestaurantsService> logger,
        IMapper mapper) : IRestaurantsService
    {
        public async Task<IEnumerable<RestaurantDto>> GetAllRestaurantsAsync()
        {
            logger.LogInformation("Getting all restaurants");

            var restaurants = await restaurantsRepository.GetAllAsync();
            var restaurantsDtos = mapper.Map<IEnumerable<RestaurantDto>>(restaurants);

            return restaurantsDtos!;
        }

        public async Task<RestaurantDto?> GetByIdAsync(int id)
        {
            logger.LogInformation($"Getting restaurant {id}");

            var restaurant = await restaurantsRepository.GetByIdAsync(id);
            var restaurantDto = mapper.Map<RestaurantDto?>(restaurant);

            return restaurantDto;
        }

        public async Task<int> CreateAsync(CreateRestaurantDto dto)
        {
            logger.LogInformation("Creating a new restaurant");

            var restaurant = mapper.Map<Restaurant>(dto);

            int id = await restaurantsRepository.CreateAsync(restaurant);
            return id;
        }
    }
}
