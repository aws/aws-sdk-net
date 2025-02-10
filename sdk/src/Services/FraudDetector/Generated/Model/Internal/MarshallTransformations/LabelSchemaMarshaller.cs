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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LabelSchema Marshaller
    /// </summary>
    public class LabelSchemaMarshaller : IRequestMarshaller<LabelSchema, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LabelSchema requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLabelMapper())
            {
                context.Writer.WritePropertyName("labelMapper");
                context.Writer.WriteStartObject();
                foreach (var requestObjectLabelMapperKvp in requestObject.LabelMapper)
                {
                    context.Writer.WritePropertyName(requestObjectLabelMapperKvp.Key);
                    var requestObjectLabelMapperValue = requestObjectLabelMapperKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectLabelMapperValueListValue in requestObjectLabelMapperValue)
                    {
                            context.Writer.WriteStringValue(requestObjectLabelMapperValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUnlabeledEventsTreatment())
            {
                context.Writer.WritePropertyName("unlabeledEventsTreatment");
                context.Writer.WriteStringValue(requestObject.UnlabeledEventsTreatment);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LabelSchemaMarshaller Instance = new LabelSchemaMarshaller();

    }
}