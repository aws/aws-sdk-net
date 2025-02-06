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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsApiGatewayV2RouteSettings Marshaller
    /// </summary>
    public class AwsApiGatewayV2RouteSettingsMarshaller : IRequestMarshaller<AwsApiGatewayV2RouteSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsApiGatewayV2RouteSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataTraceEnabled())
            {
                context.Writer.WritePropertyName("DataTraceEnabled");
                context.Writer.WriteBooleanValue(requestObject.DataTraceEnabled.Value);
            }

            if(requestObject.IsSetDetailedMetricsEnabled())
            {
                context.Writer.WritePropertyName("DetailedMetricsEnabled");
                context.Writer.WriteBooleanValue(requestObject.DetailedMetricsEnabled.Value);
            }

            if(requestObject.IsSetLoggingLevel())
            {
                context.Writer.WritePropertyName("LoggingLevel");
                context.Writer.WriteStringValue(requestObject.LoggingLevel);
            }

            if(requestObject.IsSetThrottlingBurstLimit())
            {
                context.Writer.WritePropertyName("ThrottlingBurstLimit");
                context.Writer.WriteNumberValue(requestObject.ThrottlingBurstLimit.Value);
            }

            if(requestObject.IsSetThrottlingRateLimit())
            {
                context.Writer.WritePropertyName("ThrottlingRateLimit");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ThrottlingRateLimit.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ThrottlingRateLimit.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ThrottlingRateLimit.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsApiGatewayV2RouteSettingsMarshaller Instance = new AwsApiGatewayV2RouteSettingsMarshaller();

    }
}