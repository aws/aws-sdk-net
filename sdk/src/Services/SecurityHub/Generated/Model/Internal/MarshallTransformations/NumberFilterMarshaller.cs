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
using ThirdParty.Json.LitJson;

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
<<<<<<< HEAD
                context.Writer.Write(requestObject.Eq.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.Eq))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Eq));
                }
                else
                {
                    context.Writer.Write(requestObject.Eq);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetGt())
            {
                context.Writer.WritePropertyName("Gt");
<<<<<<< HEAD
                context.Writer.Write(requestObject.Gt.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.Gt))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Gt));
                }
                else
                {
                    context.Writer.Write(requestObject.Gt);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetGte())
            {
                context.Writer.WritePropertyName("Gte");
<<<<<<< HEAD
                context.Writer.Write(requestObject.Gte.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.Gte))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Gte));
                }
                else
                {
                    context.Writer.Write(requestObject.Gte);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetLt())
            {
                context.Writer.WritePropertyName("Lt");
<<<<<<< HEAD
                context.Writer.Write(requestObject.Lt.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.Lt))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Lt));
                }
                else
                {
                    context.Writer.Write(requestObject.Lt);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetLte())
            {
                context.Writer.WritePropertyName("Lte");
<<<<<<< HEAD
                context.Writer.Write(requestObject.Lte.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.Lte))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Lte));
                }
                else
                {
                    context.Writer.Write(requestObject.Lte);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NumberFilterMarshaller Instance = new NumberFilterMarshaller();

    }
}