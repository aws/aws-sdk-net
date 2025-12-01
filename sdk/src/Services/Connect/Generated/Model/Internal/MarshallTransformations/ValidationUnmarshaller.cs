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
    /// Response Unmarshaller for Validation Object
    /// </summary>  
    public class ValidationUnmarshaller : IUnmarshaller<Validation, XmlUnmarshallerContext>, IUnmarshaller<Validation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Validation IUnmarshaller<Validation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Validation Unmarshall(JsonUnmarshallerContext context)
        {
            Validation unmarshalledObject = new Validation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Enum", targetDepth))
                {
                    var unmarshaller = ValidationEnumUnmarshaller.Instance;
                    unmarshalledObject.Enum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExclusiveMaximum", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ExclusiveMaximum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExclusiveMinimum", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ExclusiveMinimum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IgnoreCase", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IgnoreCase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Maximum", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Maximum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxValues", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Minimum", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Minimum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinValues", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultipleOf", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.MultipleOf = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ValidationUnmarshaller _instance = new ValidationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ValidationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}