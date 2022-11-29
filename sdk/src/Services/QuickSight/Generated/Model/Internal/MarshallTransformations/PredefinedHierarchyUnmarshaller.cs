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
    /// Response Unmarshaller for PredefinedHierarchy Object
    /// </summary>  
    public class PredefinedHierarchyUnmarshaller : IUnmarshaller<PredefinedHierarchy, XmlUnmarshallerContext>, IUnmarshaller<PredefinedHierarchy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PredefinedHierarchy IUnmarshaller<PredefinedHierarchy, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PredefinedHierarchy Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PredefinedHierarchy unmarshalledObject = new PredefinedHierarchy();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Columns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ColumnIdentifier, ColumnIdentifierUnmarshaller>(ColumnIdentifierUnmarshaller.Instance);
                    unmarshalledObject.Columns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DrillDownFilters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DrillDownFilter, DrillDownFilterUnmarshaller>(DrillDownFilterUnmarshaller.Instance);
                    unmarshalledObject.DrillDownFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HierarchyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HierarchyId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PredefinedHierarchyUnmarshaller _instance = new PredefinedHierarchyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PredefinedHierarchyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}