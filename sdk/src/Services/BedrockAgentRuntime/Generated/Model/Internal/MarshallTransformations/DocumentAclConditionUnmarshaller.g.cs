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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DocumentAclCondition Object
    /// </summary>
    public partial class DocumentAclConditionUnmarshaller : IJsonUnmarshaller<DocumentAclCondition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DocumentAclCondition Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new DocumentAclCondition();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("conditionOperator", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConditionOperator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("groups", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DocumentAclGroup, DocumentAclGroupUnmarshaller>(DocumentAclGroupUnmarshaller.Instance);
                    unmarshalledObject.Groups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("users", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DocumentAclUser, DocumentAclUserUnmarshaller>(DocumentAclUserUnmarshaller.Instance);
                    unmarshalledObject.Users = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static DocumentAclConditionUnmarshaller _instance = new DocumentAclConditionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DocumentAclConditionUnmarshaller Instance => _instance;
    }
}
