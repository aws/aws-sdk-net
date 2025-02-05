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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JiraConfiguration Object
    /// </summary>  
    public class JiraConfigurationUnmarshaller : IJsonUnmarshaller<JiraConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public JiraConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            JiraConfiguration unmarshalledObject = new JiraConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AttachmentFieldMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.AttachmentFieldMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CommentFieldMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.CommentFieldMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExclusionPatterns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionPatterns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InclusionPatterns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionPatterns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IssueFieldMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.IssueFieldMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IssueSubEntityFilter", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IssueSubEntityFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IssueType", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IssueType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JiraAccountUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JiraAccountUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Project", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Project = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProjectFieldMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.ProjectFieldMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UseChangeLog", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.UseChangeLog = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcConfiguration", targetDepth))
                {
                    var unmarshaller = DataSourceVpcConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VpcConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkLogFieldMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.WorkLogFieldMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JiraConfigurationUnmarshaller _instance = new JiraConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JiraConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}