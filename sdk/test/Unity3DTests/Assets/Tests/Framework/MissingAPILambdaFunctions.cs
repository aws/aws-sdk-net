using Amazon.IdentityManagement;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Threading;
using Amazon;
using NUnit.Framework;

namespace AWSSDK.Tests.Framework
{
    class MissingAPILambdaFunctions
    {
        private static readonly string RoleName = "unity-test-utilities-role";
        private static readonly string RolePolicyName = "unity-test-utils-role-policy";
        //TODO: constrict policy
        private static readonly string RolePolicyDocument =
@"
{
    ""Version"": ""2012-10-17"",
    ""Statement"": [
        {
            ""Effect"": ""Allow"",
            ""Action"": [
                ""s3:CreateBucket"",
                ""s3:DeleteBucket"",
                ""s3:PutBucketVersioning"",
                ""lambda:DeleteFunction""
            ],
            ""Resource"": ""*""
        }
    ]
}
".Trim();

        private static readonly string CreateBucketFunctionName = "UnityTestUtilsCreateBucket";
        private static readonly string DeleteBucketFunctionName = "UnityTestUtilsDeleteBucket";
        private static readonly string DeleteLambdaFunctionFunctionName = "UnityTestUtilsDeleteLambdaFunction";
        private static readonly string EnableBucketVersioningFunctionName = "UnityTestUtilsEnableBucketVersioning";
        // The third string in each array is a Base64 representation of the Zip file of
        // the Lambda function's code. See the comments for
        // UtilityMethods.CreateFunctionIfNotExists for more information.
        private static List<string[]> FunctionNames = new List<string[]>
        {
            new string[] {
                "UnityTestUtilsCreateBucket",
                "unitytestutils-createbucket",
                "UEsDBBQAAAAIABOJbEfv4JefyAEAAE8EAAAeAAAAdW5pdHl0ZXN0dXRpbHMtY3JlYXRlYnVja2V0LmpznVNNj9MwEL33V5iTXSmJslvEodVyYAWn5UOs4MJysJxJam3WDv5Ii1D+O+O4SRzYA8KHSm/mzbznPLfnhvCTJTfEwA8vDTCKMLfVI90eNhuhldUtFK1uGL3TvJKqIdCDcqEN504bZ4sjV1ULBpfUXgkntWIjJyM47+DstuTXhuDpUe2NF4/gPvAnQP5IK5bSYaTJmrAXS3GaDueysKi5bBl9760jndG9rIA80GXkgQZ/YWCYhT9Dg85m0QgTwVj4Z7FIT4VmJbtDFQWn8GWL+x1bNvJOfgVjcXBP6HVZvsrLXV5e0WxmmOhyf7G7NKxsFHfewGUBUmj/Mpm0u3faCPjE3fHe/WwBCc54GEKOk7OOG/4U0la+bZe7f6Nvv9CMUPD5CazLrwLw9hlwHQDvcqu9OwKf2qvKxFH4OBKO5fkChIrtiFBXYCaGt4i/F1JVcP5YsymR1zekTHOZb7GUwonx75MXlq36twa4g9i91aqWjTfcjVmsF4Vzp8XYQ6JFY1K5KZIVdZjRcHkGBFoL/2P2r02bmGohEt8srsuSf5oxGam44+kXCqFiY/uH6OpBh/5hEQ0/Mwp3eH7UeiEAKpaORrtYGX4DUEsBAhQAFAAAAAgAE4lsR+/gl5/IAQAATwQAAB4AAAAAAAAAAAAAAAAAAAAAAHVuaXR5dGVzdHV0aWxzLWNyZWF0ZWJ1Y2tldC5qc1BLBQYAAAAAAQABAEwAAAAEAgAAAAA="
            },
            new string[] {
                "UnityTestUtilsDeleteBucket",
                "unitytestutils-deletebucket",
                "UEsDBBQAAAAIAG6CbEfG9lQIUAEAAOwCAAAeAAAAdW5pdHl0ZXN0dXRpbHMtZGVsZXRlYnVja2V0LmpzjVE7a8MwEN4D+Q/qJAUc49alQ0yXDp3aUhrolEVYF0fEkVw9nJTi/17JMpZNKFSDQHff4+5TSxWiZ40ekYIvyxUQ7J5rzY54VSwXy0UphZY1pLWsCH6RlHFRIWhBmB4Al0Yqo9MDFawG5XT2VpSGS0F6UIKcgIGLWaGf5QK50zrHJ1sewbzREzhCj0tjqQg4vkfkJlZHvj+DZrqnvCb41WqDGiVbzgDtcOTscD+jZ3TR/AMqN95oHJ5T01D5v2HAz82iXUMVPfmAJ3JhxM0kh4FYTJk6dywBZ/9B6TYnEwHa8E9Q2tluEL7Lsod1lq+zW5xEiAprboZ9k7GheSWosQoGBQfB7T2eAPJnqUp4p+awNd81OIBRFrrVOJ3OUwY1GAgLkLBjMvl7pRLEqKGzFH26rjOrXaXrAUXsd/6KT6g1/MHWtiwBGJmxh1x9rfsFUEsBAhQAFAAAAAgAboJsR8b2VAhQAQAA7AIAAB4AAAAAAAAAAAAAAAAAAAAAAHVuaXR5dGVzdHV0aWxzLWRlbGV0ZWJ1Y2tldC5qc1BLBQYAAAAAAQABAEwAAACMAQAAAAA="
            },
            new string[] {
                "UnityTestUtilsDeleteLambdaFunction",
                "unitytestutils-deletelambdafunction",
                "UEsDBBQAAAAIAG6CbEff3UROLQEAALwCAAAmAAAAdW5pdHl0ZXN0dXRpbHMtZGVsZXRlbGFtYmRhZnVuY3Rpb24uanONUb1uwyAQ3vMUdIJItpU06hKra6e0Q4dOWa7mnKJicAE7kSq/e8EkBCkZyoDE3ffH3QiGwNGSZ2LwZxAGGfXP0vJvuqwXi0YrqyVWUh8Y3WngQh0IjqhcaOOp18bZ6gsUl2i8SDuoxgmt2IwpiOc7PLkl+V0Qf0bvtoPuk8PLGfgGHXreDK/yYj0TREvYwy3johfO2aJqQUhGXwfrSG/0KDiSPc1JexoyB8qUwrzjwXdTgPjMrGPh33YRnhslpx4MdGHOV6k83PbOXKJEnSTkjPASCo9haVWksKsi9OIDjfX8LaGPq/VTudqUmzUtEsLED2/PP5/CkkM9alccJTq8hGAxdJGt1ZiCcHCQjyRMyjfy0s2kQr9O7Slc6YXS4n2qHZoGkbOcGqfiK9MfUEsBAhQAFAAAAAgAboJsR9/dRE4tAQAAvAIAACYAAAAAAAAAAAAAAAAAAAAAAHVuaXR5dGVzdHV0aWxzLWRlbGV0ZWxhbWJkYWZ1bmN0aW9uLmpzUEsFBgAAAAABAAEAVAAAAHEBAAAAAA=="
            },
            new string[] {
                "UnityTestUtilsEnableBucketVersioning",
                "unitytestutils-enablebucketversioning",
                "UEsDBBQAAAAIABJyMkiPCi6JfAEAAEkDAAAoAAAAdW5pdHl0ZXN0dXRpbHMtZW5hYmxlYnVja2V0dmVyc2lvbmluZy5qc42SP0/DMBDF93wKMzmV2qgQxNCKASidKEJUYupikmtq1bWD/6RFqN+dc9zGATFwm3337v3il4ZpwvaG3BINH45rSCkeR6bc0sE0SQoljRKQCVWl9EmxksuKQAPS+jYcaqWtyTZMlgI0Llk7WViuZNrODAnqLRzsgHwlBKtBt3tXbME+sx3gfDuWxatpO8bXJL2Il2e1r9PCbM24SOnCGUtqrRpeAlnRKFlRz+cFx874FSok60zDsWcYLv5tFsb7Rp2TydFFwt6/bLbM07iR1fwNtEHhhNCr8fhmNM5H40s67CZ0oJyccGPD8Eoy6zScFuAIba57SpPPlS7ghdnN0n4KwAGrHRx9jmeymmm282lHpPBok14uceXJCkN/UHLNK6eZbdmj3NdifjcDARYQacYNexdQ9sB8LS2yG+w/ytDuuiGgY3jEJHxIVjsbeCJBGtiHvX9M6yEpmWX9zHyU2Bj8QvwRpe9PI0Bn7AuEgb+lxhUFQJn2pYEdb47fUEsBAhQAFAAAAAgAEnIySI8KLol8AQAASQMAACgAAAAAAAAAAAAAAAAAAAAAAHVuaXR5dGVzdHV0aWxzLWVuYWJsZWJ1Y2tldHZlcnNpb25pbmcuanNQSwUGAAAAAAEAAQBWAAAAwgEAAAAA"
            },
        };


        private static AmazonLambdaClient LambdaClient;
        private static IAmazonIdentityManagementService IAMClient;
        private static string RoleArn;

        public static void Initialize()
        {
            LambdaClient = new AmazonLambdaClient(TestRunner.Credentials, TestRunner.RegionEndpoint);
            IAMClient = new AmazonIdentityManagementServiceClient(TestRunner.Credentials, TestRunner.RegionEndpoint);

            RoleArn = UtilityMethods.CreateRoleIfNotExists(IAMClient, RoleName, UtilityMethods.LambdaAssumeRolePolicyDocument);
            UtilityMethods.CreatePolicyIfNotExists(IAMClient, RolePolicyName, RolePolicyDocument, RoleName);

            foreach (string[] functionInfo in FunctionNames)
            {
                CreateFunction(functionInfo[0], functionInfo[1], functionInfo[2]);
            }
        }

        private static void CreateFunction(string name, string handlerName, string code)
        {
            UtilityMethods.CreateFunctionIfNotExists(LambdaClient, name, handlerName, code, RoleArn);
        }

        public static void CreateBucket(string bucketName, RegionEndpoint region, bool waitForSuccess = true)
        {
            DateTime timeout = DateTime.Now + TimeSpan.FromMinutes(10);
            AutoResetEvent ars = new AutoResetEvent(false);
            string functionError = null;
            Exception responseException = new Exception();
            while (DateTime.Now < timeout)
            {
                string payload = string.Format(@"{{""BucketName"":""{0}"",""Region"":""{1}""}}", bucketName, region.SystemName);
                LambdaClient.InvokeAsync(new InvokeRequest()
                {
                    FunctionName = CreateBucketFunctionName,
                    InvocationType = InvocationType.RequestResponse,
                    Payload = payload
                }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        functionError = response.Response.FunctionError;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                if (responseException != null)
                {
                    throw responseException;
                }
                if (string.IsNullOrEmpty(functionError))
                {
                    break;
                }
                Thread.Sleep(TimeSpan.FromSeconds(30));
            }
            Utils.AssertStringIsNullOrEmpty(functionError);
        }

        public static void EnableBucketVersioning(string bucketName, RegionEndpoint region)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            string functionError = null;
            Exception responseException = new Exception();
            string payload = string.Format(@"{{""BucketName"":""{0}"",""Region"":""{1}""}}", bucketName, region.SystemName);
            LambdaClient.InvokeAsync(new InvokeRequest()
            {
                FunctionName = EnableBucketVersioningFunctionName,
                InvocationType = InvocationType.RequestResponse,
                Payload = payload
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    functionError = response.Response.FunctionError;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            if (responseException != null)
            {
                throw responseException;
            }
            Utils.AssertStringIsNullOrEmpty(functionError);
        }

        public static void DeleteBucket(string bucketName, RegionEndpoint region)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string functionError = null;
            string payload = string.Format(@"{{""BucketName"":""{0}"",""Region"":""{1}""}}", bucketName, region.SystemName);
            LambdaClient.InvokeAsync(new InvokeRequest()
            {
                FunctionName = DeleteBucketFunctionName,
                InvocationType = InvocationType.RequestResponse,
                Payload = payload
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    functionError = response.Response.FunctionError;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            if (responseException != null)
            {
                throw responseException;
            }
            Utils.AssertStringIsNullOrEmpty(functionError);
        }

        public static void DeleteLambdaFunction(string functionName, RegionEndpoint region)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string functionError = null;
            string payload = string.Format(@"{{""FunctionName"":""{0}"",""Region"":""{1}""}}", functionName, region.SystemName);
            LambdaClient.InvokeAsync(new InvokeRequest()
            {
                FunctionName = DeleteLambdaFunctionFunctionName,
                InvocationType = InvocationType.RequestResponse,
                Payload = payload
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    functionError = response.Response.FunctionError;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            if (responseException != null)
            {
                throw responseException;
            }
            Utils.AssertStringIsNullOrEmpty(functionError);
        }
    }
}
