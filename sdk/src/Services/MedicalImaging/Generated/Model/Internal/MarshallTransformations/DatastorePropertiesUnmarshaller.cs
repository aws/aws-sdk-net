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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MedicalImaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MedicalImaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DatastoreProperties Object
    /// </summary>  
    public class DatastorePropertiesUnmarshaller : IUnmarshaller<DatastoreProperties, XmlUnmarshallerContext>, IUnmarshaller<DatastoreProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DatastoreProperties IUnmarshaller<DatastoreProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DatastoreProperties Unmarshall(JsonUnmarshallerContext context)
        {
            DatastoreProperties unmarshalledObject = new DatastoreProperties();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("datastoreArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatastoreArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("datastoreId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatastoreId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("datastoreName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatastoreName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("datastoreStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatastoreStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kmsKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambdaAuthorizerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LambdaAuthorizerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DatastorePropertiesUnmarshaller _instance = new DatastorePropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DatastorePropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}