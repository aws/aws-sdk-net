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
    /// S3Destination Marshaller
    /// </summary>
    public class S3DestinationMarshaller : IRequestMarshaller<S3Destination, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3Destination requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.WriteStringValue(requestObject.S3Bucket);
            }

            if(requestObject.IsSetS3OutputConfigurations())
            {
                context.Writer.WritePropertyName("S3OutputConfigurations");
                context.Writer.WriteStartObject();

                var marshaller = S3OutputConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.S3OutputConfigurations, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Prefix())
            {
                context.Writer.WritePropertyName("S3Prefix");
                context.Writer.WriteStringValue(requestObject.S3Prefix);
            }

            if(requestObject.IsSetS3Region())
            {
                context.Writer.WritePropertyName("S3Region");
                context.Writer.WriteStringValue(requestObject.S3Region);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3DestinationMarshaller Instance = new S3DestinationMarshaller();

    }
}