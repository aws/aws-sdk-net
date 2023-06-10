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
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssetBundleCloudFormationOverridePropertyConfiguration Object
    /// </summary>  
    public class AssetBundleCloudFormationOverridePropertyConfigurationUnmarshaller : IUnmarshaller<AssetBundleCloudFormationOverridePropertyConfiguration, XmlUnmarshallerContext>, IUnmarshaller<AssetBundleCloudFormationOverridePropertyConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssetBundleCloudFormationOverridePropertyConfiguration IUnmarshaller<AssetBundleCloudFormationOverridePropertyConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AssetBundleCloudFormationOverridePropertyConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AssetBundleCloudFormationOverridePropertyConfiguration unmarshalledObject = new AssetBundleCloudFormationOverridePropertyConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Analyses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetBundleExportJobAnalysisOverrideProperties, AssetBundleExportJobAnalysisOverridePropertiesUnmarshaller>(AssetBundleExportJobAnalysisOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.Analyses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dashboards", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetBundleExportJobDashboardOverrideProperties, AssetBundleExportJobDashboardOverridePropertiesUnmarshaller>(AssetBundleExportJobDashboardOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.Dashboards = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetBundleExportJobDataSetOverrideProperties, AssetBundleExportJobDataSetOverridePropertiesUnmarshaller>(AssetBundleExportJobDataSetOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.DataSets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetBundleExportJobDataSourceOverrideProperties, AssetBundleExportJobDataSourceOverridePropertiesUnmarshaller>(AssetBundleExportJobDataSourceOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.DataSources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RefreshSchedules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetBundleExportJobRefreshScheduleOverrideProperties, AssetBundleExportJobRefreshScheduleOverridePropertiesUnmarshaller>(AssetBundleExportJobRefreshScheduleOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.RefreshSchedules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceIdOverrideConfiguration", targetDepth))
                {
                    var unmarshaller = AssetBundleExportJobResourceIdOverrideConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResourceIdOverrideConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Themes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetBundleExportJobThemeOverrideProperties, AssetBundleExportJobThemeOverridePropertiesUnmarshaller>(AssetBundleExportJobThemeOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.Themes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VPCConnections", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetBundleExportJobVPCConnectionOverrideProperties, AssetBundleExportJobVPCConnectionOverridePropertiesUnmarshaller>(AssetBundleExportJobVPCConnectionOverridePropertiesUnmarshaller.Instance);
                    unmarshalledObject.VPCConnections = unmarshaller.Unmarshall(context);
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