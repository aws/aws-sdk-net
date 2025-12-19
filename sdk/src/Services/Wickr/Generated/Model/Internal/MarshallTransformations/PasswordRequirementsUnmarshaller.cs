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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Wickr.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PasswordRequirements Object
    /// </summary>  
    public class PasswordRequirementsUnmarshaller : IUnmarshaller<PasswordRequirements, XmlUnmarshallerContext>, IUnmarshaller<PasswordRequirements, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PasswordRequirements IUnmarshaller<PasswordRequirements, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PasswordRequirements Unmarshall(JsonUnmarshallerContext context)
        {
            PasswordRequirements unmarshalledObject = new PasswordRequirements();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("lowercase", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Lowercase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numbers", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Numbers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("symbols", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Symbols = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("uppercase", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Uppercase = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PasswordRequirementsUnmarshaller _instance = new PasswordRequirementsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PasswordRequirementsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}