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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProductionVariantCapacityReservationSummary Object
    /// </summary>  
    public class ProductionVariantCapacityReservationSummaryUnmarshaller : IUnmarshaller<ProductionVariantCapacityReservationSummary, XmlUnmarshallerContext>, IUnmarshaller<ProductionVariantCapacityReservationSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProductionVariantCapacityReservationSummary IUnmarshaller<ProductionVariantCapacityReservationSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ProductionVariantCapacityReservationSummary Unmarshall(JsonUnmarshallerContext context)
        {
            ProductionVariantCapacityReservationSummary unmarshalledObject = new ProductionVariantCapacityReservationSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AvailableInstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableInstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CapacityReservationPreference", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CapacityReservationPreference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2CapacityReservations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Ec2CapacityReservation, Ec2CapacityReservationUnmarshaller>(Ec2CapacityReservationUnmarshaller.Instance);
                    unmarshalledObject.Ec2CapacityReservations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MlReservationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MlReservationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalInstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalInstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsedByCurrentEndpoint", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UsedByCurrentEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ProductionVariantCapacityReservationSummaryUnmarshaller _instance = new ProductionVariantCapacityReservationSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProductionVariantCapacityReservationSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}