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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Capabilities Object
    /// </summary>  
    public class CapabilitiesUnmarshaller : IUnmarshaller<Capabilities, XmlUnmarshallerContext>, IUnmarshaller<Capabilities, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Capabilities IUnmarshaller<Capabilities, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Capabilities Unmarshall(JsonUnmarshallerContext context)
        {
            Capabilities unmarshalledObject = new Capabilities();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AddOrRunAnomalyDetectionForAnalyses", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddOrRunAnomalyDetectionForAnalyses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Analysis", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Analysis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateDashboardEmailReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateDashboardEmailReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateDatasets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateDatasets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateDataSources", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateDataSources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateThemes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateThemes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateThresholdAlerts", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateThresholdAlerts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateSharedFolders", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateSharedFolders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateSPICEDataset", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateSPICEDataset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dashboard", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Dashboard = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToCsv", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToCsv = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToCsvInScheduledReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToCsvInScheduledReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToExcel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToExcel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToExcelInScheduledReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToExcelInScheduledReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToPdf", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToPdf = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToPdfInScheduledReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToPdfInScheduledReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeContentInScheduledReportsEmail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IncludeContentInScheduledReportsEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrintReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrintReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenameSharedFolders", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RenameSharedFolders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareAnalyses", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareAnalyses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareDashboards", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareDashboards = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareDatasets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareDatasets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareDataSources", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareDataSources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubscribeDashboardEmailReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubscribeDashboardEmailReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViewAccountSPICECapacity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ViewAccountSPICECapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CapabilitiesUnmarshaller _instance = new CapabilitiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CapabilitiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}