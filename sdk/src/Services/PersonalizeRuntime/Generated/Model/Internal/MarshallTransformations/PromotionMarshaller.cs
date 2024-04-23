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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PersonalizeRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PersonalizeRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Promotion Marshaller
    /// </summary>
    public class PromotionMarshaller : IRequestMarshaller<Promotion, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Promotion requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFilterArn())
            {
                context.Writer.WritePropertyName("filterArn");
                context.Writer.Write(requestObject.FilterArn);
            }

            if(requestObject.IsSetFilterValues())
            {
                context.Writer.WritePropertyName("filterValues");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectFilterValuesKvp in requestObject.FilterValues)
                {
                    context.Writer.WritePropertyName(requestObjectFilterValuesKvp.Key);
                    var requestObjectFilterValuesValue = requestObjectFilterValuesKvp.Value;

                        context.Writer.Write(requestObjectFilterValuesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPercentPromotedItems())
            {
                context.Writer.WritePropertyName("percentPromotedItems");
                context.Writer.Write(requestObject.PercentPromotedItems);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PromotionMarshaller Instance = new PromotionMarshaller();

    }
}
#pragma warning restore CS0612,CS0618