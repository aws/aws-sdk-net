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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAttachmentFieldMappingsListValue in requestObject.AttachmentFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttachmentFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCommentFieldMappings())
            {
                context.Writer.WritePropertyName("CommentFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCommentFieldMappingsListValue in requestObject.CommentFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectCommentFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExclusionPatterns())
            {
                context.Writer.WritePropertyName("ExclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExclusionPatternsListValue in requestObject.ExclusionPatterns)
                {
                        context.Writer.Write(requestObjectExclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInclusionPatterns())
            {
                context.Writer.WritePropertyName("InclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInclusionPatternsListValue in requestObject.InclusionPatterns)
                {
                        context.Writer.Write(requestObjectInclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIssueFieldMappings())
            {
                context.Writer.WritePropertyName("IssueFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIssueFieldMappingsListValue in requestObject.IssueFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectIssueFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIssueSubEntityFilter())
            {
                context.Writer.WritePropertyName("IssueSubEntityFilter");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIssueSubEntityFilterListValue in requestObject.IssueSubEntityFilter)
                {
                        context.Writer.Write(requestObjectIssueSubEntityFilterListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIssueType())
            {
                context.Writer.WritePropertyName("IssueType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIssueTypeListValue in requestObject.IssueType)
                {
                        context.Writer.Write(requestObjectIssueTypeListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetJiraAccountUrl())
            {
                context.Writer.WritePropertyName("JiraAccountUrl");
                context.Writer.Write(requestObject.JiraAccountUrl);
            }

            if(requestObject.IsSetProject())
            {
                context.Writer.WritePropertyName("Project");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProjectListValue in requestObject.Project)
                {
                        context.Writer.Write(requestObjectProjectListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProjectFieldMappings())
            {
                context.Writer.WritePropertyName("ProjectFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProjectFieldMappingsListValue in requestObject.ProjectFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectProjectFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.Write(requestObject.SecretArn);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatusListValue in requestObject.Status)
                {
                        context.Writer.Write(requestObjectStatusListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUseChangeLog())
            {
                context.Writer.WritePropertyName("UseChangeLog");
                context.Writer.Write(requestObject.UseChangeLog);
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DataSourceVpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWorkLogFieldMappings())
            {
                context.Writer.WritePropertyName("WorkLogFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWorkLogFieldMappingsListValue in requestObject.WorkLogFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectWorkLogFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JiraConfigurationMarshaller Instance = new JiraConfigurationMarshaller();

    }
}