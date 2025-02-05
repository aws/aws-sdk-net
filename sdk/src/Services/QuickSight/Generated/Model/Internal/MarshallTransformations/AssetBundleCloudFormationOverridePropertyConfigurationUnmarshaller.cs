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
    /// Response Unmarshaller for AssetBundleCloudFormationOverridePropertyConfiguration Object
    /// </summary>  
    public class AssetBundleCloudFormationOverridePropertyConfigurationUnmarshaller : IJsonUnmarshaller<AssetBundleCloudFormationOverridePropertyConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AssetBundleCloudFormationOverridePropertyConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AssetBundleCloudFormationOverridePropertyConfiguration unmarshalledObject = new AssetBundleCloudFormationOverridePropertyConfiguration();
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
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleExportJobAnalysisOverrideProperties, AssetBundleExportJobAnalysisOverridePropertiesUnmarshaller>(AssetBundleExportJobAnalysisOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.Analyses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Dashboards", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleExportJobDashboardOverrideProperties, AssetBundleExportJobDashboardOverridePropertiesUnmarshaller>(AssetBundleExportJobDashboardOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.Dashboards = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleExportJobDataSetOverrideProperties, AssetBundleExportJobDataSetOverridePropertiesUnmarshaller>(AssetBundleExportJobDataSetOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.DataSets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleExportJobDataSourceOverrideProperties, AssetBundleExportJobDataSourceOverridePropertiesUnmarshaller>(AssetBundleExportJobDataSourceOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.DataSources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Folders", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleExportJobFolderOverrideProperties, AssetBundleExportJobFolderOverridePropertiesUnmarshaller>(AssetBundleExportJobFolderOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.Folders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RefreshSchedules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleExportJobRefreshScheduleOverrideProperties, AssetBundleExportJobRefreshScheduleOverridePropertiesUnmarshaller>(AssetBundleExportJobRefreshScheduleOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.RefreshSchedules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceIdOverrideConfiguration", targetDepth))
                {
                    var unmarshaller = AssetBundleExportJobResourceIdOverrideConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResourceIdOverrideConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Themes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleExportJobThemeOverrideProperties, AssetBundleExportJobThemeOverridePropertiesUnmarshaller>(AssetBundleExportJobThemeOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.Themes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VPCConnections", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleExportJobVPCConnectionOverrideProperties, AssetBundleExportJobVPCConnectionOverridePropertiesUnmarshaller>(AssetBundleExportJobVPCConnectionOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.VPCConnections = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AssetBundleCloudFormationOverridePropertyConfigurationUnmarshaller _instance = new AssetBundleCloudFormationOverridePropertyConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssetBundleCloudFormationOverridePropertyConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}