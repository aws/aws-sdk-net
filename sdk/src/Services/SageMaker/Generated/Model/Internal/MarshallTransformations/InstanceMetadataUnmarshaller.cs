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
    /// Response Unmarshaller for InstanceMetadata Object
    /// </summary>  
    public class InstanceMetadataUnmarshaller : IUnmarshaller<InstanceMetadata, XmlUnmarshallerContext>, IUnmarshaller<InstanceMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InstanceMetadata IUnmarshaller<InstanceMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            InstanceMetadata unmarshalledObject = new InstanceMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalEnis", targetDepth))
                {
                    var unmarshaller = AdditionalEnisUnmarshaller.Instance;
                    unmarshalledObject.AdditionalEnis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CapacityReservation", targetDepth))
                {
                    var unmarshaller = CapacityReservationUnmarshaller.Instance;
                    unmarshalledObject.CapacityReservation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerEni", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomerEni = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LcsExecutionState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LcsExecutionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NodeLogicalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NodeLogicalId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstanceMetadataUnmarshaller _instance = new InstanceMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}