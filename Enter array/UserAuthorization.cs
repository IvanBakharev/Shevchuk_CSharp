namespace Enter_array;

public class UserAuthorization
{

    string[] loginList = { "Admin", "Ivanova", "Petrova", "Sergeeva", "Semenova", "Vasileva" };
    string[] passwordList = { "000", "111", "222", "333", "444", "555", "666" };
    public bool TryAuthorizeUser(string login, string password)
    {

        for (int i = 0; i < loginList.Length && i < passwordList.Length; i++)
        {
            bool loginMatched, passwordMatched; // Сопоставить логин и пароль

            string loginByCurrentIndex = loginList[i];
            loginMatched = loginByCurrentIndex == login;
            string passwordByCurrentIndex = passwordList[i];
            passwordMatched = passwordByCurrentIndex == password;

            if (loginMatched && passwordMatched)
            {
                return true;
            }
            return false;
        }
        return false;
    }

}
