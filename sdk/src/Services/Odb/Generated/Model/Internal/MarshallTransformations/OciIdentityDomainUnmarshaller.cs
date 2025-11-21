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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OciIdentityDomain Object
    /// </summary>  
    public class OciIdentityDomainUnmarshaller : IUnmarshaller<OciIdentityDomain, XmlUnmarshallerContext>, IUnmarshaller<OciIdentityDomain, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OciIdentityDomain IUnmarshaller<OciIdentityDomain, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OciIdentityDomain Unmarshall(JsonUnmarshallerContext context)
        {
            OciIdentityDomain unmarshalledObject = new OciIdentityDomain();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountSetupCloudFormationUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountSetupCloudFormationUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ociIdentityDomainId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OciIdentityDomainId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ociIdentityDomainResourceUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OciIdentityDomainResourceUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ociIdentityDomainUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OciIdentityDomainUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OciIdentityDomainUnmarshaller _instance = new OciIdentityDomainUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OciIdentityDomainUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}