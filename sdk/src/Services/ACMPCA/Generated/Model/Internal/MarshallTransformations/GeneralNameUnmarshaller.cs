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
    /// Response Unmarshaller for GeneralName Object
    /// </summary>  
    public class GeneralNameUnmarshaller : IUnmarshaller<GeneralName, XmlUnmarshallerContext>, IUnmarshaller<GeneralName, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GeneralName IUnmarshaller<GeneralName, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GeneralName Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            GeneralName unmarshalledObject = new GeneralName();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DirectoryName", targetDepth))
                {
                    var unmarshaller = ASN1SubjectUnmarshaller.Instance;
                    unmarshalledObject.DirectoryName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EdiPartyName", targetDepth))
                {
                    var unmarshaller = EdiPartyNameUnmarshaller.Instance;
                    unmarshalledObject.EdiPartyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OtherName", targetDepth))
                {
                    var unmarshaller = OtherNameUnmarshaller.Instance;
                    unmarshalledObject.OtherName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegisteredId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegisteredId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Rfc822Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Rfc822Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UniformResourceIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UniformResourceIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GeneralNameUnmarshaller _instance = new GeneralNameUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GeneralNameUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}