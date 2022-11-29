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
    /// Response Unmarshaller for RelativeDatesFilter Object
    /// </summary>  
    public class RelativeDatesFilterUnmarshaller : IUnmarshaller<RelativeDatesFilter, XmlUnmarshallerContext>, IUnmarshaller<RelativeDatesFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RelativeDatesFilter IUnmarshaller<RelativeDatesFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RelativeDatesFilter Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RelativeDatesFilter unmarshalledObject = new RelativeDatesFilter();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AnchorDateConfiguration", targetDepth))
                {
                    var unmarshaller = AnchorDateConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AnchorDateConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Column", targetDepth))
                {
                    var unmarshaller = ColumnIdentifierUnmarshaller.Instance;
                    unmarshalledObject.Column = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExcludePeriodConfiguration", targetDepth))
                {
                    var unmarshaller = ExcludePeriodConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ExcludePeriodConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinimumGranularity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MinimumGranularity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NullOption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NullOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParameterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParameterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelativeDateType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelativeDateType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelativeDateValue", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RelativeDateValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeGranularity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeGranularity = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RelativeDatesFilterUnmarshaller _instance = new RelativeDatesFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RelativeDatesFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}