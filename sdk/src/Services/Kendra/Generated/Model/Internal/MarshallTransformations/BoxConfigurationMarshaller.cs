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
    /// BoxConfiguration Marshaller
    /// </summary>
    public class BoxConfigurationMarshaller : IRequestMarshaller<BoxConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BoxConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommentFieldMappings())
            {
                context.Writer.WritePropertyName("CommentFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCommentFieldMappingsListValue in requestObject.CommentFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectCommentFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCrawlComments())
            {
                context.Writer.WritePropertyName("CrawlComments");
                context.Writer.WriteBooleanValue(requestObject.CrawlComments.Value);
            }

            if(requestObject.IsSetCrawlTasks())
            {
                context.Writer.WritePropertyName("CrawlTasks");
                context.Writer.WriteBooleanValue(requestObject.CrawlTasks.Value);
            }

            if(requestObject.IsSetCrawlWebLinks())
            {
                context.Writer.WritePropertyName("CrawlWebLinks");
                context.Writer.WriteBooleanValue(requestObject.CrawlWebLinks.Value);
            }

            if(requestObject.IsSetEnterpriseId())
            {
                context.Writer.WritePropertyName("EnterpriseId");
                context.Writer.WriteStringValue(requestObject.EnterpriseId);
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

            if(requestObject.IsSetFileFieldMappings())
            {
                context.Writer.WritePropertyName("FileFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFileFieldMappingsListValue in requestObject.FileFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectFileFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
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

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

            if(requestObject.IsSetTaskFieldMappings())
            {
                context.Writer.WritePropertyName("TaskFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTaskFieldMappingsListValue in requestObject.TaskFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectTaskFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUseChangeLog())
            {
                context.Writer.WritePropertyName("UseChangeLog");
                context.Writer.WriteBooleanValue(requestObject.UseChangeLog.Value);
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceVpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWebLinkFieldMappings())
            {
                context.Writer.WritePropertyName("WebLinkFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWebLinkFieldMappingsListValue in requestObject.WebLinkFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectWebLinkFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BoxConfigurationMarshaller Instance = new BoxConfigurationMarshaller();

    }
}