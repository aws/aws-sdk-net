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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CoverageTime Object
    /// </summary>  
    public class CoverageTimeUnmarshaller : IUnmarshaller<CoverageTime, XmlUnmarshallerContext>, IUnmarshaller<CoverageTime, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CoverageTime IUnmarshaller<CoverageTime, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CoverageTime Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CoverageTime unmarshalledObject = new CoverageTime();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("End", targetDepth))
                {
                    var unmarshaller = HandOffTimeUnmarshaller.Instance;
                    unmarshalledObject.End = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Start", targetDepth))
                {
                    var unmarshaller = HandOffTimeUnmarshaller.Instance;
                    unmarshalledObject.Start = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CoverageTimeUnmarshaller _instance = new CoverageTimeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CoverageTimeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}