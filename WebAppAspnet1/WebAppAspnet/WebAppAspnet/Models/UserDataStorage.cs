using System.Collections.Generic;

namespace WebAppAspnet.Models
{
    public class UserDataStore
    {
        public static UserDataStore Instance = new UserDataStore();
        private List<UserModel> userList = new List<UserModel>();
        public UserDataStore()
        {
            this.userList.Add(new UserModel { idAd = 1, adTitle = "Строительство", adConfirm = "да", adDatePublic = "01.01.2015", adText ="текст", idRubric = 5 });
            this.userList.Add(new UserModel { idAd = 2, adTitle = "Транспорт", adConfirm = "нет", adDatePublic = "02.02.2016", adText = "текст", idRubric = 6 });
        }

        public List<UserModel> GetAllUsers()
        {
            return this.userList;
        }

        //возвращает информацию о пользователе по его id
        public UserModel GetUserByUserId(int userId)
        {
            return this.userList.Find(x => x.idAd == userId);
        }
    }
}