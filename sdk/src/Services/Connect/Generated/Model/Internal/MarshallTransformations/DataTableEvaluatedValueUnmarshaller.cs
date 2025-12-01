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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataTableEvaluatedValue Object
    /// </summary>  
    public class DataTableEvaluatedValueUnmarshaller : IUnmarshaller<DataTableEvaluatedValue, XmlUnmarshallerContext>, IUnmarshaller<DataTableEvaluatedValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataTableEvaluatedValue IUnmarshaller<DataTableEvaluatedValue, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DataTableEvaluatedValue Unmarshall(JsonUnmarshallerContext context)
        {
            DataTableEvaluatedValue unmarshalledObject = new DataTableEvaluatedValue();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AttributeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AttributeName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Error", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Error = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluatedValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluatedValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Found", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Found = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PrimaryValue, PrimaryValueUnmarshaller>(PrimaryValueUnmarshaller.Instance);
                    unmarshalledObject.PrimaryValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValueType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ValueType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataTableEvaluatedValueUnmarshaller _instance = new DataTableEvaluatedValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataTableEvaluatedValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}