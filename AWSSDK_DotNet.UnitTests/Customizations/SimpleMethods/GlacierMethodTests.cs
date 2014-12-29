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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Glacier.Model;
using Amazon.Glacier;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class GlacierMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("Glacier")]
        public void GlacierSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "AbortMultipartUpload", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "CompleteMultipartUpload", new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "CreateVault", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "DeleteArchive", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "DeleteVault", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "DeleteVaultNotifications", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "GetJobOutput", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "InitiateJob", new Type[] { typeof(string), typeof(string), typeof(JobParameters), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "InitiateMultipartUpload", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "InitiateMultipartUpload", new Type[] { typeof(string), typeof(string), typeof(string), typeof(long), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "ListJobs", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "ListMultipartUploads", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "ListParts", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "ListVaults", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "SetVaultNotifications", new Type[] { typeof(string), typeof(string), typeof(VaultNotificationConfig), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "UploadArchive", new Type[] { typeof(string), typeof(string), typeof(string), typeof(Stream), });
            EnsureSimpleMethodExists(typeof(Amazon.Glacier.AmazonGlacierClient), "UploadMultipartPart", new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(Stream), typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}