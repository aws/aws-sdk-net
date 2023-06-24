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
    /// Response Unmarshaller for DashboardVersionDefinition Object
    /// </summary>  
    public class DashboardVersionDefinitionUnmarshaller : IUnmarshaller<DashboardVersionDefinition, XmlUnmarshallerContext>, IUnmarshaller<DashboardVersionDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DashboardVersionDefinition IUnmarshaller<DashboardVersionDefinition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DashboardVersionDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DashboardVersionDefinition unmarshalledObject = new DashboardVersionDefinition();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AnalysisDefaults", targetDepth))
                {
                    var unmarshaller = AnalysisDefaultsUnmarshaller.Instance;
                    unmarshalledObject.AnalysisDefaults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CalculatedFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CalculatedField, CalculatedFieldUnmarshaller>(CalculatedFieldUnmarshaller.Instance);
                    unmarshalledObject.CalculatedFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ColumnConfiguration, ColumnConfigurationUnmarshaller>(ColumnConfigurationUnmarshaller.Instance);
                    unmarshalledObject.ColumnConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSetIdentifierDeclarations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSetIdentifierDeclaration, DataSetIdentifierDeclarationUnmarshaller>(DataSetIdentifierDeclarationUnmarshaller.Instance);
                    unmarshalledObject.DataSetIdentifierDeclarations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FilterGroup, FilterGroupUnmarshaller>(FilterGroupUnmarshaller.Instance);
                    unmarshalledObject.FilterGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParameterDeclarations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ParameterDeclaration, ParameterDeclarationUnmarshaller>(ParameterDeclarationUnmarshaller.Instance);
                    unmarshalledObject.ParameterDeclarations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Sheets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SheetDefinition, SheetDefinitionUnmarshaller>(SheetDefinitionUnmarshaller.Instance);
                    unmarshalledObject.Sheets = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DashboardVersionDefinitionUnmarshaller _instance = new DashboardVersionDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DashboardVersionDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}