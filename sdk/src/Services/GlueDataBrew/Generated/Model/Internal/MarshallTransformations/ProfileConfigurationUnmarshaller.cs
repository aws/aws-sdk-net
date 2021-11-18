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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProfileConfiguration Object
    /// </summary>  
    public class ProfileConfigurationUnmarshaller : IUnmarshaller<ProfileConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ProfileConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProfileConfiguration IUnmarshaller<ProfileConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProfileConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProfileConfiguration unmarshalledObject = new ProfileConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ColumnStatisticsConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ColumnStatisticsConfiguration, ColumnStatisticsConfigurationUnmarshaller>(ColumnStatisticsConfigurationUnmarshaller.Instance);
                    unmarshalledObject.ColumnStatisticsConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetStatisticsConfiguration", targetDepth))
                {
                    var unmarshaller = StatisticsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DatasetStatisticsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntityDetectorConfiguration", targetDepth))
                {
                    var unmarshaller = EntityDetectorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.EntityDetectorConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfileColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ColumnSelector, ColumnSelectorUnmarshaller>(ColumnSelectorUnmarshaller.Instance);
                    unmarshalledObject.ProfileColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProfileConfigurationUnmarshaller _instance = new ProfileConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProfileConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}