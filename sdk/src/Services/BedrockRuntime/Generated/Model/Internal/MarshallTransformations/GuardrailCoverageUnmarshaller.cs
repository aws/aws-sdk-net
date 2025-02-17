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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GuardrailCoverage Object
    /// </summary>  
    public class GuardrailCoverageUnmarshaller : IUnmarshaller<GuardrailCoverage, XmlUnmarshallerContext>, IUnmarshaller<GuardrailCoverage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GuardrailCoverage IUnmarshaller<GuardrailCoverage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GuardrailCoverage Unmarshall(JsonUnmarshallerContext context)
        {
            GuardrailCoverage unmarshalledObject = new GuardrailCoverage();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("images", targetDepth))
                {
                    var unmarshaller = GuardrailImageCoverageUnmarshaller.Instance;
                    unmarshalledObject.Images = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("textCharacters", targetDepth))
                {
                    var unmarshaller = GuardrailTextCharactersCoverageUnmarshaller.Instance;
                    unmarshalledObject.TextCharacters = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GuardrailCoverageUnmarshaller _instance = new GuardrailCoverageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GuardrailCoverageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}