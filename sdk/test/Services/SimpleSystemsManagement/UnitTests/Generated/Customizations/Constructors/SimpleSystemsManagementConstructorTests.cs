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
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class SimpleSystemsManagementConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void CancelCommandRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.CancelCommandRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.CancelCommandRequest), new System.Type[] { typeof(string), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void CreateAssociationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.CreateAssociationRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void CreateAssociationBatchRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.CreateAssociationBatchRequest), new System.Type[] { typeof(List<CreateAssociationBatchRequestEntry>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void CreateDocumentRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.CreateDocumentRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void DeleteAssociationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.DeleteAssociationRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void DeleteDocumentRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.DeleteDocumentRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void DescribeAssociationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.DescribeAssociationRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void DescribeDocumentRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.DescribeDocumentRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void GetDocumentRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.GetDocumentRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void ListAssociationsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.ListAssociationsRequest), new System.Type[] { typeof(List<AssociationFilter>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void ListCommandInvocationsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.ListCommandInvocationsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void ListCommandsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.ListCommandsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void ListDocumentsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.ListDocumentsRequest), new System.Type[] { typeof(List<DocumentFilter>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void SendCommandRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.SendCommandRequest), new System.Type[] { typeof(string), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleSystemsManagement")]
        public void UpdateAssociationStatusRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleSystemsManagement.Model.UpdateAssociationStatusRequest), new System.Type[] { typeof(AssociationStatus), typeof(string), typeof(string), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}