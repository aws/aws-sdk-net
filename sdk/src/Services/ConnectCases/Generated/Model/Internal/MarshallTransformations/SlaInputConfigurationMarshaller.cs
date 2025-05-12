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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SlaInputConfiguration Marshaller
    /// </summary>
    public class SlaInputConfigurationMarshaller : IRequestMarshaller<SlaInputConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SlaInputConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFieldId())
            {
                context.Writer.WritePropertyName("fieldId");
                context.Writer.WriteStringValue(requestObject.FieldId);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetTargetFieldValues())
            {
                context.Writer.WritePropertyName("targetFieldValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetFieldValuesListValue in requestObject.TargetFieldValues)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldValueUnionMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetFieldValuesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetSlaMinutes())
            {
                context.Writer.WritePropertyName("targetSlaMinutes");
                context.Writer.WriteNumberValue(requestObject.TargetSlaMinutes.Value);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SlaInputConfigurationMarshaller Instance = new SlaInputConfigurationMarshaller();

    }
}