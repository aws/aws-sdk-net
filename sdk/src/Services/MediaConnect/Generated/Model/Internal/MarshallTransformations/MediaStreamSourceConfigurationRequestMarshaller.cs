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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MediaStreamSourceConfigurationRequest Marshaller
    /// </summary>
    public class MediaStreamSourceConfigurationRequestMarshaller : IRequestMarshaller<MediaStreamSourceConfigurationRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MediaStreamSourceConfigurationRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEncodingName())
            {
                context.Writer.WritePropertyName("encodingName");
                context.Writer.WriteStringValue(requestObject.EncodingName);
            }

            if(requestObject.IsSetInputConfigurations())
            {
                context.Writer.WritePropertyName("inputConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputConfigurationsListValue in requestObject.InputConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMediaStreamName())
            {
                context.Writer.WritePropertyName("mediaStreamName");
                context.Writer.WriteStringValue(requestObject.MediaStreamName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MediaStreamSourceConfigurationRequestMarshaller Instance = new MediaStreamSourceConfigurationRequestMarshaller();

    }
}