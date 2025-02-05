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
    /// OutputUpdate Marshaller
    /// </summary>
    public class OutputUpdateMarshaller : IRequestMarshaller<OutputUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OutputUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationSchemaUpdate())
            {
                context.Writer.WritePropertyName("DestinationSchemaUpdate");
                context.Writer.WriteStartObject();

                var marshaller = DestinationSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationSchemaUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisFirehoseOutputUpdate())
            {
                context.Writer.WritePropertyName("KinesisFirehoseOutputUpdate");
                context.Writer.WriteStartObject();

                var marshaller = KinesisFirehoseOutputUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisFirehoseOutputUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisStreamsOutputUpdate())
            {
                context.Writer.WritePropertyName("KinesisStreamsOutputUpdate");
                context.Writer.WriteStartObject();

                var marshaller = KinesisStreamsOutputUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisStreamsOutputUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLambdaOutputUpdate())
            {
                context.Writer.WritePropertyName("LambdaOutputUpdate");
                context.Writer.WriteStartObject();

                var marshaller = LambdaOutputUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaOutputUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNameUpdate())
            {
                context.Writer.WritePropertyName("NameUpdate");
                context.Writer.WriteStringValue(requestObject.NameUpdate);
            }

            if(requestObject.IsSetOutputId())
            {
                context.Writer.WritePropertyName("OutputId");
                context.Writer.WriteStringValue(requestObject.OutputId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OutputUpdateMarshaller Instance = new OutputUpdateMarshaller();

    }
}