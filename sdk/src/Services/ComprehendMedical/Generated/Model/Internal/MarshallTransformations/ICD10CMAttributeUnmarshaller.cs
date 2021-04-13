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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComprehendMedical.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ICD10CMAttribute Object
    /// </summary>  
    public class ICD10CMAttributeUnmarshaller : IUnmarshaller<ICD10CMAttribute, XmlUnmarshallerContext>, IUnmarshaller<ICD10CMAttribute, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ICD10CMAttribute IUnmarshaller<ICD10CMAttribute, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ICD10CMAttribute Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ICD10CMAttribute unmarshalledObject = new ICD10CMAttribute();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BeginOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BeginOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Category", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Category = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EndOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelationshipScore", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.RelationshipScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelationshipType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelationshipType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Score", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Score = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Text", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Text = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Traits", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ICD10CMTrait, ICD10CMTraitUnmarshaller>(ICD10CMTraitUnmarshaller.Instance);
                    unmarshalledObject.Traits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ICD10CMAttributeUnmarshaller _instance = new ICD10CMAttributeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ICD10CMAttributeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}