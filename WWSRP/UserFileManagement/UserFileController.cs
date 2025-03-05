
using WWSRP.UserManagement;

namespace WWSRP.FileManagement
{
    public class UserFileController
    {

        private readonly List<User> _users;

        public UserFileController(List<User> users)
        {
            _users = users;
        }

        // CHANGED
        public void SaveDataToFile(string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (var user in _users)
                    {
                        writer.WriteLine($"{user.Name},{user.Password}");
                    }
                }
                Console.WriteLine($"User data saved to {fileName}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data to file: {ex.Message}");
            }
        }

        // CHANGED
        public void LoadDataFromFile(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        if (parts.Length >= 2)
                        {
                            string username = parts[0];
                            string password = parts[1];

                            User user = new User
                            {
                                Name = username,
                                Password = password
                            };

                            _users.Add(user);

                        }

                    }
                }
                Console.WriteLine($"User data loaded from {fileName}.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {fileName} not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data from file: {ex.Message}");
            }
        }

        // CHANGED
        public void BackupData(string backupFileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(backupFileName))
                {
                    foreach (var user in _users)
                    {
                        writer.WriteLine($"{user.Name},{user.Password}");
                    }
                }
                Console.WriteLine($"User data saved to {backupFileName}.");

                Console.WriteLine($"User data backed up to {backupFileName}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error backing up data: {ex.Message}");
            }
        }

        // CHANGED
        public void DeleteDataFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                    Console.WriteLine($"File {fileName} deleted.");
                }
                else
                {
                    Console.WriteLine($"File {fileName} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting file: {ex.Message}");
            }
        }
    }
}
