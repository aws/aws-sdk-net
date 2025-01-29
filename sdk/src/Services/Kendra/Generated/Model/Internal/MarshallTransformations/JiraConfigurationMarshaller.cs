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
    /// JiraConfiguration Marshaller
    /// </summary>
    public class JiraConfigurationMarshaller : IRequestMarshaller<JiraConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JiraConfiguration requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetIssueFieldMappings())
            {
                context.Writer.WritePropertyName("IssueFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIssueFieldMappingsListValue in requestObject.IssueFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectIssueFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIssueSubEntityFilter())
            {
                context.Writer.WritePropertyName("IssueSubEntityFilter");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIssueSubEntityFilterListValue in requestObject.IssueSubEntityFilter)
                {
                        context.Writer.WriteStringValue(requestObjectIssueSubEntityFilterListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIssueType())
            {
                context.Writer.WritePropertyName("IssueType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIssueTypeListValue in requestObject.IssueType)
                {
                        context.Writer.WriteStringValue(requestObjectIssueTypeListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetJiraAccountUrl())
            {
                context.Writer.WritePropertyName("JiraAccountUrl");
                context.Writer.WriteStringValue(requestObject.JiraAccountUrl);
            }

            if(requestObject.IsSetProject())
            {
                context.Writer.WritePropertyName("Project");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProjectListValue in requestObject.Project)
                {
                        context.Writer.WriteStringValue(requestObjectProjectListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProjectFieldMappings())
            {
                context.Writer.WritePropertyName("ProjectFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProjectFieldMappingsListValue in requestObject.ProjectFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectProjectFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatusListValue in requestObject.Status)
                {
                        context.Writer.WriteStringValue(requestObjectStatusListValue);
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

            if(requestObject.IsSetWorkLogFieldMappings())
            {
                context.Writer.WritePropertyName("WorkLogFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWorkLogFieldMappingsListValue in requestObject.WorkLogFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectWorkLogFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JiraConfigurationMarshaller Instance = new JiraConfigurationMarshaller();

    }
}