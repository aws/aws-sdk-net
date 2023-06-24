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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StreamConfigurationCreate Marshaller
    /// </summary>
    public class StreamConfigurationCreateMarshaller : IRequestMarshaller<StreamConfigurationCreate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StreamConfigurationCreate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutomaticTerminationMode())
            {
                context.Writer.WritePropertyName("automaticTerminationMode");
                context.Writer.Write(requestObject.AutomaticTerminationMode);
            }

            if(requestObject.IsSetClipboardMode())
            {
                context.Writer.WritePropertyName("clipboardMode");
                context.Writer.Write(requestObject.ClipboardMode);
            }

            if(requestObject.IsSetEc2InstanceTypes())
            {
                context.Writer.WritePropertyName("ec2InstanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEc2InstanceTypesListValue in requestObject.Ec2InstanceTypes)
                {
                        context.Writer.Write(requestObjectEc2InstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMaxSessionLengthInMinutes())
            {
                context.Writer.WritePropertyName("maxSessionLengthInMinutes");
                context.Writer.Write(requestObject.MaxSessionLengthInMinutes);
            }

            if(requestObject.IsSetMaxStoppedSessionLengthInMinutes())
            {
                context.Writer.WritePropertyName("maxStoppedSessionLengthInMinutes");
                context.Writer.Write(requestObject.MaxStoppedSessionLengthInMinutes);
            }

            if(requestObject.IsSetSessionBackup())
            {
                context.Writer.WritePropertyName("sessionBackup");
                context.Writer.WriteObjectStart();

                var marshaller = StreamConfigurationSessionBackupMarshaller.Instance;
                marshaller.Marshall(requestObject.SessionBackup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSessionPersistenceMode())
            {
                context.Writer.WritePropertyName("sessionPersistenceMode");
                context.Writer.Write(requestObject.SessionPersistenceMode);
            }

            if(requestObject.IsSetSessionStorage())
            {
                context.Writer.WritePropertyName("sessionStorage");
                context.Writer.WriteObjectStart();

                var marshaller = StreamConfigurationSessionStorageMarshaller.Instance;
                marshaller.Marshall(requestObject.SessionStorage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStreamingImageIds())
            {
                context.Writer.WritePropertyName("streamingImageIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStreamingImageIdsListValue in requestObject.StreamingImageIds)
                {
                        context.Writer.Write(requestObjectStreamingImageIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVolumeConfiguration())
            {
                context.Writer.WritePropertyName("volumeConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = VolumeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VolumeConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StreamConfigurationCreateMarshaller Instance = new StreamConfigurationCreateMarshaller();

    }
}