using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAspnet.Models
{
    public class UserDataStore
    {
        public static UserDataStore Instance = new UserDataStore();
        private List<UserModel> userList = new List<UserModel>();
        public UserDataStore()
        {
            this.userList.Add(new UserModel { UserId = 1, UserName = "опа1", FirstName = "Юрий", LastName = "Жигалов" });
        }

        public List<UserModel> GetAllUsers()
        {
            return this.userList;
        }

        public UserModel GetUserByUserId(int userId)
        {
            return this.userList.Find(x => x.UserId == userId);
        }

        public IEnumerable<Table_Company> GetInfo()
        {
            // Создать объект контекста
             context = new MyShop1Entities();

            return context.CustomerSet.AsQueryable();
        }
    }
}