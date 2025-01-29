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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApiStage Marshaller
    /// </summary>
    public class ApiStageMarshaller : IRequestMarshaller<ApiStage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ApiStage requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApiId())
            {
                context.Writer.WritePropertyName("apiId");
                context.Writer.WriteStringValue(requestObject.ApiId);
            }

            if(requestObject.IsSetStage())
            {
                context.Writer.WritePropertyName("stage");
                context.Writer.WriteStringValue(requestObject.Stage);
            }

            if(requestObject.IsSetThrottle())
            {
                context.Writer.WritePropertyName("throttle");
                context.Writer.WriteStartObject();
                foreach (var requestObjectThrottleKvp in requestObject.Throttle)
                {
                    context.Writer.WritePropertyName(requestObjectThrottleKvp.Key);
                    var requestObjectThrottleValue = requestObjectThrottleKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ThrottleSettingsMarshaller.Instance;
                    marshaller.Marshall(requestObjectThrottleValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ApiStageMarshaller Instance = new ApiStageMarshaller();

    }
}