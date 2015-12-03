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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.SimpleSystemsManagement;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class SimpleSystemsManagementMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("SimpleSystemsManagement")]
        public void SimpleSystemsManagementSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "CancelCommand", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "CancelCommand", new Type[] { typeof(string), typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "CreateAssociation", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "CreateDocument", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "DeleteAssociation", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "DeleteDocument", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "DescribeAssociation", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "DescribeDocument", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "GetDocument", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "ListCommandInvocations", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "ListCommands", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleSystemsManagement.AmazonSimpleSystemsManagementClient), "SendCommand", new Type[] { typeof(string), typeof(List<string>), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}