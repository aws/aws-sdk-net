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
    /// Response Unmarshaller for DataSourceConfiguration Object
    /// </summary>  
    public class DataSourceConfigurationUnmarshaller : IJsonUnmarshaller<DataSourceConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DataSourceConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DataSourceConfiguration unmarshalledObject = new DataSourceConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AlfrescoConfiguration", targetDepth))
                {
                    var unmarshaller = AlfrescoConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AlfrescoConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BoxConfiguration", targetDepth))
                {
                    var unmarshaller = BoxConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BoxConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConfluenceConfiguration", targetDepth))
                {
                    var unmarshaller = ConfluenceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ConfluenceConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DatabaseConfiguration", targetDepth))
                {
                    var unmarshaller = DatabaseConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DatabaseConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FsxConfiguration", targetDepth))
                {
                    var unmarshaller = FsxConfigurationUnmarshaller.Instance;
                    unmarshalledObject.FsxConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GitHubConfiguration", targetDepth))
                {
                    var unmarshaller = GitHubConfigurationUnmarshaller.Instance;
                    unmarshalledObject.GitHubConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GoogleDriveConfiguration", targetDepth))
                {
                    var unmarshaller = GoogleDriveConfigurationUnmarshaller.Instance;
                    unmarshalledObject.GoogleDriveConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JiraConfiguration", targetDepth))
                {
                    var unmarshaller = JiraConfigurationUnmarshaller.Instance;
                    unmarshalledObject.JiraConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OneDriveConfiguration", targetDepth))
                {
                    var unmarshaller = OneDriveConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OneDriveConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QuipConfiguration", targetDepth))
                {
                    var unmarshaller = QuipConfigurationUnmarshaller.Instance;
                    unmarshalledObject.QuipConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3Configuration", targetDepth))
                {
                    var unmarshaller = S3DataSourceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3Configuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SalesforceConfiguration", targetDepth))
                {
                    var unmarshaller = SalesforceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SalesforceConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceNowConfiguration", targetDepth))
                {
                    var unmarshaller = ServiceNowConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ServiceNowConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SharePointConfiguration", targetDepth))
                {
                    var unmarshaller = SharePointConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SharePointConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SlackConfiguration", targetDepth))
                {
                    var unmarshaller = SlackConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SlackConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TemplateConfiguration", targetDepth))
                {
                    var unmarshaller = TemplateConfigurationUnmarshaller.Instance;
                    unmarshalledObject.TemplateConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WebCrawlerConfiguration", targetDepth))
                {
                    var unmarshaller = WebCrawlerConfigurationUnmarshaller.Instance;
                    unmarshalledObject.WebCrawlerConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkDocsConfiguration", targetDepth))
                {
                    var unmarshaller = WorkDocsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.WorkDocsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataSourceConfigurationUnmarshaller _instance = new DataSourceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataSourceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}