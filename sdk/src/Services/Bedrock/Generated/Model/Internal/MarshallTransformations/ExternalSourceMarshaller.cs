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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExternalSource Marshaller
    /// </summary>
    public class ExternalSourceMarshaller : IRequestMarshaller<ExternalSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExternalSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetByteContent())
            {
                context.Writer.WritePropertyName("byteContent");
                context.Writer.WriteStartObject();

                var marshaller = ByteContentDocMarshaller.Instance;
                marshaller.Marshall(requestObject.ByteContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Location())
            {
                context.Writer.WritePropertyName("s3Location");
                context.Writer.WriteStartObject();

                var marshaller = S3ObjectDocMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Location, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("sourceType");
                context.Writer.WriteStringValue(requestObject.SourceType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExternalSourceMarshaller Instance = new ExternalSourceMarshaller();

    }
}