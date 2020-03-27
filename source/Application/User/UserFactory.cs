using Architecture.Domain;
using Architecture.Model;

namespace Architecture.Application
{
    public static class UserFactory
    {
        public static User Create(AddUserModel model, Auth auth)
        {
            return new User
            (
                new FullName(model.FullName.Name, model.FullName.Surname),
                new Email(model.Email),
                auth
            );
        }
    }
}
