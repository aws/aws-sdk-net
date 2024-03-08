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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JSONRPC10.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.JSONRPC10.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Defaults Marshaller
    /// </summary>
    public class DefaultsMarshaller : IRequestMarshaller<Defaults, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Defaults requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDefaultBlob())
            {
                context.Writer.WritePropertyName("defaultBlob");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.DefaultBlob));
            }

            if(requestObject.IsSetDefaultBoolean())
            {
                context.Writer.WritePropertyName("defaultBoolean");
                context.Writer.Write(requestObject.DefaultBoolean);
            }

            if(requestObject.IsSetDefaultByte())
            {
                context.Writer.WritePropertyName("defaultByte");
                context.Writer.Write(requestObject.DefaultByte);
            }

            if(requestObject.IsSetDefaultDocumentBoolean())
            {
                context.Writer.WritePropertyName("defaultDocumentBoolean");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.DefaultDocumentBoolean);
            }

            if(requestObject.IsSetDefaultDocumentList())
            {
                context.Writer.WritePropertyName("defaultDocumentList");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.DefaultDocumentList);
            }

            if(requestObject.IsSetDefaultDocumentMap())
            {
                context.Writer.WritePropertyName("defaultDocumentMap");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.DefaultDocumentMap);
            }

            if(requestObject.IsSetDefaultDocumentString())
            {
                context.Writer.WritePropertyName("defaultDocumentString");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.DefaultDocumentString);
            }

            if(requestObject.IsSetDefaultDouble())
            {
                context.Writer.WritePropertyName("defaultDouble");
                context.Writer.Write(requestObject.DefaultDouble);
            }

            if(requestObject.IsSetDefaultEnum())
            {
                context.Writer.WritePropertyName("defaultEnum");
                context.Writer.Write(requestObject.DefaultEnum);
            }

            if(requestObject.IsSetDefaultFloat())
            {
                context.Writer.WritePropertyName("defaultFloat");
                context.Writer.Write(requestObject.DefaultFloat);
            }

            if(requestObject.IsSetDefaultInteger())
            {
                context.Writer.WritePropertyName("defaultInteger");
                context.Writer.Write(requestObject.DefaultInteger);
            }

            if(requestObject.IsSetDefaultIntEnum())
            {
                context.Writer.WritePropertyName("defaultIntEnum");
                context.Writer.Write(requestObject.DefaultIntEnum);
            }

            if(requestObject.IsSetDefaultList())
            {
                context.Writer.WritePropertyName("defaultList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDefaultListListValue in requestObject.DefaultList)
                {
                        context.Writer.Write(requestObjectDefaultListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDefaultLong())
            {
                context.Writer.WritePropertyName("defaultLong");
                context.Writer.Write(requestObject.DefaultLong);
            }

            if(requestObject.IsSetDefaultMap())
            {
                context.Writer.WritePropertyName("defaultMap");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDefaultMapKvp in requestObject.DefaultMap)
                {
                    context.Writer.WritePropertyName(requestObjectDefaultMapKvp.Key);
                    var requestObjectDefaultMapValue = requestObjectDefaultMapKvp.Value;

                        context.Writer.Write(requestObjectDefaultMapValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultNullDocument())
            {
                context.Writer.WritePropertyName("defaultNullDocument");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.DefaultNullDocument);
            }

            if(requestObject.IsSetDefaultShort())
            {
                context.Writer.WritePropertyName("defaultShort");
                context.Writer.Write(requestObject.DefaultShort);
            }

            if(requestObject.IsSetDefaultString())
            {
                context.Writer.WritePropertyName("defaultString");
                context.Writer.Write(requestObject.DefaultString);
            }

            if(requestObject.IsSetDefaultTimestamp())
            {
                context.Writer.WritePropertyName("defaultTimestamp");
                context.Writer.Write(requestObject.DefaultTimestamp);
            }

            if(requestObject.IsSetEmptyBlob())
            {
                context.Writer.WritePropertyName("emptyBlob");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.EmptyBlob));
            }

            if(requestObject.IsSetEmptyString())
            {
                context.Writer.WritePropertyName("emptyString");
                context.Writer.Write(requestObject.EmptyString);
            }

            if(requestObject.IsSetFalseBoolean())
            {
                context.Writer.WritePropertyName("falseBoolean");
                context.Writer.Write(requestObject.FalseBoolean);
            }

            if(requestObject.IsSetZeroByte())
            {
                context.Writer.WritePropertyName("zeroByte");
                context.Writer.Write(requestObject.ZeroByte);
            }

            if(requestObject.IsSetZeroDouble())
            {
                context.Writer.WritePropertyName("zeroDouble");
                context.Writer.Write(requestObject.ZeroDouble);
            }

            if(requestObject.IsSetZeroFloat())
            {
                context.Writer.WritePropertyName("zeroFloat");
                context.Writer.Write(requestObject.ZeroFloat);
            }

            if(requestObject.IsSetZeroInteger())
            {
                context.Writer.WritePropertyName("zeroInteger");
                context.Writer.Write(requestObject.ZeroInteger);
            }

            if(requestObject.IsSetZeroLong())
            {
                context.Writer.WritePropertyName("zeroLong");
                context.Writer.Write(requestObject.ZeroLong);
            }

            if(requestObject.IsSetZeroShort())
            {
                context.Writer.WritePropertyName("zeroShort");
                context.Writer.Write(requestObject.ZeroShort);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DefaultsMarshaller Instance = new DefaultsMarshaller();

    }
}