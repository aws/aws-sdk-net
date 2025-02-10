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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssetBundleImportJobOverrideTags Object
    /// </summary>  
    public class AssetBundleImportJobOverrideTagsUnmarshaller : IJsonUnmarshaller<AssetBundleImportJobOverrideTags, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AssetBundleImportJobOverrideTags Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AssetBundleImportJobOverrideTags unmarshalledObject = new AssetBundleImportJobOverrideTags();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Analyses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobAnalysisOverrideTags, AssetBundleImportJobAnalysisOverrideTagsUnmarshaller>(AssetBundleImportJobAnalysisOverrideTagsUnmarshaller.Instance);
                    unmarshalledObject.Analyses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Dashboards", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobDashboardOverrideTags, AssetBundleImportJobDashboardOverrideTagsUnmarshaller>(AssetBundleImportJobDashboardOverrideTagsUnmarshaller.Instance);
                    unmarshalledObject.Dashboards = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobDataSetOverrideTags, AssetBundleImportJobDataSetOverrideTagsUnmarshaller>(AssetBundleImportJobDataSetOverrideTagsUnmarshaller.Instance);
                    unmarshalledObject.DataSets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobDataSourceOverrideTags, AssetBundleImportJobDataSourceOverrideTagsUnmarshaller>(AssetBundleImportJobDataSourceOverrideTagsUnmarshaller.Instance);
                    unmarshalledObject.DataSources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Folders", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobFolderOverrideTags, AssetBundleImportJobFolderOverrideTagsUnmarshaller>(AssetBundleImportJobFolderOverrideTagsUnmarshaller.Instance);
                    unmarshalledObject.Folders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Themes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobThemeOverrideTags, AssetBundleImportJobThemeOverrideTagsUnmarshaller>(AssetBundleImportJobThemeOverrideTagsUnmarshaller.Instance);
                    unmarshalledObject.Themes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VPCConnections", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobVPCConnectionOverrideTags, AssetBundleImportJobVPCConnectionOverrideTagsUnmarshaller>(AssetBundleImportJobVPCConnectionOverrideTagsUnmarshaller.Instance);
                    unmarshalledObject.VPCConnections = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AssetBundleImportJobOverrideTagsUnmarshaller _instance = new AssetBundleImportJobOverrideTagsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssetBundleImportJobOverrideTagsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}