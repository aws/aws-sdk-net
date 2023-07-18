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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CommitmentInformation Object
    /// </summary>  
    public class CommitmentInformationUnmarshaller : IUnmarshaller<CommitmentInformation, XmlUnmarshallerContext>, IUnmarshaller<CommitmentInformation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CommitmentInformation IUnmarshaller<CommitmentInformation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CommitmentInformation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CommitmentInformation unmarshalledObject = new CommitmentInformation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("commitmentConfiguration", targetDepth))
                {
                    var unmarshaller = CommitmentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CommitmentConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("expiresOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ExpiresOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CommitmentInformationUnmarshaller _instance = new CommitmentInformationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CommitmentInformationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}