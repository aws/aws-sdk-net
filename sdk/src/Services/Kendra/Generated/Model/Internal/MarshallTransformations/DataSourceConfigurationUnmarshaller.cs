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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataSourceConfiguration Object
    /// </summary>  
    public class DataSourceConfigurationUnmarshaller : IUnmarshaller<DataSourceConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DataSourceConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataSourceConfiguration IUnmarshaller<DataSourceConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataSourceConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataSourceConfiguration unmarshalledObject = new DataSourceConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConfluenceConfiguration", targetDepth))
                {
                    var unmarshaller = ConfluenceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ConfluenceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseConfiguration", targetDepth))
                {
                    var unmarshaller = DatabaseConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DatabaseConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GoogleDriveConfiguration", targetDepth))
                {
                    var unmarshaller = GoogleDriveConfigurationUnmarshaller.Instance;
                    unmarshalledObject.GoogleDriveConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OneDriveConfiguration", targetDepth))
                {
                    var unmarshaller = OneDriveConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OneDriveConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3Configuration", targetDepth))
                {
                    var unmarshaller = S3DataSourceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3Configuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SalesforceConfiguration", targetDepth))
                {
                    var unmarshaller = SalesforceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SalesforceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceNowConfiguration", targetDepth))
                {
                    var unmarshaller = ServiceNowConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ServiceNowConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SharePointConfiguration", targetDepth))
                {
                    var unmarshaller = SharePointConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SharePointConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataSourceConfigurationUnmarshaller _instance = new DataSourceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataSourceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}