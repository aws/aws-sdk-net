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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SegmentAttributeValue Marshaller
    /// </summary>
    public class SegmentAttributeValueMarshaller : IRequestMarshaller<SegmentAttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SegmentAttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetValueArn())
            {
                context.Writer.WritePropertyName("ValueArn");
                context.Writer.WriteStringValue(requestObject.ValueArn);
            }

            if(requestObject.IsSetValueInteger())
            {
                context.Writer.WritePropertyName("ValueInteger");
                context.Writer.WriteNumberValue(requestObject.ValueInteger.Value);
            }

            if(requestObject.IsSetValueList())
            {
                context.Writer.WritePropertyName("ValueList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectValueListListValue in requestObject.ValueList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SegmentAttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectValueListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetValueMap())
            {
                context.Writer.WritePropertyName("ValueMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectValueMapKvp in requestObject.ValueMap)
                {
                    context.Writer.WritePropertyName(requestObjectValueMapKvp.Key);
                    var requestObjectValueMapValue = requestObjectValueMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SegmentAttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectValueMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetValueString())
            {
                context.Writer.WritePropertyName("ValueString");
                context.Writer.WriteStringValue(requestObject.ValueString);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SegmentAttributeValueMarshaller Instance = new SegmentAttributeValueMarshaller();

    }
}