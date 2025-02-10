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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VerifiedPermissions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContextDefinition Marshaller
    /// </summary>
    public class ContextDefinitionMarshaller : IRequestMarshaller<ContextDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContextDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCedarJson())
            {
                context.Writer.WritePropertyName("cedarJson");
                context.Writer.WriteStringValue(requestObject.CedarJson);
            }

            if(requestObject.IsSetContextMap())
            {
                context.Writer.WritePropertyName("contextMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectContextMapKvp in requestObject.ContextMap)
                {
                    context.Writer.WritePropertyName(requestObjectContextMapKvp.Key);
                    var requestObjectContextMapValue = requestObjectContextMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectContextMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContextDefinitionMarshaller Instance = new ContextDefinitionMarshaller();

    }
}