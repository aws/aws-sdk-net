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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TemplateV2 Object
    /// </summary>  
    public class TemplateV2Unmarshaller : IJsonUnmarshaller<TemplateV2, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TemplateV2 Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TemplateV2 unmarshalledObject = new TemplateV2();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CertificateValidity", targetDepth))
                {
                    var unmarshaller = CertificateValidityUnmarshaller.Instance;
                    unmarshalledObject.CertificateValidity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnrollmentFlags", targetDepth))
                {
                    var unmarshaller = EnrollmentFlagsV2Unmarshaller.Instance;
                    unmarshalledObject.EnrollmentFlags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Extensions", targetDepth))
                {
                    var unmarshaller = ExtensionsV2Unmarshaller.Instance;
                    unmarshalledObject.Extensions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GeneralFlags", targetDepth))
                {
                    var unmarshaller = GeneralFlagsV2Unmarshaller.Instance;
                    unmarshalledObject.GeneralFlags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrivateKeyAttributes", targetDepth))
                {
                    var unmarshaller = PrivateKeyAttributesV2Unmarshaller.Instance;
                    unmarshalledObject.PrivateKeyAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrivateKeyFlags", targetDepth))
                {
                    var unmarshaller = PrivateKeyFlagsV2Unmarshaller.Instance;
                    unmarshalledObject.PrivateKeyFlags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubjectNameFlags", targetDepth))
                {
                    var unmarshaller = SubjectNameFlagsV2Unmarshaller.Instance;
                    unmarshalledObject.SubjectNameFlags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SupersededTemplates", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupersededTemplates = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TemplateV2Unmarshaller _instance = new TemplateV2Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TemplateV2Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}