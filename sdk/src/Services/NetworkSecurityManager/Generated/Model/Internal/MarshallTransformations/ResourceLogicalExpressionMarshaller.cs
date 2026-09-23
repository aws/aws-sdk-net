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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkSecurityManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkSecurityManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceLogicalExpression Marshaller
    /// </summary>
    public class ResourceLogicalExpressionMarshaller : IRequestMarshaller<ResourceLogicalExpression, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceLogicalExpression requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnd())
            {
                context.Writer.WritePropertyName("and");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAndListValue in requestObject.And)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceLogicalExpressionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCriteria())
            {
                context.Writer.WritePropertyName("criteria");
                context.Writer.WriteStartObject();

                var marshaller = ResourceCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.Criteria, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNot())
            {
                context.Writer.WritePropertyName("not");
                context.Writer.WriteStartObject();

                var marshaller = ResourceLogicalExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.Not, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOr())
            {
                context.Writer.WritePropertyName("or");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOrListValue in requestObject.Or)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceLogicalExpressionMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceLogicalExpressionMarshaller Instance = new ResourceLogicalExpressionMarshaller();

    }
}