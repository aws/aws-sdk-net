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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Ipv6CidrBlockAssociation Object
    /// </summary>  
    public class Ipv6CidrBlockAssociationUnmarshaller : IJsonUnmarshaller<Ipv6CidrBlockAssociation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Ipv6CidrBlockAssociation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Ipv6CidrBlockAssociation unmarshalledObject = new Ipv6CidrBlockAssociation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AssociationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociationId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CidrBlockState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CidrBlockState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv6CidrBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ipv6CidrBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Ipv6CidrBlockAssociationUnmarshaller _instance = new Ipv6CidrBlockAssociationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Ipv6CidrBlockAssociationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}