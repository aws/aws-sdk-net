/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class IdentityManagementServiceMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("IdentityManagementService")]
        public void IdentityManagementServiceSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "AddRoleToInstanceProfile", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "AddUserToGroup", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "CreateAccessKey", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "CreateGroup", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "CreateRole", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "CreateUser", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeactivateMFADevice", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteAccessKey", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteAccountAlias", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteAccountPasswordPolicy", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteGroup", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteGroupPolicy", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteInstanceProfile", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteLoginProfile", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteRole", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteRolePolicy", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteSAMLProvider", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteServerCertificate", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteSigningCertificate", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteUser", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteUserPolicy", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GenerateCredentialReport", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GetAccountPasswordPolicy", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GetAccountSummary", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GetCredentialReport", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GetGroup", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GetUser", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListAccessKeys", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListAccountAliases", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListGroupPolicies", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListGroups", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListGroupsForUser", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListInstanceProfiles", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListInstanceProfilesForRole", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListMFADevices", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListRolePolicies", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListRoles", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListSAMLProviders", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListServerCertificates", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListSigningCertificates", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListUserPolicies", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListUsers", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListVirtualMFADevices", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "PutGroupPolicy", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "PutRolePolicy", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "PutUserPolicy", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "RemoveRoleFromInstanceProfile", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "RemoveUserFromGroup", new Type[] { typeof(string), typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}