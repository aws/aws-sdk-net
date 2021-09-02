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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SvmEndpoints Object
    /// </summary>  
    public class SvmEndpointsUnmarshaller : IUnmarshaller<SvmEndpoints, XmlUnmarshallerContext>, IUnmarshaller<SvmEndpoints, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SvmEndpoints IUnmarshaller<SvmEndpoints, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SvmEndpoints Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SvmEndpoints unmarshalledObject = new SvmEndpoints();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Iscsi", targetDepth))
                {
                    var unmarshaller = SvmEndpointUnmarshaller.Instance;
                    unmarshalledObject.Iscsi = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Management", targetDepth))
                {
                    var unmarshaller = SvmEndpointUnmarshaller.Instance;
                    unmarshalledObject.Management = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Nfs", targetDepth))
                {
                    var unmarshaller = SvmEndpointUnmarshaller.Instance;
                    unmarshalledObject.Nfs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Smb", targetDepth))
                {
                    var unmarshaller = SvmEndpointUnmarshaller.Instance;
                    unmarshalledObject.Smb = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SvmEndpointsUnmarshaller _instance = new SvmEndpointsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SvmEndpointsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}