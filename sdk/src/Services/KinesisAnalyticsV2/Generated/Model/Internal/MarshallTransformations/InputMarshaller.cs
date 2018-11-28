/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Input Marshaller
    /// </summary>       
    public class InputMarshaller : IRequestMarshaller<Input, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Input requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInputParallelism())
            {
                context.Writer.WritePropertyName("InputParallelism");
                context.Writer.WriteObjectStart();

                var marshaller = InputParallelismMarshaller.Instance;
                marshaller.Marshall(requestObject.InputParallelism, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputProcessingConfiguration())
            {
                context.Writer.WritePropertyName("InputProcessingConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = InputProcessingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.InputProcessingConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputSchema())
            {
                context.Writer.WritePropertyName("InputSchema");
                context.Writer.WriteObjectStart();

                var marshaller = SourceSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.InputSchema, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesisFirehoseInput())
            {
                context.Writer.WritePropertyName("KinesisFirehoseInput");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisFirehoseInputMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisFirehoseInput, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesisStreamsInput())
            {
                context.Writer.WritePropertyName("KinesisStreamsInput");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisStreamsInputMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisStreamsInput, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNamePrefix())
            {
                context.Writer.WritePropertyName("NamePrefix");
                context.Writer.Write(requestObject.NamePrefix);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InputMarshaller Instance = new InputMarshaller();

    }
}