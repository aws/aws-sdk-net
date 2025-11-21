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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConversionTarget Marshaller
    /// </summary>
    public class ConversionTargetMarshaller : IRequestMarshaller<ConversionTarget, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConversionTarget requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdvancedOptions())
            {
                context.Writer.WritePropertyName("advancedOptions");
                context.Writer.WriteStartObject();

                var marshaller = AdvancedOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.AdvancedOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFileFormat())
            {
                context.Writer.WritePropertyName("fileFormat");
                context.Writer.WriteStringValue(requestObject.FileFormat);
            }

            if(requestObject.IsSetFormatDetails())
            {
                context.Writer.WritePropertyName("formatDetails");
                context.Writer.WriteStartObject();

                var marshaller = ConversionTargetFormatDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.FormatDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputSampleFile())
            {
                context.Writer.WritePropertyName("outputSampleFile");
                context.Writer.WriteStartObject();

                var marshaller = OutputSampleFileSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputSampleFile, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConversionTargetMarshaller Instance = new ConversionTargetMarshaller();

    }
}