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
    /// GitHubConfiguration Marshaller
    /// </summary>
    public class GitHubConfigurationMarshaller : IRequestMarshaller<GitHubConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GitHubConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExclusionFileNamePatterns())
            {
                context.Writer.WritePropertyName("ExclusionFileNamePatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExclusionFileNamePatternsListValue in requestObject.ExclusionFileNamePatterns)
                {
                        context.Writer.WriteStringValue(requestObjectExclusionFileNamePatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExclusionFileTypePatterns())
            {
                context.Writer.WritePropertyName("ExclusionFileTypePatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExclusionFileTypePatternsListValue in requestObject.ExclusionFileTypePatterns)
                {
                        context.Writer.WriteStringValue(requestObjectExclusionFileTypePatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExclusionFolderNamePatterns())
            {
                context.Writer.WritePropertyName("ExclusionFolderNamePatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExclusionFolderNamePatternsListValue in requestObject.ExclusionFolderNamePatterns)
                {
                        context.Writer.WriteStringValue(requestObjectExclusionFolderNamePatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGitHubCommitConfigurationFieldMappings())
            {
                context.Writer.WritePropertyName("GitHubCommitConfigurationFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGitHubCommitConfigurationFieldMappingsListValue in requestObject.GitHubCommitConfigurationFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectGitHubCommitConfigurationFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGitHubDocumentCrawlProperties())
            {
                context.Writer.WritePropertyName("GitHubDocumentCrawlProperties");
                context.Writer.WriteStartObject();

                var marshaller = GitHubDocumentCrawlPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.GitHubDocumentCrawlProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGitHubIssueAttachmentConfigurationFieldMappings())
            {
                context.Writer.WritePropertyName("GitHubIssueAttachmentConfigurationFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGitHubIssueAttachmentConfigurationFieldMappingsListValue in requestObject.GitHubIssueAttachmentConfigurationFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectGitHubIssueAttachmentConfigurationFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGitHubIssueCommentConfigurationFieldMappings())
            {
                context.Writer.WritePropertyName("GitHubIssueCommentConfigurationFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGitHubIssueCommentConfigurationFieldMappingsListValue in requestObject.GitHubIssueCommentConfigurationFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectGitHubIssueCommentConfigurationFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGitHubIssueDocumentConfigurationFieldMappings())
            {
                context.Writer.WritePropertyName("GitHubIssueDocumentConfigurationFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGitHubIssueDocumentConfigurationFieldMappingsListValue in requestObject.GitHubIssueDocumentConfigurationFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectGitHubIssueDocumentConfigurationFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGitHubPullRequestCommentConfigurationFieldMappings())
            {
                context.Writer.WritePropertyName("GitHubPullRequestCommentConfigurationFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGitHubPullRequestCommentConfigurationFieldMappingsListValue in requestObject.GitHubPullRequestCommentConfigurationFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectGitHubPullRequestCommentConfigurationFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGitHubPullRequestDocumentAttachmentConfigurationFieldMappings())
            {
                context.Writer.WritePropertyName("GitHubPullRequestDocumentAttachmentConfigurationFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGitHubPullRequestDocumentAttachmentConfigurationFieldMappingsListValue in requestObject.GitHubPullRequestDocumentAttachmentConfigurationFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectGitHubPullRequestDocumentAttachmentConfigurationFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGitHubPullRequestDocumentConfigurationFieldMappings())
            {
                context.Writer.WritePropertyName("GitHubPullRequestDocumentConfigurationFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGitHubPullRequestDocumentConfigurationFieldMappingsListValue in requestObject.GitHubPullRequestDocumentConfigurationFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectGitHubPullRequestDocumentConfigurationFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGitHubRepositoryConfigurationFieldMappings())
            {
                context.Writer.WritePropertyName("GitHubRepositoryConfigurationFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGitHubRepositoryConfigurationFieldMappingsListValue in requestObject.GitHubRepositoryConfigurationFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectGitHubRepositoryConfigurationFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInclusionFileNamePatterns())
            {
                context.Writer.WritePropertyName("InclusionFileNamePatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInclusionFileNamePatternsListValue in requestObject.InclusionFileNamePatterns)
                {
                        context.Writer.WriteStringValue(requestObjectInclusionFileNamePatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInclusionFileTypePatterns())
            {
                context.Writer.WritePropertyName("InclusionFileTypePatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInclusionFileTypePatternsListValue in requestObject.InclusionFileTypePatterns)
                {
                        context.Writer.WriteStringValue(requestObjectInclusionFileTypePatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInclusionFolderNamePatterns())
            {
                context.Writer.WritePropertyName("InclusionFolderNamePatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInclusionFolderNamePatternsListValue in requestObject.InclusionFolderNamePatterns)
                {
                        context.Writer.WriteStringValue(requestObjectInclusionFolderNamePatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOnPremiseConfiguration())
            {
                context.Writer.WritePropertyName("OnPremiseConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OnPremiseConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OnPremiseConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRepositoryFilter())
            {
                context.Writer.WritePropertyName("RepositoryFilter");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRepositoryFilterListValue in requestObject.RepositoryFilter)
                {
                        context.Writer.WriteStringValue(requestObjectRepositoryFilterListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSaaSConfiguration())
            {
                context.Writer.WritePropertyName("SaaSConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SaaSConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SaaSConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
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

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GitHubConfigurationMarshaller Instance = new GitHubConfigurationMarshaller();

    }
}