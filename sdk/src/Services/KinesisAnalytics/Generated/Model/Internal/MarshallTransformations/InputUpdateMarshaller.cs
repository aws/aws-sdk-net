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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalytics.Model.Internal.MarshallTransformations
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetInputId())
            {
                context.Writer.WritePropertyName("InputId");
                context.Writer.WriteStringValue(requestObject.InputId);
            }

            if(requestObject.IsSetInputParallelismUpdate())
            {
                context.Writer.WritePropertyName("InputParallelismUpdate");
                context.Writer.WriteStartObject();

                var marshaller = InputParallelismUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.InputParallelismUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputProcessingConfigurationUpdate())
            {
                context.Writer.WritePropertyName("InputProcessingConfigurationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = InputProcessingConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.InputProcessingConfigurationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputSchemaUpdate())
            {
                context.Writer.WritePropertyName("InputSchemaUpdate");
                context.Writer.WriteStartObject();

                var marshaller = InputSchemaUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.InputSchemaUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisFirehoseInputUpdate())
            {
                context.Writer.WritePropertyName("KinesisFirehoseInputUpdate");
                context.Writer.WriteStartObject();

                var marshaller = KinesisFirehoseInputUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisFirehoseInputUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisStreamsInputUpdate())
            {
                context.Writer.WritePropertyName("KinesisStreamsInputUpdate");
                context.Writer.WriteStartObject();

                var marshaller = KinesisStreamsInputUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisStreamsInputUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNamePrefixUpdate())
            {
                context.Writer.WritePropertyName("NamePrefixUpdate");
                context.Writer.WriteStringValue(requestObject.NamePrefixUpdate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputUpdateMarshaller Instance = new InputUpdateMarshaller();

    }
}