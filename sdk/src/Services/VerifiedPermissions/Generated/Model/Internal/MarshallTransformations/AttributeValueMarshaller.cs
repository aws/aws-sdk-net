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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VerifiedPermissions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AttributeValue Marshaller
    /// </summary>
    public class AttributeValueMarshaller : IRequestMarshaller<AttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBoolean())
            {
                context.Writer.WritePropertyName("boolean");
                context.Writer.Write(requestObject.Boolean);
            }

            if(requestObject.IsSetDatetime())
            {
                context.Writer.WritePropertyName("datetime");
                context.Writer.Write(requestObject.Datetime);
            }

            if(requestObject.IsSetDecimal())
            {
                context.Writer.WritePropertyName("decimal");
                context.Writer.Write(requestObject.Decimal);
            }

            if(requestObject.IsSetDuration())
            {
                context.Writer.WritePropertyName("duration");
                context.Writer.Write(requestObject.Duration);
            }

            if(requestObject.IsSetEntityIdentifier())
            {
                context.Writer.WritePropertyName("entityIdentifier");
                context.Writer.WriteObjectStart();

                var marshaller = EntityIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityIdentifier, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIpaddr())
            {
                context.Writer.WritePropertyName("ipaddr");
                context.Writer.Write(requestObject.Ipaddr);
            }

            if(requestObject.IsSetLong())
            {
                context.Writer.WritePropertyName("long");
                context.Writer.Write(requestObject.Long);
            }

            if(requestObject.IsSetRecord())
            {
                context.Writer.WritePropertyName("record");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRecordKvp in requestObject.Record)
                {
                    context.Writer.WritePropertyName(requestObjectRecordKvp.Key);
                    var requestObjectRecordValue = requestObjectRecordKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecordValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSet())
            {
                context.Writer.WritePropertyName("set");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSetListValue in requestObject.Set)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectSetListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetString())
            {
                context.Writer.WritePropertyName("string");
                context.Writer.Write(requestObject.String);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AttributeValueMarshaller Instance = new AttributeValueMarshaller();

    }
}