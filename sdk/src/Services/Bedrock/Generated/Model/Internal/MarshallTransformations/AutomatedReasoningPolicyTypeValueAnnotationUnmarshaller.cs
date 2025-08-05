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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutomatedReasoningPolicyTypeValueAnnotation Object
    /// </summary>  
    public class AutomatedReasoningPolicyTypeValueAnnotationUnmarshaller : IUnmarshaller<AutomatedReasoningPolicyTypeValueAnnotation, XmlUnmarshallerContext>, IUnmarshaller<AutomatedReasoningPolicyTypeValueAnnotation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutomatedReasoningPolicyTypeValueAnnotation IUnmarshaller<AutomatedReasoningPolicyTypeValueAnnotation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutomatedReasoningPolicyTypeValueAnnotation Unmarshall(JsonUnmarshallerContext context)
        {
            AutomatedReasoningPolicyTypeValueAnnotation unmarshalledObject = new AutomatedReasoningPolicyTypeValueAnnotation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("addTypeValue", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyAddTypeValueUnmarshaller.Instance;
                    unmarshalledObject.AddTypeValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deleteTypeValue", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyDeleteTypeValueUnmarshaller.Instance;
                    unmarshalledObject.DeleteTypeValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateTypeValue", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyUpdateTypeValueUnmarshaller.Instance;
                    unmarshalledObject.UpdateTypeValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutomatedReasoningPolicyTypeValueAnnotationUnmarshaller _instance = new AutomatedReasoningPolicyTypeValueAnnotationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomatedReasoningPolicyTypeValueAnnotationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}