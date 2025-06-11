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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RateBasedStatementCustomKey Marshaller
    /// </summary>
    public class RateBasedStatementCustomKeyMarshaller : IRequestMarshaller<RateBasedStatementCustomKey, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RateBasedStatementCustomKey requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetASN())
            {
                context.Writer.WritePropertyName("ASN");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitAsnMarshaller.Instance;
                marshaller.Marshall(requestObject.ASN, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCookie())
            {
                context.Writer.WritePropertyName("Cookie");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitCookieMarshaller.Instance;
                marshaller.Marshall(requestObject.Cookie, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetForwardedIP())
            {
                context.Writer.WritePropertyName("ForwardedIP");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitForwardedIPMarshaller.Instance;
                marshaller.Marshall(requestObject.ForwardedIP, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHeader())
            {
                context.Writer.WritePropertyName("Header");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitHeaderMarshaller.Instance;
                marshaller.Marshall(requestObject.Header, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHTTPMethod())
            {
                context.Writer.WritePropertyName("HTTPMethod");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitHTTPMethodMarshaller.Instance;
                marshaller.Marshall(requestObject.HTTPMethod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIP())
            {
                context.Writer.WritePropertyName("IP");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitIPMarshaller.Instance;
                marshaller.Marshall(requestObject.IP, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJA3Fingerprint())
            {
                context.Writer.WritePropertyName("JA3Fingerprint");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitJA3FingerprintMarshaller.Instance;
                marshaller.Marshall(requestObject.JA3Fingerprint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJA4Fingerprint())
            {
                context.Writer.WritePropertyName("JA4Fingerprint");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitJA4FingerprintMarshaller.Instance;
                marshaller.Marshall(requestObject.JA4Fingerprint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLabelNamespace())
            {
                context.Writer.WritePropertyName("LabelNamespace");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitLabelNamespaceMarshaller.Instance;
                marshaller.Marshall(requestObject.LabelNamespace, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQueryArgument())
            {
                context.Writer.WritePropertyName("QueryArgument");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitQueryArgumentMarshaller.Instance;
                marshaller.Marshall(requestObject.QueryArgument, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQueryString())
            {
                context.Writer.WritePropertyName("QueryString");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitQueryStringMarshaller.Instance;
                marshaller.Marshall(requestObject.QueryString, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUriPath())
            {
                context.Writer.WritePropertyName("UriPath");
                context.Writer.WriteStartObject();

                var marshaller = RateLimitUriPathMarshaller.Instance;
                marshaller.Marshall(requestObject.UriPath, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RateBasedStatementCustomKeyMarshaller Instance = new RateBasedStatementCustomKeyMarshaller();

    }
}