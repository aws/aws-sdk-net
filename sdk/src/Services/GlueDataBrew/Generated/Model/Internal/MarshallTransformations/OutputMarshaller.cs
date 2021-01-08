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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Output Marshaller
    /// </summary>       
    public class OutputMarshaller : IRequestMarshaller<Output, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Output requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCompressionFormat())
            {
                context.Writer.WritePropertyName("CompressionFormat");
                context.Writer.Write(requestObject.CompressionFormat);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.Write(requestObject.Format);
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("Location");
                context.Writer.WriteObjectStart();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(requestObject.Location, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOverwrite())
            {
                context.Writer.WritePropertyName("Overwrite");
                context.Writer.Write(requestObject.Overwrite);
            }

            if(requestObject.IsSetPartitionColumns())
            {
                context.Writer.WritePropertyName("PartitionColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPartitionColumnsListValue in requestObject.PartitionColumns)
                {
                        context.Writer.Write(requestObjectPartitionColumnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OutputMarshaller Instance = new OutputMarshaller();

    }
}