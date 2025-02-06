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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HyperParameterRanges Marshaller
    /// </summary>
    public class HyperParameterRangesMarshaller : IRequestMarshaller<HyperParameterRanges, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HyperParameterRanges requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCategoricalHyperParameterRanges())
            {
                context.Writer.WritePropertyName("categoricalHyperParameterRanges");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCategoricalHyperParameterRangesListValue in requestObject.CategoricalHyperParameterRanges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CategoricalHyperParameterRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectCategoricalHyperParameterRangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContinuousHyperParameterRanges())
            {
                context.Writer.WritePropertyName("continuousHyperParameterRanges");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContinuousHyperParameterRangesListValue in requestObject.ContinuousHyperParameterRanges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContinuousHyperParameterRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectContinuousHyperParameterRangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIntegerHyperParameterRanges())
            {
                context.Writer.WritePropertyName("integerHyperParameterRanges");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIntegerHyperParameterRangesListValue in requestObject.IntegerHyperParameterRanges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IntegerHyperParameterRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectIntegerHyperParameterRangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HyperParameterRangesMarshaller Instance = new HyperParameterRangesMarshaller();

    }
}