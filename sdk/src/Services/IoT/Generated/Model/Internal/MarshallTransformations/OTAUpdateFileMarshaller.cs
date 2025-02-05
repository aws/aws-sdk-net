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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OTAUpdateFile Marshaller
    /// </summary>
    public class OTAUpdateFileMarshaller : IRequestMarshaller<OTAUpdateFile, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OTAUpdateFile requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCodeSigning())
            {
                context.Writer.WritePropertyName("codeSigning");
                context.Writer.WriteStartObject();

                var marshaller = CodeSigningMarshaller.Instance;
                marshaller.Marshall(requestObject.CodeSigning, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFileLocation())
            {
                context.Writer.WritePropertyName("fileLocation");
                context.Writer.WriteStartObject();

                var marshaller = FileLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.FileLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFileName())
            {
                context.Writer.WritePropertyName("fileName");
                context.Writer.WriteStringValue(requestObject.FileName);
            }

            if(requestObject.IsSetFileType())
            {
                context.Writer.WritePropertyName("fileType");
                context.Writer.WriteNumberValue(requestObject.FileType.Value);
            }

            if(requestObject.IsSetFileVersion())
            {
                context.Writer.WritePropertyName("fileVersion");
                context.Writer.WriteStringValue(requestObject.FileVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OTAUpdateFileMarshaller Instance = new OTAUpdateFileMarshaller();

    }
}