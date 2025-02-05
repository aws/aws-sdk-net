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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CacheSettings Marshaller
    /// </summary>
    public class CacheSettingsMarshaller : IRequestMarshaller<CacheSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CacheSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedHTTPMethods())
            {
                context.Writer.WritePropertyName("allowedHTTPMethods");
                context.Writer.WriteStringValue(requestObject.AllowedHTTPMethods);
            }

            if(requestObject.IsSetCachedHTTPMethods())
            {
                context.Writer.WritePropertyName("cachedHTTPMethods");
                context.Writer.WriteStringValue(requestObject.CachedHTTPMethods);
            }

            if(requestObject.IsSetDefaultTTL())
            {
                context.Writer.WritePropertyName("defaultTTL");
                context.Writer.WriteNumberValue(requestObject.DefaultTTL.Value);
            }

            if(requestObject.IsSetForwardedCookies())
            {
                context.Writer.WritePropertyName("forwardedCookies");
                context.Writer.WriteStartObject();

                var marshaller = CookieObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.ForwardedCookies, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetForwardedHeaders())
            {
                context.Writer.WritePropertyName("forwardedHeaders");
                context.Writer.WriteStartObject();

                var marshaller = HeaderObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.ForwardedHeaders, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetForwardedQueryStrings())
            {
                context.Writer.WritePropertyName("forwardedQueryStrings");
                context.Writer.WriteStartObject();

                var marshaller = QueryStringObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.ForwardedQueryStrings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaximumTTL())
            {
                context.Writer.WritePropertyName("maximumTTL");
                context.Writer.WriteNumberValue(requestObject.MaximumTTL.Value);
            }

            if(requestObject.IsSetMinimumTTL())
            {
                context.Writer.WritePropertyName("minimumTTL");
                context.Writer.WriteNumberValue(requestObject.MinimumTTL.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CacheSettingsMarshaller Instance = new CacheSettingsMarshaller();

    }
}