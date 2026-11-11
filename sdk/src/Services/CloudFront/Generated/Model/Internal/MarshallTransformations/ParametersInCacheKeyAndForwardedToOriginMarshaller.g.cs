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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.CloudFront.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParametersInCacheKeyAndForwardedToOrigin Marshaller
    /// </summary>
    public partial class ParametersInCacheKeyAndForwardedToOriginMarshaller : IRequestMarshaller<ParametersInCacheKeyAndForwardedToOrigin, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ParametersInCacheKeyAndForwardedToOrigin requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCookiesConfig())
            {
                context.Writer.WriteStartElement("CookiesConfig");
                CachePolicyCookiesConfigMarshaller.Instance.Marshall(requestObject.CookiesConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetEnableAcceptEncodingBrotli())
            {
                context.Writer.WriteElementString("EnableAcceptEncodingBrotli", StringUtils.FromBool(requestObject.EnableAcceptEncodingBrotli.Value));
            }
            if (requestObject.IsSetEnableAcceptEncodingGzip())
            {
                context.Writer.WriteElementString("EnableAcceptEncodingGzip", StringUtils.FromBool(requestObject.EnableAcceptEncodingGzip.Value));
            }
            if (requestObject.IsSetHeadersConfig())
            {
                context.Writer.WriteStartElement("HeadersConfig");
                CachePolicyHeadersConfigMarshaller.Instance.Marshall(requestObject.HeadersConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetQueryStringsConfig())
            {
                context.Writer.WriteStartElement("QueryStringsConfig");
                CachePolicyQueryStringsConfigMarshaller.Instance.Marshall(requestObject.QueryStringsConfig, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ParametersInCacheKeyAndForwardedToOriginMarshaller Instance = new ParametersInCacheKeyAndForwardedToOriginMarshaller();
    }
}
