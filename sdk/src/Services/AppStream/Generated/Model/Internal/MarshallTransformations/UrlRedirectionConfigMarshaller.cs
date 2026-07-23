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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UrlRedirectionConfig Marshaller
    /// </summary>
    public class UrlRedirectionConfigMarshaller : IRequestMarshaller<UrlRedirectionConfig, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UrlRedirectionConfig requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAllowedUrls())
            {
                context.Writer.WriteTextString("AllowedUrls");
                context.Writer.WriteStartArray(requestObject.AllowedUrls.Count);
                foreach(var requestObjectAllowedUrlsListValue in requestObject.AllowedUrls)
                {
                        context.Writer.WriteTextString(requestObjectAllowedUrlsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetDeniedUrls())
            {
                context.Writer.WriteTextString("DeniedUrls");
                context.Writer.WriteStartArray(requestObject.DeniedUrls.Count);
                foreach(var requestObjectDeniedUrlsListValue in requestObject.DeniedUrls)
                {
                        context.Writer.WriteTextString(requestObjectDeniedUrlsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEnabled())
            {
                context.Writer.WriteTextString("Enabled");
                context.Writer.WriteBoolean(requestObject.Enabled.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UrlRedirectionConfigMarshaller Instance = new UrlRedirectionConfigMarshaller();

    }
}