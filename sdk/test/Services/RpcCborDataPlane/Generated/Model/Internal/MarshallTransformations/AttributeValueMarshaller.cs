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

            var writer = context.ContentWriter;
            if (requestObject.IsSetB())
            {
                writer.WriteTextString("B");
                writer.WriteByteString(requestObject.B);
            }
            if (requestObject.IsSetBOOL())
            {
                writer.WriteTextString("BOOL");
                writer.WriteBoolean(requestObject.BOOL.Value);
            }
            if (requestObject.IsSetBS())
            {
                writer.WriteTextString("BS");
                writer.WriteStartArray(requestObject.BS.Count);
                foreach(var requestObjectBSListValue in requestObject.BS)
                {
                    writer.WriteByteString(requestObjectBSListValue);
                }
                writer.WriteEndArray();
            }
            if (requestObject.IsSetL())
            {
                writer.WriteTextString("L");
                writer.WriteStartArray(requestObject.L.Count);
                foreach(var requestObjectLListValue in requestObject.L)
                {
                    writer.WriteStartMap(AttributeValueMarshaller.Instance.CountSetMembers(requestObjectLListValue));

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectLListValue, context);

                    writer.WriteEndMap();
                }
                writer.WriteEndArray();
            }
            if (requestObject.IsSetM())
            {
                writer.WriteTextString("M");
                writer.WriteStartMap(requestObject.M.Count);
                foreach (var requestObjectMKvp in requestObject.M)
                {
                    writer.WriteTextString(requestObjectMKvp.Key);
                    var requestObjectMValue = requestObjectMKvp.Value;

                    writer.WriteStartMap(AttributeValueMarshaller.Instance.CountSetMembers(requestObjectMValue));

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectMValue, context);

                    writer.WriteEndMap();
                }
                writer.WriteEndMap();
            }
            if (requestObject.IsSetN())
            {
                writer.WriteTextString("N");
                writer.WriteTextString(requestObject.N);
            }
            if (requestObject.IsSetNS())
            {
                writer.WriteTextString("NS");
                writer.WriteStartArray(requestObject.NS.Count);
                foreach(var requestObjectNSListValue in requestObject.NS)
                {
                        writer.WriteTextString(requestObjectNSListValue);
                }
                writer.WriteEndArray();
            }
            if (requestObject.IsSetNULL())
            {
                writer.WriteTextString("NULL");
                writer.WriteBoolean(requestObject.NULL.Value);
            }
            if (requestObject.IsSetS())
            {
                writer.WriteTextString("S");
                writer.WriteTextString(requestObject.S);
            }
            if (requestObject.IsSetSS())
            {
                writer.WriteTextString("SS");
                writer.WriteStartArray(requestObject.SS.Count);
                foreach(var requestObjectSSListValue in requestObject.SS)
                {
                        writer.WriteTextString(requestObjectSSListValue);
                }
                writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Counts the set members this marshaller would write, so a caller can open a definite-length CBOR map.
        /// Must stay in lockstep with <see cref="Marshall"/>.
        /// </summary>
        public int CountSetMembers(AttributeValue requestObject)
        {
            if (requestObject == null)
                return 0;
            int count = 0;
            if (requestObject.IsSetB()) count++;
            if (requestObject.IsSetBOOL()) count++;
            if (requestObject.IsSetBS()) count++;
            if (requestObject.IsSetL()) count++;
            if (requestObject.IsSetM()) count++;
            if (requestObject.IsSetN()) count++;
            if (requestObject.IsSetNS()) count++;
            if (requestObject.IsSetNULL()) count++;
            if (requestObject.IsSetS()) count++;
            if (requestObject.IsSetSS()) count++;
            return count;
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AttributeValueMarshaller Instance = new AttributeValueMarshaller();

    }
}