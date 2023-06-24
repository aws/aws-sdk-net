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
using System.Net;
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
    /// Response Unmarshaller for GitHubConfiguration Object
    /// </summary>  
    public class GitHubConfigurationUnmarshaller : IUnmarshaller<GitHubConfiguration, XmlUnmarshallerContext>, IUnmarshaller<GitHubConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GitHubConfiguration IUnmarshaller<GitHubConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GitHubConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            GitHubConfiguration unmarshalledObject = new GitHubConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExclusionFileNamePatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionFileNamePatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExclusionFileTypePatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionFileTypePatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExclusionFolderNamePatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionFolderNamePatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubCommitConfigurationFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.GitHubCommitConfigurationFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubDocumentCrawlProperties", targetDepth))
                {
                    var unmarshaller = GitHubDocumentCrawlPropertiesUnmarshaller.Instance;
                    unmarshalledObject.GitHubDocumentCrawlProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubIssueAttachmentConfigurationFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.GitHubIssueAttachmentConfigurationFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubIssueCommentConfigurationFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.GitHubIssueCommentConfigurationFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubIssueDocumentConfigurationFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.GitHubIssueDocumentConfigurationFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubPullRequestCommentConfigurationFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.GitHubPullRequestCommentConfigurationFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubPullRequestDocumentAttachmentConfigurationFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.GitHubPullRequestDocumentAttachmentConfigurationFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubPullRequestDocumentConfigurationFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.GitHubPullRequestDocumentConfigurationFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GitHubRepositoryConfigurationFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.GitHubRepositoryConfigurationFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InclusionFileNamePatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionFileNamePatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InclusionFileTypePatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionFileTypePatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InclusionFolderNamePatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionFolderNamePatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OnPremiseConfiguration", targetDepth))
                {
                    var unmarshaller = OnPremiseConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OnPremiseConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RepositoryFilter", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RepositoryFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SaaSConfiguration", targetDepth))
                {
                    var unmarshaller = SaaSConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SaaSConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseChangeLog", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseChangeLog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcConfiguration", targetDepth))
                {
                    var unmarshaller = DataSourceVpcConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VpcConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GitHubConfigurationUnmarshaller _instance = new GitHubConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GitHubConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}