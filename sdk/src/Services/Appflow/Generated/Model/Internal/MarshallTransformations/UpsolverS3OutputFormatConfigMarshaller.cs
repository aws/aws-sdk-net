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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpsolverS3OutputFormatConfig Marshaller
    /// </summary>
    public class UpsolverS3OutputFormatConfigMarshaller : IRequestMarshaller<UpsolverS3OutputFormatConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpsolverS3OutputFormatConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggregationConfig())
            {
                context.Writer.WritePropertyName("aggregationConfig");
                context.Writer.WriteStartObject();

                var marshaller = AggregationConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AggregationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFileType())
            {
                context.Writer.WritePropertyName("fileType");
                context.Writer.WriteStringValue(requestObject.FileType);
            }

            if(requestObject.IsSetPrefixConfig())
            {
                context.Writer.WritePropertyName("prefixConfig");
                context.Writer.WriteStartObject();

                var marshaller = PrefixConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.PrefixConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpsolverS3OutputFormatConfigMarshaller Instance = new UpsolverS3OutputFormatConfigMarshaller();

    }
}