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
    /// InputUpdate Marshaller
    /// </summary>       
    public class InputUpdateMarshaller : IRequestMarshaller<InputUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InputUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInputId())
            {
                context.Writer.WritePropertyName("InputId");
                context.Writer.Write(requestObject.InputId);
            }

            if(requestObject.IsSetInputParallelismUpdate())
            {
                context.Writer.WritePropertyName("InputParallelismUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = InputParallelismUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.InputParallelismUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputProcessingConfigurationUpdate())
            {
                context.Writer.WritePropertyName("InputProcessingConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = InputProcessingConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.InputProcessingConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputSchemaUpdate())
            {
                context.Writer.WritePropertyName("InputSchemaUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = InputSchemaUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.InputSchemaUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesisFirehoseInputUpdate())
            {
                context.Writer.WritePropertyName("KinesisFirehoseInputUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisFirehoseInputUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisFirehoseInputUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesisStreamsInputUpdate())
            {
                context.Writer.WritePropertyName("KinesisStreamsInputUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisStreamsInputUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisStreamsInputUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNamePrefixUpdate())
            {
                context.Writer.WritePropertyName("NamePrefixUpdate");
                context.Writer.Write(requestObject.NamePrefixUpdate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InputUpdateMarshaller Instance = new InputUpdateMarshaller();

    }
}