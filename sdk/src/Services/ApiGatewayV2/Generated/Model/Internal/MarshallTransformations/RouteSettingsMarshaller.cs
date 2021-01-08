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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RouteSettings Marshaller
    /// </summary>       
    public class RouteSettingsMarshaller : IRequestMarshaller<RouteSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouteSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataTraceEnabled())
            {
                context.Writer.WritePropertyName("dataTraceEnabled");
                context.Writer.Write(requestObject.DataTraceEnabled);
            }

            if(requestObject.IsSetDetailedMetricsEnabled())
            {
                context.Writer.WritePropertyName("detailedMetricsEnabled");
                context.Writer.Write(requestObject.DetailedMetricsEnabled);
            }

            if(requestObject.IsSetLoggingLevel())
            {
                context.Writer.WritePropertyName("loggingLevel");
                context.Writer.Write(requestObject.LoggingLevel);
            }

            if(requestObject.IsSetThrottlingBurstLimit())
            {
                context.Writer.WritePropertyName("throttlingBurstLimit");
                context.Writer.Write(requestObject.ThrottlingBurstLimit);
            }

            if(requestObject.IsSetThrottlingRateLimit())
            {
                context.Writer.WritePropertyName("throttlingRateLimit");
                context.Writer.Write(requestObject.ThrottlingRateLimit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RouteSettingsMarshaller Instance = new RouteSettingsMarshaller();

    }
}