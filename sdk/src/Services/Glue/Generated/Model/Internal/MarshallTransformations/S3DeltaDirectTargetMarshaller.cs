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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3DeltaDirectTarget Marshaller
    /// </summary>
    public class S3DeltaDirectTargetMarshaller : IRequestMarshaller<S3DeltaDirectTarget, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3DeltaDirectTarget requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAdditionalOptions())
            {
                context.Writer.WritePropertyName("AdditionalOptions");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAdditionalOptionsKvp in requestObject.AdditionalOptions)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalOptionsKvp.Key);
                    var requestObjectAdditionalOptionsValue = requestObjectAdditionalOptionsKvp.Value;

                        context.Writer.Write(requestObjectAdditionalOptionsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCompression())
            {
                context.Writer.WritePropertyName("Compression");
                context.Writer.Write(requestObject.Compression);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.Write(requestObject.Format);
            }

            if(requestObject.IsSetInputs())
            {
                context.Writer.WritePropertyName("Inputs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputsListValue in requestObject.Inputs)
                {
                        context.Writer.Write(requestObjectInputsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPartitionKeys())
            {
                context.Writer.WritePropertyName("PartitionKeys");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPartitionKeysListValue in requestObject.PartitionKeys)
                {
                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectPartitionKeysListValueListValue in requestObjectPartitionKeysListValue)
                    {
                            context.Writer.Write(requestObjectPartitionKeysListValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("Path");
                context.Writer.Write(requestObject.Path);
            }

            if(requestObject.IsSetSchemaChangePolicy())
            {
                context.Writer.WritePropertyName("SchemaChangePolicy");
                context.Writer.WriteObjectStart();

                var marshaller = DirectSchemaChangePolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.SchemaChangePolicy, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3DeltaDirectTargetMarshaller Instance = new S3DeltaDirectTargetMarshaller();

    }
}