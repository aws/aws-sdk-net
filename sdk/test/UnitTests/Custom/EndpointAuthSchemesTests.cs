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
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EndpointAuthSchemesTests
    {
        private static DefaultRequest NewRequest()
        {
            return new DefaultRequest(new GetObjectRequest(), "S3");
        }

        private static AuthScheme Scheme(string name)
        {
            return new AuthScheme(name, "s3", "us-east-1", null, null);
        }

        [TestMethod]
        public void DisableDoubleEncodingDistinguishesUnsetFromFalse()
        {
            Assert.IsNull(new AuthScheme("sigv4", null, null, null, null).DisableDoubleEncoding);
            Assert.AreEqual(false, new AuthScheme("sigv4", null, null, null, false).DisableDoubleEncoding);
            Assert.AreEqual(true, new AuthScheme("sigv4", null, null, null, true).DisableDoubleEncoding);
        }

        [TestMethod]
        public void UseS3ExpressSessionAuthReadsTypedSchemesWithoutAttributesBag()
        {
            var request = NewRequest();
            request.EndpointAuthSchemes = new List<AuthScheme> { Scheme("sigv4-s3express") };

            Assert.IsNull(request.EndpointAttributes);
            Assert.IsTrue(request.UseS3ExpressSessionAuth());
        }

        [TestMethod]
        public void UseS3ExpressSessionAuthTypedSchemesWithoutExpressReturnFalse()
        {
            var request = NewRequest();
            request.EndpointAuthSchemes = new List<AuthScheme> { Scheme("sigv4") };

            Assert.IsFalse(request.UseS3ExpressSessionAuth());
        }

        [TestMethod]
        public void UseS3ExpressSessionAuthFallsBackToAttributesBag()
        {
            var schema = new PropertyBag();
            schema["name"] = "sigv4-s3express";
            var attributes = new PropertyBag();
            attributes["authSchemes"] = new List<object> { schema };

            var request = NewRequest();
            request.EndpointAttributes = attributes;

            Assert.IsNull(request.EndpointAuthSchemes);
            Assert.IsTrue(request.UseS3ExpressSessionAuth());
        }

        [TestMethod]
        public void UseS3ExpressSessionAuthNoSchemesReturnsFalse()
        {
            Assert.IsFalse(NewRequest().UseS3ExpressSessionAuth());
        }
    }
}
