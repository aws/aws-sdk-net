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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodegenGenericDataRelationshipType Object
    /// </summary>  
    public class CodegenGenericDataRelationshipTypeUnmarshaller : IUnmarshaller<CodegenGenericDataRelationshipType, XmlUnmarshallerContext>, IUnmarshaller<CodegenGenericDataRelationshipType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CodegenGenericDataRelationshipType IUnmarshaller<CodegenGenericDataRelationshipType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CodegenGenericDataRelationshipType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CodegenGenericDataRelationshipType unmarshalledObject = new CodegenGenericDataRelationshipType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("associatedFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AssociatedFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("belongsToFieldOnRelatedModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BelongsToFieldOnRelatedModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("canUnlinkAssociatedModel", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CanUnlinkAssociatedModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isHasManyIndex", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsHasManyIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relatedJoinFieldName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelatedJoinFieldName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relatedJoinTableName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelatedJoinTableName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relatedModelFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RelatedModelFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relatedModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelatedModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CodegenGenericDataRelationshipTypeUnmarshaller _instance = new CodegenGenericDataRelationshipTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CodegenGenericDataRelationshipTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}