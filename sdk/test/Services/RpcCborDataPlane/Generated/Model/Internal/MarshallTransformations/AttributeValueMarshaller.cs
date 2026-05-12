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
    /// AttributeValue Marshaller
    /// </summary>
    public class AttributeValueMarshaller : IRequestMarshaller<AttributeValue, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AttributeValue requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetB())
            {
                context.Writer.WriteTextString("B");
                context.Writer.WriteByteString(requestObject.B.ToArray());
            }
            if (requestObject.IsSetBOOL())
            {
                context.Writer.WriteTextString("BOOL");
                context.Writer.WriteBoolean(requestObject.BOOL.Value);
            }
            if (requestObject.IsSetBS())
            {
                context.Writer.WriteTextString("BS");
                context.Writer.WriteStartArray(requestObject.BS.Count);
                foreach(var requestObjectBSListValue in requestObject.BS)
                {
                    context.Writer.WriteByteString(requestObjectBSListValue.ToArray());
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetL())
            {
                context.Writer.WriteTextString("L");
                context.Writer.WriteStartArray(requestObject.L.Count);
                foreach(var requestObjectLListValue in requestObject.L)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectLListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetM())
            {
                context.Writer.WriteTextString("M");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectMKvp in requestObject.M)
                {
                    context.Writer.WriteTextString(requestObjectMKvp.Key);
                    var requestObjectMValue = requestObjectMKvp.Value;

                    context.Writer.WriteStartMap(null);

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectMValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetN())
            {
                context.Writer.WriteTextString("N");
                context.Writer.WriteTextString(requestObject.N);
            }
            if (requestObject.IsSetNS())
            {
                context.Writer.WriteTextString("NS");
                context.Writer.WriteStartArray(requestObject.NS.Count);
                foreach(var requestObjectNSListValue in requestObject.NS)
                {
                        context.Writer.WriteTextString(requestObjectNSListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetNULL())
            {
                context.Writer.WriteTextString("NULL");
                context.Writer.WriteBoolean(requestObject.NULL.Value);
            }
            if (requestObject.IsSetS())
            {
                context.Writer.WriteTextString("S");
                context.Writer.WriteTextString(requestObject.S);
            }
            if (requestObject.IsSetSS())
            {
                context.Writer.WriteTextString("SS");
                context.Writer.WriteStartArray(requestObject.SS.Count);
                foreach(var requestObjectSSListValue in requestObject.SS)
                {
                        context.Writer.WriteTextString(requestObjectSSListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AttributeValueMarshaller Instance = new AttributeValueMarshaller();

    }
}