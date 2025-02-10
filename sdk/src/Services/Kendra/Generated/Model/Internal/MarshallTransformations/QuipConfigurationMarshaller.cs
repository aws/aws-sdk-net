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
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QuipConfiguration Marshaller
    /// </summary>
    public class QuipConfigurationMarshaller : IRequestMarshaller<QuipConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QuipConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttachmentFieldMappings())
            {
                context.Writer.WritePropertyName("AttachmentFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttachmentFieldMappingsListValue in requestObject.AttachmentFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttachmentFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCrawlAttachments())
            {
                context.Writer.WritePropertyName("CrawlAttachments");
                context.Writer.WriteBooleanValue(requestObject.CrawlAttachments.Value);
            }

            if(requestObject.IsSetCrawlChatRooms())
            {
                context.Writer.WritePropertyName("CrawlChatRooms");
                context.Writer.WriteBooleanValue(requestObject.CrawlChatRooms.Value);
            }

            if(requestObject.IsSetCrawlFileComments())
            {
                context.Writer.WritePropertyName("CrawlFileComments");
                context.Writer.WriteBooleanValue(requestObject.CrawlFileComments.Value);
            }

            if(requestObject.IsSetDomain())
            {
                context.Writer.WritePropertyName("Domain");
                context.Writer.WriteStringValue(requestObject.Domain);
            }

            if(requestObject.IsSetExclusionPatterns())
            {
                context.Writer.WritePropertyName("ExclusionPatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExclusionPatternsListValue in requestObject.ExclusionPatterns)
                {
                        context.Writer.WriteStringValue(requestObjectExclusionPatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFolderIds())
            {
                context.Writer.WritePropertyName("FolderIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFolderIdsListValue in requestObject.FolderIds)
                {
                        context.Writer.WriteStringValue(requestObjectFolderIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInclusionPatterns())
            {
                context.Writer.WritePropertyName("InclusionPatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInclusionPatternsListValue in requestObject.InclusionPatterns)
                {
                        context.Writer.WriteStringValue(requestObjectInclusionPatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMessageFieldMappings())
            {
                context.Writer.WritePropertyName("MessageFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMessageFieldMappingsListValue in requestObject.MessageFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectMessageFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

            if(requestObject.IsSetThreadFieldMappings())
            {
                context.Writer.WritePropertyName("ThreadFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreadFieldMappingsListValue in requestObject.ThreadFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreadFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceVpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QuipConfigurationMarshaller Instance = new QuipConfigurationMarshaller();

    }
}