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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LambdaWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LambdaWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EndpointConfig Marshaller
    /// </summary>
    public class EndpointConfigMarshaller : IRequestMarshaller<EndpointConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EndpointConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthType())
            {
                context.Writer.WritePropertyName("authType");
                context.Writer.WriteStringValue(requestObject.AuthType);
            }

            if(requestObject.IsSetAutoDeploymentMode())
            {
                context.Writer.WritePropertyName("autoDeploymentMode");
                context.Writer.WriteStringValue(requestObject.AutoDeploymentMode);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetEndpointName())
            {
                context.Writer.WritePropertyName("endpointName");
                context.Writer.WriteStringValue(requestObject.EndpointName);
            }

            if(requestObject.IsSetEndpointType())
            {
                context.Writer.WritePropertyName("endpointType");
                context.Writer.WriteStringValue(requestObject.EndpointType);
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.WriteStringValue(requestObjectRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScalingConfig())
            {
                context.Writer.WritePropertyName("scalingConfig");
                context.Writer.WriteStartObject();

                var marshaller = ScalingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ScalingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetThrottleConfig())
            {
                context.Writer.WritePropertyName("throttleConfig");
                context.Writer.WriteStartObject();

                var marshaller = ThrottleConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ThrottleConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EndpointConfigMarshaller Instance = new EndpointConfigMarshaller();

    }
}