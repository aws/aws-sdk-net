/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3.Model;
using Amazon.S3;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    [TestClass]
    public class S3MethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("S3")]
        public void S3SimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "AbortMultipartUpload", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "CopyObject", new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "CopyObject", new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "CopyPart", new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(int?), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "CopyPart", new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(int?), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "DeleteBucket", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "DeleteBucketPolicy", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "DeleteBucketTagging", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "DeleteBucketWebsite", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "DeleteCORSConfiguration", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "DeleteLifecycleConfiguration", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "DeleteObject", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "DeleteObject", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetBucketAccelerateConfiguration", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetBucketLocation", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetBucketLogging", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetBucketNotification", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetBucketPolicy", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetBucketRequestPayment", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetBucketVersioning", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetBucketWebsite", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetCORSConfiguration", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetLifecycleConfiguration", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetObject", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetObject", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetObjectMetadata", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetObjectMetadata", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "GetObjectTorrent", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "InitiateMultipartUpload", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "ListMultipartUploads", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "ListMultipartUploads", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "ListObjects", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "ListObjects", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "ListParts", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "ListVersions", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "ListVersions", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "PutBucket", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "PutBucketPolicy", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "PutBucketPolicy", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "PutBucketRequestPayment", new Type[] { typeof(string), typeof(RequestPaymentConfiguration), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "PutBucketTagging", new Type[] { typeof(string), typeof(List<Tag>), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "PutBucketWebsite", new Type[] { typeof(string), typeof(WebsiteConfiguration), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "PutCORSConfiguration", new Type[] { typeof(string), typeof(CORSConfiguration), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "PutLifecycleConfiguration", new Type[] { typeof(string), typeof(LifecycleConfiguration), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "RestoreObject", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "RestoreObject", new Type[] { typeof(string), typeof(string), typeof(int?), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "RestoreObject", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.S3.AmazonS3Client), "RestoreObject", new Type[] { typeof(string), typeof(string), typeof(string), typeof(int?), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}