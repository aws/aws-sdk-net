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
 * Do not modify this file. This file is generated from the numerictypescbor-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesCbor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesCbor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NestedNumbers Marshaller
    /// </summary>
    public class NestedNumbersMarshaller : IRequestMarshaller<NestedNumbers, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NestedNumbers requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetBigDecimalValue())
            {
                context.Writer.WriteTextString("BigDecimalValue");
                context.Writer.WriteBigDecimal(requestObject.BigDecimalValue.Value);
            }
            if (requestObject.IsSetBigIntegerValue())
            {
                context.Writer.WriteTextString("BigIntegerValue");
                context.Writer.WriteBigInteger(requestObject.BigIntegerValue.Value);
            }
            if (requestObject.IsSetByteValue())
            {
                context.Writer.WriteTextString("ByteValue");
                context.Writer.WriteInt32(requestObject.ByteValue.Value);
            }
            if (requestObject.IsSetShortValue())
            {
                context.Writer.WriteTextString("ShortValue");
                context.Writer.WriteInt32(requestObject.ShortValue.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NestedNumbersMarshaller Instance = new NestedNumbersMarshaller();

    }
}