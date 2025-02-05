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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GrantListEntry Object
    /// </summary>  
    public class GrantListEntryUnmarshaller : IJsonUnmarshaller<GrantListEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GrantListEntry Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GrantListEntry unmarshalledObject = new GrantListEntry();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Constraints", targetDepth))
                {
                    var unmarshaller = GrantConstraintsUnmarshaller.Instance;
                    unmarshalledObject.Constraints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GranteePrincipal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GranteePrincipal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GrantId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GrantId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IssuingAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IssuingAccount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Operations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Operations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RetiringPrincipal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RetiringPrincipal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GrantListEntryUnmarshaller _instance = new GrantListEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GrantListEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}