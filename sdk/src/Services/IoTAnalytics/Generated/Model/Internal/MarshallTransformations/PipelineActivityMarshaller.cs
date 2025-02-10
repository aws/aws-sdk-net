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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipelineActivity Marshaller
    /// </summary>
    public class PipelineActivityMarshaller : IRequestMarshaller<PipelineActivity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipelineActivity requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddAttributes())
            {
                context.Writer.WritePropertyName("addAttributes");
                context.Writer.WriteStartObject();

                var marshaller = AddAttributesActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.AddAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetChannel())
            {
                context.Writer.WritePropertyName("channel");
                context.Writer.WriteStartObject();

                var marshaller = ChannelActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.Channel, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatastore())
            {
                context.Writer.WritePropertyName("datastore");
                context.Writer.WriteStartObject();

                var marshaller = DatastoreActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.Datastore, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeviceRegistryEnrich())
            {
                context.Writer.WritePropertyName("deviceRegistryEnrich");
                context.Writer.WriteStartObject();

                var marshaller = DeviceRegistryEnrichActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.DeviceRegistryEnrich, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeviceShadowEnrich())
            {
                context.Writer.WritePropertyName("deviceShadowEnrich");
                context.Writer.WriteStartObject();

                var marshaller = DeviceShadowEnrichActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.DeviceShadowEnrich, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("filter");
                context.Writer.WriteStartObject();

                var marshaller = FilterActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLambda())
            {
                context.Writer.WritePropertyName("lambda");
                context.Writer.WriteStartObject();

                var marshaller = LambdaActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.Lambda, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMath())
            {
                context.Writer.WritePropertyName("math");
                context.Writer.WriteStartObject();

                var marshaller = MathActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.Math, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRemoveAttributes())
            {
                context.Writer.WritePropertyName("removeAttributes");
                context.Writer.WriteStartObject();

                var marshaller = RemoveAttributesActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.RemoveAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSelectAttributes())
            {
                context.Writer.WritePropertyName("selectAttributes");
                context.Writer.WriteStartObject();

                var marshaller = SelectAttributesActivityMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectAttributes, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipelineActivityMarshaller Instance = new PipelineActivityMarshaller();

    }
}