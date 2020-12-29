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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CsrExtensions Object
    /// </summary>  
    public class CsrExtensionsUnmarshaller : IUnmarshaller<CsrExtensions, XmlUnmarshallerContext>, IUnmarshaller<CsrExtensions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CsrExtensions IUnmarshaller<CsrExtensions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CsrExtensions Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CsrExtensions unmarshalledObject = new CsrExtensions();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("KeyUsage", targetDepth))
                {
                    var unmarshaller = KeyUsageUnmarshaller.Instance;
                    unmarshalledObject.KeyUsage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubjectInformationAccess", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AccessDescription, AccessDescriptionUnmarshaller>(AccessDescriptionUnmarshaller.Instance);
                    unmarshalledObject.SubjectInformationAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CsrExtensionsUnmarshaller _instance = new CsrExtensionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CsrExtensionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}