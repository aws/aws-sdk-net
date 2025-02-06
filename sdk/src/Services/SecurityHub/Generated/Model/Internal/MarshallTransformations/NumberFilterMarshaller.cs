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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NumberFilter Marshaller
    /// </summary>
    public class NumberFilterMarshaller : IRequestMarshaller<NumberFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NumberFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEq())
            {
                context.Writer.WritePropertyName("Eq");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Eq.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Eq.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Eq.Value);
                }
            }

            if(requestObject.IsSetGt())
            {
                context.Writer.WritePropertyName("Gt");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Gt.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Gt.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Gt.Value);
                }
            }

            if(requestObject.IsSetGte())
            {
                context.Writer.WritePropertyName("Gte");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Gte.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Gte.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Gte.Value);
                }
            }

            if(requestObject.IsSetLt())
            {
                context.Writer.WritePropertyName("Lt");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Lt.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Lt.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Lt.Value);
                }
            }

            if(requestObject.IsSetLte())
            {
                context.Writer.WritePropertyName("Lte");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Lte.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Lte.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Lte.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NumberFilterMarshaller Instance = new NumberFilterMarshaller();

    }
}