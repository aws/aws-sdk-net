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
    /// Response Unmarshaller for TemplateVersion Object
    /// </summary>  
    public class TemplateVersionUnmarshaller : IUnmarshaller<TemplateVersion, XmlUnmarshallerContext>, IUnmarshaller<TemplateVersion, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TemplateVersion IUnmarshaller<TemplateVersion, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TemplateVersion Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TemplateVersion unmarshalledObject = new TemplateVersion();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSetConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSetConfiguration, DataSetConfigurationUnmarshaller>(DataSetConfigurationUnmarshaller.Instance);
                    unmarshalledObject.DataSetConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Errors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TemplateError, TemplateErrorUnmarshaller>(TemplateErrorUnmarshaller.Instance);
                    unmarshalledObject.Errors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Sheets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Sheet, SheetUnmarshaller>(SheetUnmarshaller.Instance);
                    unmarshalledObject.Sheets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceEntityArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceEntityArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThemeArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ThemeArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VersionNumber", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.VersionNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TemplateVersionUnmarshaller _instance = new TemplateVersionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TemplateVersionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}