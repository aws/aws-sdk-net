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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Route53Domains.Model;
using Amazon.Route53Domains;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class Route53DomainsMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("Route53Domains")]
        public void Route53DomainsSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.Route53Domains.AmazonRoute53DomainsClient), "DeleteTagsForDomain", new Type[] { typeof(string), typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.Route53Domains.AmazonRoute53DomainsClient), "ListTagsForDomain", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Route53Domains.AmazonRoute53DomainsClient), "UpdateTagsForDomain", new Type[] { typeof(string), typeof(List<Tag>), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}