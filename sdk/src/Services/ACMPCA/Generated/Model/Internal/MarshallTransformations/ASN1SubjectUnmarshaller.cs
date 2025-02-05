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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ASN1Subject Object
    /// </summary>  
    public class ASN1SubjectUnmarshaller : IJsonUnmarshaller<ASN1Subject, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ASN1Subject Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ASN1Subject unmarshalledObject = new ASN1Subject();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CommonName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CommonName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Country", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Country = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CustomAttributes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CustomAttribute, CustomAttributeUnmarshaller>(CustomAttributeUnmarshaller.Instance);
                    unmarshalledObject.CustomAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DistinguishedNameQualifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DistinguishedNameQualifier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GenerationQualifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GenerationQualifier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GivenName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GivenName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Initials", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Initials = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Locality", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Locality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Organization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Organization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OrganizationalUnit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationalUnit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Pseudonym", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Pseudonym = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SerialNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SerialNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Surname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Surname = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ASN1SubjectUnmarshaller _instance = new ASN1SubjectUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ASN1SubjectUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}