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
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalytics.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetDestinationSchema())
            {
                context.Writer.WritePropertyName("DestinationSchema");
                context.Writer.WriteObjectStart();

                var marshaller = DestinationSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationSchema, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesisFirehoseOutput())
            {
                context.Writer.WritePropertyName("KinesisFirehoseOutput");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisFirehoseOutputMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisFirehoseOutput, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesisStreamsOutput())
            {
                context.Writer.WritePropertyName("KinesisStreamsOutput");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisStreamsOutputMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisStreamsOutput, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLambdaOutput())
            {
                context.Writer.WritePropertyName("LambdaOutput");
                context.Writer.WriteObjectStart();

                var marshaller = LambdaOutputMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaOutput, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OutputMarshaller Instance = new OutputMarshaller();

    }
}