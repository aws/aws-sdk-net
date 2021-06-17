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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WebCrawlerConfiguration Marshaller
    /// </summary>       
    public class WebCrawlerConfigurationMarshaller : IRequestMarshaller<WebCrawlerConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WebCrawlerConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAuthenticationConfiguration())
            {
                context.Writer.WritePropertyName("AuthenticationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AuthenticationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthenticationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCrawlDepth())
            {
                context.Writer.WritePropertyName("CrawlDepth");
                context.Writer.Write(requestObject.CrawlDepth);
            }

            if(requestObject.IsSetMaxContentSizePerPageInMegaBytes())
            {
                context.Writer.WritePropertyName("MaxContentSizePerPageInMegaBytes");
                context.Writer.Write(requestObject.MaxContentSizePerPageInMegaBytes);
            }

            if(requestObject.IsSetMaxLinksPerPage())
            {
                context.Writer.WritePropertyName("MaxLinksPerPage");
                context.Writer.Write(requestObject.MaxLinksPerPage);
            }

            if(requestObject.IsSetMaxUrlsPerMinuteCrawlRate())
            {
                context.Writer.WritePropertyName("MaxUrlsPerMinuteCrawlRate");
                context.Writer.Write(requestObject.MaxUrlsPerMinuteCrawlRate);
            }

            if(requestObject.IsSetProxyConfiguration())
            {
                context.Writer.WritePropertyName("ProxyConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ProxyConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProxyConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUrlExclusionPatterns())
            {
                context.Writer.WritePropertyName("UrlExclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUrlExclusionPatternsListValue in requestObject.UrlExclusionPatterns)
                {
                        context.Writer.Write(requestObjectUrlExclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUrlInclusionPatterns())
            {
                context.Writer.WritePropertyName("UrlInclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUrlInclusionPatternsListValue in requestObject.UrlInclusionPatterns)
                {
                        context.Writer.Write(requestObjectUrlInclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUrls())
            {
                context.Writer.WritePropertyName("Urls");
                context.Writer.WriteObjectStart();

                var marshaller = UrlsMarshaller.Instance;
                marshaller.Marshall(requestObject.Urls, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static WebCrawlerConfigurationMarshaller Instance = new WebCrawlerConfigurationMarshaller();

    }
}