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
 * Do not modify this file. This file is generated from the rpccbordataplane-1999-12-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RpcCborDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.RpcCborDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExpectedAttributeValue Marshaller
    /// </summary>
    public class ExpectedAttributeValueMarshaller : IRequestMarshaller<ExpectedAttributeValue, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExpectedAttributeValue requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAttributeValueList())
            {
                context.Writer.WriteTextString("AttributeValueList");
                context.Writer.WriteStartArray(requestObject.AttributeValueList.Count);
                foreach(var requestObjectAttributeValueListListValue in requestObject.AttributeValueList)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributeValueListListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetComparisonOperator())
            {
                context.Writer.WriteTextString("ComparisonOperator");
                context.Writer.WriteTextString(requestObject.ComparisonOperator);
            }
            if (requestObject.IsSetExists())
            {
                context.Writer.WriteTextString("Exists");
                context.Writer.WriteBoolean(requestObject.Exists.Value);
            }
            if (requestObject.IsSetValue())
            {
                context.Writer.WriteTextString("Value");
                context.Writer.WriteStartMap(null);

                var marshaller = AttributeValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Value, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExpectedAttributeValueMarshaller Instance = new ExpectedAttributeValueMarshaller();

    }
}