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
    /// Response Unmarshaller for TrainingPlanOffering Object
    /// </summary>  
    public class TrainingPlanOfferingUnmarshaller : IUnmarshaller<TrainingPlanOffering, XmlUnmarshallerContext>, IUnmarshaller<TrainingPlanOffering, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TrainingPlanOffering IUnmarshaller<TrainingPlanOffering, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TrainingPlanOffering Unmarshall(JsonUnmarshallerContext context)
        {
            TrainingPlanOffering unmarshalledObject = new TrainingPlanOffering();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DurationHours", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DurationHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DurationMinutes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DurationMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestedEndTimeBefore", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RequestedEndTimeBefore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestedStartTimeAfter", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RequestedStartTimeAfter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReservedCapacityOfferings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ReservedCapacityOffering, ReservedCapacityOfferingUnmarshaller>(ReservedCapacityOfferingUnmarshaller.Instance);
                    unmarshalledObject.ReservedCapacityOfferings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetResources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TargetResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingPlanOfferingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingPlanOfferingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpfrontFee", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpfrontFee = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TrainingPlanOfferingUnmarshaller _instance = new TrainingPlanOfferingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrainingPlanOfferingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}