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
 * Do not modify this file. This file is generated from the mobileanalytics-2014-06-05.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.MobileAnalytics;
using Amazon.MobileAnalytics.Model;
using Amazon.MobileAnalytics.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class MobileAnalyticsMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("mobileanalytics-2014-06-05.normal.json", "mobileanalytics.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("MobileAnalytics")]
        public void PutEventsMarshallTest()
        {
            var operation = service_model.FindOperation("PutEvents");

            var request = InstantiateClassGenerator.Execute<PutEventsRequest>();
            var marshaller = new PutEventsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("PutEvents", request, internalRequest, service_model);            

        }

            }
}