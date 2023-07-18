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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruSecurity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeGuruSecurity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScanNameWithFindingNum Object
    /// </summary>  
    public class ScanNameWithFindingNumUnmarshaller : IUnmarshaller<ScanNameWithFindingNum, XmlUnmarshallerContext>, IUnmarshaller<ScanNameWithFindingNum, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScanNameWithFindingNum IUnmarshaller<ScanNameWithFindingNum, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScanNameWithFindingNum Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ScanNameWithFindingNum unmarshalledObject = new ScanNameWithFindingNum();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("findingNumber", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FindingNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ScanNameWithFindingNumUnmarshaller _instance = new ScanNameWithFindingNumUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScanNameWithFindingNumUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}