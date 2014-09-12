using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2.Model;

namespace AWSSDK_DotNet35.UnitTests.EC2
{
    [TestClass]
    public class PasswordTest
    {

        // Test an issue with certain combination of private key and encrypted passwords that were causing a encoding issue while decrypting the password.
        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestMissingLeadingZeroIssue()
        {
            string encryptedPassword = "Oxaop1Qz5TWS3U4J82qZSVX9WHrA7zaheUugP/Fsa2iq/9XjEPzAWRcnYCZ4icBeS/az/adyOb3b5nLYVMcr2yFANnEYNPWTtypISbuXfrBdqalG6+E45T/yu+Ti3iJo3zaMXvtcR3qQwQ2bFdt8Xo7W9wXwwTjisQbUKe7dHMfjYa/c6knEz+nVj4qyOG5QaLGhkbH7XBnekd/xpatuH4wtgfdvcOlYWeBnxWCmFigaKdhkEXmZavIU05sV5CIvsgiW79LorLpeat3i+pyrJ/x7349f6SyFSS2uOnbDei1nr1JiO4erkJjN6py6RxSsKmNzBCUo8q0+EXTVg5g6SA==";
            string privateKey = "-----BEGIN RSA PRIVATE KEY-----\nMIIEpAIBAAKCAQEAmOMJ9AIxkXBhPK+0dU0CfgqP+uMUnwPa8TwnY9+pl49s2+BGrGVIl+qccYl+\nZ0mu7MDd0MZsQBH2ZNDl+7464sqpA5PlWkl4a3/Mgc/OC00kU2o4aslLGoHUgFfIRtiA40bXEif8\nnHWQR4AWJCGS3w1oLlW4qvUwDzvLZ5dJ6n/erThZAFJa1XEPZgh3vjdLQEkxb1pkgo831niNPC5B\nZYVpr+MfBFgdVt4LdY3B7o6jkA1h7QxeZp9Au84Ag7nE3RELU7ll4U3Z9WK+8NZ+5/mJQ5LrSN47\n2KRR3Z+KBM2GYLo4U1LutL/ajUbZe1IJeTgdZMb1DMvyLu2283uiOwIDAQABAoIBAQCFzn9RjfHw\nBlk0Edtwplu+EGR/Aet0WJ1wcGNRJ9l4ClEOBzYTf/mO7AjL3bhBkd2E3C/Gn0LyuEXbanE+aPmE\nsDZIKVKcOJ0qCInmOwdsILHgR6Dk5RPUOTjQswNX7fiv8bod691M2h/SVCoMqU2v5j39/4xGI51S\nV9Tn7yMEFk5/Lmu9NNAtIrFF5ywsVbT5so6MbGqBRI8KNX71/T9KTJjXxGR9RnrKRv9zrygDw1yB\nNaJW2/HiOfbcACvehqlwBEyRRMNKZ8t+GnwnSbq30V4ojj7DlJ1piM2+11NUpIbXI1chR2iFRvyp\nP2QMp2YDlqvw5pKo8v53YYRJ5CCxAoGBAPg6lN8C39aBPJHgKgH7VtkV1QQudjHWFPRkXeixuKYi\nOZrdqrEKHt69T2aXcazqaJNNMfT3QxLtg8afe3c4Kz7TuIZI5EtKi0Ny6Wx2QhKa/Lq0YAjoAdQO\nlONf3p0eW4367fezegvZeNazKl0M4RAcW1qje5iqU42bSrPrGgq3AoGBAJ2sV/bM7g+ZRgmsbdOS\nJeoKf9n0+iA9/arhnn0/ygkYYOegQP9vOfefafLmKuImRu3mo1D7iuVhk/p7Mkkse0mQ68aZg88H\n3JBuZgf2WokN/lw0JdP40VUPobGZ9xS/a233+cRUn0Idrtslh7aIeR7yhzHIjuQYP7aAX6nnxXCd\nAoGBAOpSGoAebYBGxQ+LRPxT71rDgi8NUOOgjG1bZU6onX6uZiRrxZqTzCpFGHPm2Bb7vDX4tATj\neHygmzlfCSS0cBZBtDmHC4KLXsUP74tEYwC/L31rkhA2OqucDC5LLJCyvIhdbE/cK4SOCMTbokzu\nQHJ94jrAgobNmkvdYPpQH2gnAoGAR5MSo1BHyQD1EDMb7+zqFSILA6/3U2eQnV+qCIVKe3J7mune\nV5XwJH5TJBZj5SEnFZubC4oEdTgkapI+M4VjufN1dEP/151j/JSA8KBeXNTjYIuzmFPdAtYDupF/\n3gU/CT6GPR+E5AiBda3Fu5CcGvZRdMHsS5LOaVRBGOnDcOkCgYAA06F5y5/pdOFGrCGEoF4KOn43\nXbOG4I4WvjYP5u+CHhu4ipKvLT1TzbugO7fV8ilVU1R7R9Ur7MTCiSc7tO8QMkZbBGvUu3LAe3Hb\nAWdLBliOrgOyAjFWervBecbP9h4gn8fOALcQJqnqg2BRRhbN/lTGPsZpaLwRkS4MuQLGnw==\n-----END RSA PRIVATE KEY-----";

            GetPasswordDataResponse response = new GetPasswordDataResponse { PasswordData = encryptedPassword };
            string decryptedPassword = response.GetDecryptedPassword(privateKey);
            Assert.IsNotNull(decryptedPassword);
        }
    }
}
