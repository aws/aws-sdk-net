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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LFTagPolicyResource Marshaller
    /// </summary>
    public class LFTagPolicyResourceMarshaller : IRequestMarshaller<LFTagPolicyResource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LFTagPolicyResource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCatalogId())
            {
                context.Writer.WritePropertyName("CatalogId");
                context.Writer.WriteStringValue(requestObject.CatalogId);
            }

            if(requestObject.IsSetExpression())
            {
                context.Writer.WritePropertyName("Expression");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExpressionListValue in requestObject.Expression)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LFTagMarshaller.Instance;
                    marshaller.Marshall(requestObjectExpressionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExpressionName())
            {
                context.Writer.WritePropertyName("ExpressionName");
                context.Writer.WriteStringValue(requestObject.ExpressionName);
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteStringValue(requestObject.ResourceType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LFTagPolicyResourceMarshaller Instance = new LFTagPolicyResourceMarshaller();

    }
}