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
    /// Response Unmarshaller for AssetBundleImportJobOverrideParameters Object
    /// </summary>  
    public class AssetBundleImportJobOverrideParametersUnmarshaller : IJsonUnmarshaller<AssetBundleImportJobOverrideParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AssetBundleImportJobOverrideParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AssetBundleImportJobOverrideParameters unmarshalledObject = new AssetBundleImportJobOverrideParameters();
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
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobAnalysisOverrideParameters, AssetBundleImportJobAnalysisOverrideParametersUnmarshaller>(AssetBundleImportJobAnalysisOverrideParametersUnmarshaller.Instance);
                    unmarshalledObject.Analyses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Dashboards", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobDashboardOverrideParameters, AssetBundleImportJobDashboardOverrideParametersUnmarshaller>(AssetBundleImportJobDashboardOverrideParametersUnmarshaller.Instance);
                    unmarshalledObject.Dashboards = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobDataSetOverrideParameters, AssetBundleImportJobDataSetOverrideParametersUnmarshaller>(AssetBundleImportJobDataSetOverrideParametersUnmarshaller.Instance);
                    unmarshalledObject.DataSets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobDataSourceOverrideParameters, AssetBundleImportJobDataSourceOverrideParametersUnmarshaller>(AssetBundleImportJobDataSourceOverrideParametersUnmarshaller.Instance);
                    unmarshalledObject.DataSources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Folders", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobFolderOverrideParameters, AssetBundleImportJobFolderOverrideParametersUnmarshaller>(AssetBundleImportJobFolderOverrideParametersUnmarshaller.Instance);
                    unmarshalledObject.Folders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RefreshSchedules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobRefreshScheduleOverrideParameters, AssetBundleImportJobRefreshScheduleOverrideParametersUnmarshaller>(AssetBundleImportJobRefreshScheduleOverrideParametersUnmarshaller.Instance);
                    unmarshalledObject.RefreshSchedules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceIdOverrideConfiguration", targetDepth))
                {
                    var unmarshaller = AssetBundleImportJobResourceIdOverrideConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResourceIdOverrideConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Themes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobThemeOverrideParameters, AssetBundleImportJobThemeOverrideParametersUnmarshaller>(AssetBundleImportJobThemeOverrideParametersUnmarshaller.Instance);
                    unmarshalledObject.Themes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VPCConnections", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobVPCConnectionOverrideParameters, AssetBundleImportJobVPCConnectionOverrideParametersUnmarshaller>(AssetBundleImportJobVPCConnectionOverrideParametersUnmarshaller.Instance);
                    unmarshalledObject.VPCConnections = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AssetBundleImportJobOverrideParametersUnmarshaller _instance = new AssetBundleImportJobOverrideParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssetBundleImportJobOverrideParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}