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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsApiGatewayMethodSettings Marshaller
    /// </summary>       
    public class AwsApiGatewayMethodSettingsMarshaller : IRequestMarshaller<AwsApiGatewayMethodSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsApiGatewayMethodSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCacheDataEncrypted())
            {
                context.Writer.WritePropertyName("CacheDataEncrypted");
                context.Writer.Write(requestObject.CacheDataEncrypted);
            }

            if(requestObject.IsSetCacheTtlInSeconds())
            {
                context.Writer.WritePropertyName("CacheTtlInSeconds");
                context.Writer.Write(requestObject.CacheTtlInSeconds);
            }

            if(requestObject.IsSetCachingEnabled())
            {
                context.Writer.WritePropertyName("CachingEnabled");
                context.Writer.Write(requestObject.CachingEnabled);
            }

            if(requestObject.IsSetDataTraceEnabled())
            {
                context.Writer.WritePropertyName("DataTraceEnabled");
                context.Writer.Write(requestObject.DataTraceEnabled);
            }

            if(requestObject.IsSetHttpMethod())
            {
                context.Writer.WritePropertyName("HttpMethod");
                context.Writer.Write(requestObject.HttpMethod);
            }

            if(requestObject.IsSetLoggingLevel())
            {
                context.Writer.WritePropertyName("LoggingLevel");
                context.Writer.Write(requestObject.LoggingLevel);
            }

            if(requestObject.IsSetMetricsEnabled())
            {
                context.Writer.WritePropertyName("MetricsEnabled");
                context.Writer.Write(requestObject.MetricsEnabled);
            }

            if(requestObject.IsSetRequireAuthorizationForCacheControl())
            {
                context.Writer.WritePropertyName("RequireAuthorizationForCacheControl");
                context.Writer.Write(requestObject.RequireAuthorizationForCacheControl);
            }

            if(requestObject.IsSetResourcePath())
            {
                context.Writer.WritePropertyName("ResourcePath");
                context.Writer.Write(requestObject.ResourcePath);
            }

            if(requestObject.IsSetThrottlingBurstLimit())
            {
                context.Writer.WritePropertyName("ThrottlingBurstLimit");
                context.Writer.Write(requestObject.ThrottlingBurstLimit);
            }

            if(requestObject.IsSetThrottlingRateLimit())
            {
                context.Writer.WritePropertyName("ThrottlingRateLimit");
                context.Writer.Write(requestObject.ThrottlingRateLimit);
            }

            if(requestObject.IsSetUnauthorizedCacheControlHeaderStrategy())
            {
                context.Writer.WritePropertyName("UnauthorizedCacheControlHeaderStrategy");
                context.Writer.Write(requestObject.UnauthorizedCacheControlHeaderStrategy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsApiGatewayMethodSettingsMarshaller Instance = new AwsApiGatewayMethodSettingsMarshaller();

    }
}