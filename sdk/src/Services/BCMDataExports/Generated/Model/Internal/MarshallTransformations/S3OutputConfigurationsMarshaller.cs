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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMDataExports.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMDataExports.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3OutputConfigurations Marshaller
    /// </summary>
    public class S3OutputConfigurationsMarshaller : IRequestMarshaller<S3OutputConfigurations, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3OutputConfigurations requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCompression())
            {
                context.Writer.WritePropertyName("Compression");
                context.Writer.WriteStringValue(requestObject.Compression);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.WriteStringValue(requestObject.Format);
            }

            if(requestObject.IsSetOutputType())
            {
                context.Writer.WritePropertyName("OutputType");
                context.Writer.WriteStringValue(requestObject.OutputType);
            }

            if(requestObject.IsSetOverwrite())
            {
                context.Writer.WritePropertyName("Overwrite");
                context.Writer.WriteStringValue(requestObject.Overwrite);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3OutputConfigurationsMarshaller Instance = new S3OutputConfigurationsMarshaller();

    }
}