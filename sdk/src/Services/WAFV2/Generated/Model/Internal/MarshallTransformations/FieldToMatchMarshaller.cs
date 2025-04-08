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
    /// FieldToMatch Marshaller
    /// </summary>
    public class FieldToMatchMarshaller : IRequestMarshaller<FieldToMatch, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FieldToMatch requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllQueryArguments())
            {
                context.Writer.WritePropertyName("AllQueryArguments");
                context.Writer.WriteStartObject();

                var marshaller = AllQueryArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.AllQueryArguments, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("Body");
                context.Writer.WriteStartObject();

                var marshaller = BodyMarshaller.Instance;
                marshaller.Marshall(requestObject.Body, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCookies())
            {
                context.Writer.WritePropertyName("Cookies");
                context.Writer.WriteStartObject();

                var marshaller = CookiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Cookies, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHeaderOrder())
            {
                context.Writer.WritePropertyName("HeaderOrder");
                context.Writer.WriteStartObject();

                var marshaller = HeaderOrderMarshaller.Instance;
                marshaller.Marshall(requestObject.HeaderOrder, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHeaders())
            {
                context.Writer.WritePropertyName("Headers");
                context.Writer.WriteStartObject();

                var marshaller = HeadersMarshaller.Instance;
                marshaller.Marshall(requestObject.Headers, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJA3Fingerprint())
            {
                context.Writer.WritePropertyName("JA3Fingerprint");
                context.Writer.WriteStartObject();

                var marshaller = JA3FingerprintMarshaller.Instance;
                marshaller.Marshall(requestObject.JA3Fingerprint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJA4Fingerprint())
            {
                context.Writer.WritePropertyName("JA4Fingerprint");
                context.Writer.WriteStartObject();

                var marshaller = JA4FingerprintMarshaller.Instance;
                marshaller.Marshall(requestObject.JA4Fingerprint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJsonBody())
            {
                context.Writer.WritePropertyName("JsonBody");
                context.Writer.WriteStartObject();

                var marshaller = JsonBodyMarshaller.Instance;
                marshaller.Marshall(requestObject.JsonBody, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMethod())
            {
                context.Writer.WritePropertyName("Method");
                context.Writer.WriteStartObject();

                var marshaller = MethodMarshaller.Instance;
                marshaller.Marshall(requestObject.Method, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQueryString())
            {
                context.Writer.WritePropertyName("QueryString");
                context.Writer.WriteStartObject();

                var marshaller = QueryStringMarshaller.Instance;
                marshaller.Marshall(requestObject.QueryString, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSingleHeader())
            {
                context.Writer.WritePropertyName("SingleHeader");
                context.Writer.WriteStartObject();

                var marshaller = SingleHeaderMarshaller.Instance;
                marshaller.Marshall(requestObject.SingleHeader, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSingleQueryArgument())
            {
                context.Writer.WritePropertyName("SingleQueryArgument");
                context.Writer.WriteStartObject();

                var marshaller = SingleQueryArgumentMarshaller.Instance;
                marshaller.Marshall(requestObject.SingleQueryArgument, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUriFragment())
            {
                context.Writer.WritePropertyName("UriFragment");
                context.Writer.WriteStartObject();

                var marshaller = UriFragmentMarshaller.Instance;
                marshaller.Marshall(requestObject.UriFragment, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUriPath())
            {
                context.Writer.WritePropertyName("UriPath");
                context.Writer.WriteStartObject();

                var marshaller = UriPathMarshaller.Instance;
                marshaller.Marshall(requestObject.UriPath, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldToMatchMarshaller Instance = new FieldToMatchMarshaller();

    }
}