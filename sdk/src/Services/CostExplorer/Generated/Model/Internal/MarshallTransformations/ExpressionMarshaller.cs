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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Expression Marshaller
    /// </summary>       
    public class ExpressionMarshaller : IRequestMarshaller<Expression, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Expression requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAnd())
            {
                context.Writer.WritePropertyName("And");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAndListValue in requestObject.And)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCostCategories())
            {
                context.Writer.WritePropertyName("CostCategories");
                context.Writer.WriteObjectStart();

                var marshaller = CostCategoryValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.CostCategories, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteObjectStart();

                var marshaller = DimensionValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.Dimensions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNot())
            {
                context.Writer.WritePropertyName("Not");
                context.Writer.WriteObjectStart();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.Not, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOr())
            {
                context.Writer.WritePropertyName("Or");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrListValue in requestObject.Or)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteObjectStart();

                var marshaller = TagValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.Tags, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ExpressionMarshaller Instance = new ExpressionMarshaller();

    }
}