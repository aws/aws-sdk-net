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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// X12CodeListValidationRule Marshaller
    /// </summary>
    public class X12CodeListValidationRuleMarshaller : IRequestMarshaller<X12CodeListValidationRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(X12CodeListValidationRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCodesToAdd())
            {
                context.Writer.WritePropertyName("codesToAdd");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodesToAddListValue in requestObject.CodesToAdd)
                {
                        context.Writer.WriteStringValue(requestObjectCodesToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodesToRemove())
            {
                context.Writer.WritePropertyName("codesToRemove");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodesToRemoveListValue in requestObject.CodesToRemove)
                {
                        context.Writer.WriteStringValue(requestObjectCodesToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetElementId())
            {
                context.Writer.WritePropertyName("elementId");
                context.Writer.WriteStringValue(requestObject.ElementId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static X12CodeListValidationRuleMarshaller Instance = new X12CodeListValidationRuleMarshaller();

    }
}