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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetCrawlerLimits())
            {
                context.Writer.WritePropertyName("crawlerLimits");
                context.Writer.WriteObjectStart();

                var marshaller = WebCrawlerLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.CrawlerLimits, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExclusionFilters())
            {
                context.Writer.WritePropertyName("exclusionFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExclusionFiltersListValue in requestObject.ExclusionFilters)
                {
                        context.Writer.Write(requestObjectExclusionFiltersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInclusionFilters())
            {
                context.Writer.WritePropertyName("inclusionFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInclusionFiltersListValue in requestObject.InclusionFilters)
                {
                        context.Writer.Write(requestObjectInclusionFiltersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("scope");
                context.Writer.Write(requestObject.Scope);
            }

            if(requestObject.IsSetUserAgent())
            {
                context.Writer.WritePropertyName("userAgent");
                context.Writer.Write(requestObject.UserAgent);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WebCrawlerConfigurationMarshaller Instance = new WebCrawlerConfigurationMarshaller();

    }
}