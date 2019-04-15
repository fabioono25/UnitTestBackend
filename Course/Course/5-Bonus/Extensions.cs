using System;
using System.Collections.Generic;
using System.Text;

namespace Course._5_Bonus
{
    /// <summary>
    /// 
    /// We have some extension classes here that have the functionality of transform an Model in Dto and vice-versa
    /// There are differences between the domain models and DTOs. In this example, the UserModel is closer to Entity Context (database context)
    /// related to return data. In the other hand, UserDto is closer to userInterface (API) to represent the data to be show to the user
    /// The extension methods must have unit tests related to these methods. Enjoy!
    /// </summary>
    public static class Extensions
    {
        #region ToDto
        public static UserDto ToDto(this UserModel user)
        {
            if (user == null)
                return null;

            var dto = new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Birth = user.Birth,
                Addresses = user.Addresses
            };

            return dto;
        }

        public static List<UserDto> ToDto(this List<UserModel> users)
        {
            var dtoList = users?.ConvertAll(v => v.ToDto());

            return dtoList;
        }
        #endregion

        #region ToModel
        public static UserModel ToModel(this UserModel user)
        {
            if (user == null)
                return null;

            var model = new UserModel
            {
                Id = user.Id,
                Name = user.Name,
                Birth = user.Birth,
                Addresses = user.Addresses
            };

            return model;
        }

        public static List<UserModel> ToModel(this List<UserModel> users)
        {
            var modelList = users?.ConvertAll(v => v.ToModel());

            return modelList;
        }
        #endregion
    }
}
