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

using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.QuickSight;
using Amazon.QuickSight.Model;
using Amazon.QuickSight.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;
using Amazon;
using AWSSDK.UnitTests;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{    
    public partial class QuickSightMarshallingTests
    {

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("QuickSight")]
        public void DeleteUserMarshallTest_RoleSlashUserName()
        {
            var operation = service_model.FindOperation("DeleteUser");

            var request = InstantiateClassGenerator.Execute<DeleteUserRequest>();            
            var marshaller = new DeleteUserRequestMarshaller();

            request.UserName = "role/name";
            var internalRequest = marshaller.Marshall(request);

            //The following / is encoded in "UserName" to %2F so that the Validate method properly 
            //compares request uriResourcePath built up from the request labels against 
            //internalRequest uriResource path that has been encoded by the marshaller.
            request.UserName = "role%2Fname";
            TestTools.RequestValidator.Validate("DeleteUser", request, internalRequest, service_model);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("QuickSight")]
        public void DescribeUserMarshallTest_RoleSlashUserName()
        {
            var operation = service_model.FindOperation("DescribeUser");

            var request = InstantiateClassGenerator.Execute<DescribeUserRequest>();            
            var marshaller = new DescribeUserRequestMarshaller();

            request.UserName = "role/name";
            var internalRequest = marshaller.Marshall(request);

            //The following / is encoded in "UserName" to %2F so that the Validate method properly 
            //compares request uriResourcePath built up from the request labels against 
            //internalRequest uriResource path that has been encoded by the marshaller.
            request.UserName = "role%2Fname";
            TestTools.RequestValidator.Validate("DescribeUser", request, internalRequest, service_model);            
        }
    }
}