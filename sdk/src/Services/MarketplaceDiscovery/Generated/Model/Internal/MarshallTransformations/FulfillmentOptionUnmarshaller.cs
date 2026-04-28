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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceDiscovery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceDiscovery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FulfillmentOption Object
    /// </summary>  
    public class FulfillmentOptionUnmarshaller : IJsonUnmarshaller<FulfillmentOption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FulfillmentOption Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FulfillmentOption unmarshalledObject = new FulfillmentOption();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("amazonMachineImageFulfillmentOption", targetDepth))
                {
                    var unmarshaller = AmazonMachineImageFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.AmazonMachineImageFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("apiFulfillmentOption", targetDepth))
                {
                    var unmarshaller = ApiFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.ApiFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cloudFormationFulfillmentOption", targetDepth))
                {
                    var unmarshaller = CloudFormationFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.CloudFormationFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("containerFulfillmentOption", targetDepth))
                {
                    var unmarshaller = ContainerFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.ContainerFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataExchangeFulfillmentOption", targetDepth))
                {
                    var unmarshaller = DataExchangeFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.DataExchangeFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2ImageBuilderComponentFulfillmentOption", targetDepth))
                {
                    var unmarshaller = Ec2ImageBuilderComponentFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.Ec2ImageBuilderComponentFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eksAddOnFulfillmentOption", targetDepth))
                {
                    var unmarshaller = EksAddOnFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.EksAddOnFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("helmFulfillmentOption", targetDepth))
                {
                    var unmarshaller = HelmFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.HelmFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("professionalServicesFulfillmentOption", targetDepth))
                {
                    var unmarshaller = ProfessionalServicesFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.ProfessionalServicesFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("saasFulfillmentOption", targetDepth))
                {
                    var unmarshaller = SaasFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.SaasFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sageMakerAlgorithmFulfillmentOption", targetDepth))
                {
                    var unmarshaller = SageMakerAlgorithmFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.SageMakerAlgorithmFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sageMakerModelFulfillmentOption", targetDepth))
                {
                    var unmarshaller = SageMakerModelFulfillmentOptionUnmarshaller.Instance;
                    unmarshalledObject.SageMakerModelFulfillmentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FulfillmentOptionUnmarshaller _instance = new FulfillmentOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FulfillmentOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}