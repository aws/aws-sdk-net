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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FieldValueUnion Marshaller
    /// </summary>
    public class FieldValueUnionMarshaller : IRequestMarshaller<FieldValueUnion, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FieldValueUnion requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBooleanValue())
            {
                context.Writer.WritePropertyName("booleanValue");
                context.Writer.Write(requestObject.BooleanValue);
            }

            if(requestObject.IsSetDoubleValue())
            {
                context.Writer.WritePropertyName("doubleValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.DoubleValue))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.DoubleValue));
                }
                else
                {
                    context.Writer.Write(requestObject.DoubleValue);
                }
            }

            if(requestObject.IsSetEmptyValue())
            {
                context.Writer.WritePropertyName("emptyValue");
                context.Writer.WriteObjectStart();

                var marshaller = EmptyFieldValueMarshaller.Instance;
                marshaller.Marshall(requestObject.EmptyValue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("stringValue");
                context.Writer.Write(requestObject.StringValue);
            }

            if(requestObject.IsSetUserArnValue())
            {
                context.Writer.WritePropertyName("userArnValue");
                context.Writer.Write(requestObject.UserArnValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldValueUnionMarshaller Instance = new FieldValueUnionMarshaller();

    }
}
#pragma warning restore CS0612,CS0618