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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TsvStoreOptions Marshaller
    /// </summary>
    public class TsvStoreOptionsMarshaller : IRequestMarshaller<TsvStoreOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TsvStoreOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAnnotationType())
            {
                context.Writer.WritePropertyName("annotationType");
                context.Writer.Write(requestObject.AnnotationType);
            }

            if(requestObject.IsSetFormatToHeader())
            {
                context.Writer.WritePropertyName("formatToHeader");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectFormatToHeaderKvp in requestObject.FormatToHeader)
                {
                    context.Writer.WritePropertyName(requestObjectFormatToHeaderKvp.Key);
                    var requestObjectFormatToHeaderValue = requestObjectFormatToHeaderKvp.Value;

                        context.Writer.Write(requestObjectFormatToHeaderValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSchema())
            {
                context.Writer.WritePropertyName("schema");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSchemaListValue in requestObject.Schema)
                {
                    context.Writer.WriteObjectStart();
                    foreach (var requestObjectSchemaListValueKvp in requestObjectSchemaListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectSchemaListValueKvp.Key);
                        var requestObjectSchemaListValueValue = requestObjectSchemaListValueKvp.Value;

                            context.Writer.Write(requestObjectSchemaListValueValue);
                    }
                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TsvStoreOptionsMarshaller Instance = new TsvStoreOptionsMarshaller();

    }
}