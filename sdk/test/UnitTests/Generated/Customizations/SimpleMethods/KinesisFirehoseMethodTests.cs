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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.KinesisFirehose.Model;
using Amazon.KinesisFirehose;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class KinesisFirehoseMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("KinesisFirehose")]
        public void KinesisFirehoseSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.KinesisFirehose.AmazonKinesisFirehoseClient), "DeleteDeliveryStream", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KinesisFirehose.AmazonKinesisFirehoseClient), "PutRecord", new Type[] { typeof(string), typeof(Record), });
            EnsureSimpleMethodExists(typeof(Amazon.KinesisFirehose.AmazonKinesisFirehoseClient), "PutRecordBatch", new Type[] { typeof(string), typeof(List<Record>), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}