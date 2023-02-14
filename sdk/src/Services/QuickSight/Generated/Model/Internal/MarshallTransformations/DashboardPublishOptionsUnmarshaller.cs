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
    /// Response Unmarshaller for DashboardPublishOptions Object
    /// </summary>  
    public class DashboardPublishOptionsUnmarshaller : IUnmarshaller<DashboardPublishOptions, XmlUnmarshallerContext>, IUnmarshaller<DashboardPublishOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DashboardPublishOptions IUnmarshaller<DashboardPublishOptions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DashboardPublishOptions Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DashboardPublishOptions unmarshalledObject = new DashboardPublishOptions();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdHocFilteringOption", targetDepth))
                {
                    var unmarshaller = AdHocFilteringOptionUnmarshaller.Instance;
                    unmarshalledObject.AdHocFilteringOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataPointDrillUpDownOption", targetDepth))
                {
                    var unmarshaller = DataPointDrillUpDownOptionUnmarshaller.Instance;
                    unmarshalledObject.DataPointDrillUpDownOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataPointMenuLabelOption", targetDepth))
                {
                    var unmarshaller = DataPointMenuLabelOptionUnmarshaller.Instance;
                    unmarshalledObject.DataPointMenuLabelOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataPointTooltipOption", targetDepth))
                {
                    var unmarshaller = DataPointTooltipOptionUnmarshaller.Instance;
                    unmarshalledObject.DataPointTooltipOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToCSVOption", targetDepth))
                {
                    var unmarshaller = ExportToCSVOptionUnmarshaller.Instance;
                    unmarshalledObject.ExportToCSVOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportWithHiddenFieldsOption", targetDepth))
                {
                    var unmarshaller = ExportWithHiddenFieldsOptionUnmarshaller.Instance;
                    unmarshalledObject.ExportWithHiddenFieldsOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SheetControlsOption", targetDepth))
                {
                    var unmarshaller = SheetControlsOptionUnmarshaller.Instance;
                    unmarshalledObject.SheetControlsOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SheetLayoutElementMaximizationOption", targetDepth))
                {
                    var unmarshaller = SheetLayoutElementMaximizationOptionUnmarshaller.Instance;
                    unmarshalledObject.SheetLayoutElementMaximizationOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VisualAxisSortOption", targetDepth))
                {
                    var unmarshaller = VisualAxisSortOptionUnmarshaller.Instance;
                    unmarshalledObject.VisualAxisSortOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VisualMenuOption", targetDepth))
                {
                    var unmarshaller = VisualMenuOptionUnmarshaller.Instance;
                    unmarshalledObject.VisualMenuOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VisualPublishOptions", targetDepth))
                {
                    var unmarshaller = DashboardVisualPublishOptionsUnmarshaller.Instance;
                    unmarshalledObject.VisualPublishOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DashboardPublishOptionsUnmarshaller _instance = new DashboardPublishOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DashboardPublishOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}