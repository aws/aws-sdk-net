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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataLakeLifecycleConfiguration Object
    /// </summary>  
    public class DataLakeLifecycleConfigurationUnmarshaller : IUnmarshaller<DataLakeLifecycleConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DataLakeLifecycleConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataLakeLifecycleConfiguration IUnmarshaller<DataLakeLifecycleConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataLakeLifecycleConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataLakeLifecycleConfiguration unmarshalledObject = new DataLakeLifecycleConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("expiration", targetDepth))
                {
                    var unmarshaller = DataLakeLifecycleExpirationUnmarshaller.Instance;
                    unmarshalledObject.Expiration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataLakeLifecycleTransition, DataLakeLifecycleTransitionUnmarshaller>(DataLakeLifecycleTransitionUnmarshaller.Instance);
                    unmarshalledObject.Transitions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataLakeLifecycleConfigurationUnmarshaller _instance = new DataLakeLifecycleConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataLakeLifecycleConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}