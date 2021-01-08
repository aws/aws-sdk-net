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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EC2ResourceUtilization Object
    /// </summary>  
    public class EC2ResourceUtilizationUnmarshaller : IUnmarshaller<EC2ResourceUtilization, XmlUnmarshallerContext>, IUnmarshaller<EC2ResourceUtilization, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EC2ResourceUtilization IUnmarshaller<EC2ResourceUtilization, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EC2ResourceUtilization Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EC2ResourceUtilization unmarshalledObject = new EC2ResourceUtilization();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EBSResourceUtilization", targetDepth))
                {
                    var unmarshaller = EBSResourceUtilizationUnmarshaller.Instance;
                    unmarshalledObject.EBSResourceUtilization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxCpuUtilizationPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxCpuUtilizationPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxMemoryUtilizationPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxMemoryUtilizationPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxStorageUtilizationPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxStorageUtilizationPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EC2ResourceUtilizationUnmarshaller _instance = new EC2ResourceUtilizationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EC2ResourceUtilizationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}