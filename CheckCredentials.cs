        static bool CheckCredentials(string username, string password)
        {
            bool result = false;
            
            object[] dataJson = [{
                username: 'test',
                  password: 'test123',
            }];

            for (int i = 0; i <= dataJson.Length; i++) {
                if (dataJson[i].username == username && dataJson[i].password == password) {
                    result = true; 
                }
            }
            return result;
