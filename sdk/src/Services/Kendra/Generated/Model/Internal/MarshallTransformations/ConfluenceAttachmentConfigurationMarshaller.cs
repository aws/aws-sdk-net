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
    /// ConfluenceAttachmentConfiguration Marshaller
    /// </summary>       
    public class ConfluenceAttachmentConfigurationMarshaller : IRequestMarshaller<ConfluenceAttachmentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConfluenceAttachmentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttachmentFieldMappings())
            {
                context.Writer.WritePropertyName("AttachmentFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAttachmentFieldMappingsListValue in requestObject.AttachmentFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfluenceAttachmentToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttachmentFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCrawlAttachments())
            {
                context.Writer.WritePropertyName("CrawlAttachments");
                context.Writer.Write(requestObject.CrawlAttachments);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ConfluenceAttachmentConfigurationMarshaller Instance = new ConfluenceAttachmentConfigurationMarshaller();

    }
}