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

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JiraConfiguration Object
    /// </summary>  
    public class JiraConfigurationUnmarshaller : IUnmarshaller<JiraConfiguration, XmlUnmarshallerContext>, IUnmarshaller<JiraConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JiraConfiguration IUnmarshaller<JiraConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public JiraConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            JiraConfiguration unmarshalledObject = new JiraConfiguration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AttachmentFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.AttachmentFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CommentFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.CommentFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExclusionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InclusionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IssueFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.IssueFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IssueSubEntityFilter", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IssueSubEntityFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IssueType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IssueType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JiraAccountUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JiraAccountUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Project", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Project = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.ProjectFieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("WorkLogFieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.WorkLogFieldMappings = unmarshaller.Unmarshall(context);
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
#pragma warning restore CS0612,CS0618