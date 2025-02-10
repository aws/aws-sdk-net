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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ICD10CMEntity Object
    /// </summary>  
    public class ICD10CMEntityUnmarshaller : IJsonUnmarshaller<ICD10CMEntity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ICD10CMEntity Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ICD10CMEntity unmarshalledObject = new ICD10CMEntity();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Attributes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ICD10CMAttribute, ICD10CMAttributeUnmarshaller>(ICD10CMAttributeUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BeginOffset", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.BeginOffset = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Category", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Category = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndOffset", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.EndOffset = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ICD10CMConcepts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ICD10CMConcept, ICD10CMConceptUnmarshaller>(ICD10CMConceptUnmarshaller.Instance);
                    unmarshalledObject.ICD10CMConcepts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Score", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.Score = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Text", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Text = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Traits", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ICD10CMTrait, ICD10CMTraitUnmarshaller>(ICD10CMTraitUnmarshaller.Instance);
                    unmarshalledObject.Traits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ICD10CMEntityUnmarshaller _instance = new ICD10CMEntityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ICD10CMEntityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}