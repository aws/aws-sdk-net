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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataSourceIntrospectionModel Object
    /// </summary>  
    public class DataSourceIntrospectionModelUnmarshaller : IUnmarshaller<DataSourceIntrospectionModel, XmlUnmarshallerContext>, IUnmarshaller<DataSourceIntrospectionModel, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataSourceIntrospectionModel IUnmarshaller<DataSourceIntrospectionModel, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DataSourceIntrospectionModel Unmarshall(JsonUnmarshallerContext context)
        {
            DataSourceIntrospectionModel unmarshalledObject = new DataSourceIntrospectionModel();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("fields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceIntrospectionModelField, DataSourceIntrospectionModelFieldUnmarshaller>(DataSourceIntrospectionModelFieldUnmarshaller.Instance);
                    unmarshalledObject.Fields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("indexes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceIntrospectionModelIndex, DataSourceIntrospectionModelIndexUnmarshaller>(DataSourceIntrospectionModelIndexUnmarshaller.Instance);
                    unmarshalledObject.Indexes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("primaryKey", targetDepth))
                {
                    var unmarshaller = DataSourceIntrospectionModelIndexUnmarshaller.Instance;
                    unmarshalledObject.PrimaryKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sdl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Sdl = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataSourceIntrospectionModelUnmarshaller _instance = new DataSourceIntrospectionModelUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataSourceIntrospectionModelUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}