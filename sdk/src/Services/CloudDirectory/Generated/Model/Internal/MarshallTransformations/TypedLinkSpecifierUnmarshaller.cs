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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TypedLinkSpecifier Object
    /// </summary>  
    public class TypedLinkSpecifierUnmarshaller : IJsonUnmarshaller<TypedLinkSpecifier, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TypedLinkSpecifier Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TypedLinkSpecifier unmarshalledObject = new TypedLinkSpecifier();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("IdentityAttributeValues", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AttributeNameAndValue, AttributeNameAndValueUnmarshaller>(AttributeNameAndValueUnmarshaller.Instance);
                    unmarshalledObject.IdentityAttributeValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceObjectReference", targetDepth))
                {
                    var unmarshaller = ObjectReferenceUnmarshaller.Instance;
                    unmarshalledObject.SourceObjectReference = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetObjectReference", targetDepth))
                {
                    var unmarshaller = ObjectReferenceUnmarshaller.Instance;
                    unmarshalledObject.TargetObjectReference = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TypedLinkFacet", targetDepth))
                {
                    var unmarshaller = TypedLinkSchemaAndFacetNameUnmarshaller.Instance;
                    unmarshalledObject.TypedLinkFacet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TypedLinkSpecifierUnmarshaller _instance = new TypedLinkSpecifierUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TypedLinkSpecifierUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}