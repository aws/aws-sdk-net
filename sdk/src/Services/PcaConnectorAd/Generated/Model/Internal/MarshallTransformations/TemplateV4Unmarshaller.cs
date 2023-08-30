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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TemplateV4 Object
    /// </summary>  
    public class TemplateV4Unmarshaller : IUnmarshaller<TemplateV4, XmlUnmarshallerContext>, IUnmarshaller<TemplateV4, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TemplateV4 IUnmarshaller<TemplateV4, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TemplateV4 Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TemplateV4 unmarshalledObject = new TemplateV4();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CertificateValidity", targetDepth))
                {
                    var unmarshaller = CertificateValidityUnmarshaller.Instance;
                    unmarshalledObject.CertificateValidity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnrollmentFlags", targetDepth))
                {
                    var unmarshaller = EnrollmentFlagsV4Unmarshaller.Instance;
                    unmarshalledObject.EnrollmentFlags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Extensions", targetDepth))
                {
                    var unmarshaller = ExtensionsV4Unmarshaller.Instance;
                    unmarshalledObject.Extensions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeneralFlags", targetDepth))
                {
                    var unmarshaller = GeneralFlagsV4Unmarshaller.Instance;
                    unmarshalledObject.GeneralFlags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HashAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HashAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivateKeyAttributes", targetDepth))
                {
                    var unmarshaller = PrivateKeyAttributesV4Unmarshaller.Instance;
                    unmarshalledObject.PrivateKeyAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivateKeyFlags", targetDepth))
                {
                    var unmarshaller = PrivateKeyFlagsV4Unmarshaller.Instance;
                    unmarshalledObject.PrivateKeyFlags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubjectNameFlags", targetDepth))
                {
                    var unmarshaller = SubjectNameFlagsV4Unmarshaller.Instance;
                    unmarshalledObject.SubjectNameFlags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupersededTemplates", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupersededTemplates = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TemplateV4Unmarshaller _instance = new TemplateV4Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TemplateV4Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}