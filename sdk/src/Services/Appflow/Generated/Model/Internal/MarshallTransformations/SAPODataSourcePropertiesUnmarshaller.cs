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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SAPODataSourceProperties Object
    /// </summary>  
    public class SAPODataSourcePropertiesUnmarshaller : IUnmarshaller<SAPODataSourceProperties, XmlUnmarshallerContext>, IUnmarshaller<SAPODataSourceProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SAPODataSourceProperties IUnmarshaller<SAPODataSourceProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SAPODataSourceProperties Unmarshall(JsonUnmarshallerContext context)
        {
            SAPODataSourceProperties unmarshalledObject = new SAPODataSourceProperties();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("objectPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObjectPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("paginationConfig", targetDepth))
                {
                    var unmarshaller = SAPODataPaginationConfigUnmarshaller.Instance;
                    unmarshalledObject.PaginationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parallelismConfig", targetDepth))
                {
                    var unmarshaller = SAPODataParallelismConfigUnmarshaller.Instance;
                    unmarshalledObject.ParallelismConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SAPODataSourcePropertiesUnmarshaller _instance = new SAPODataSourcePropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SAPODataSourcePropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}