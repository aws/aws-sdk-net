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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StreamingProperties Marshaller
    /// </summary>
    public class StreamingPropertiesMarshaller : IRequestMarshaller<StreamingProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StreamingProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGlobalAccelerator())
            {
                context.Writer.WritePropertyName("GlobalAccelerator");
                context.Writer.WriteObjectStart();

                var marshaller = GlobalAcceleratorForDirectoryMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalAccelerator, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStorageConnectors())
            {
                context.Writer.WritePropertyName("StorageConnectors");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStorageConnectorsListValue in requestObject.StorageConnectors)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StorageConnectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectStorageConnectorsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStreamingExperiencePreferredProtocol())
            {
                context.Writer.WritePropertyName("StreamingExperiencePreferredProtocol");
                context.Writer.Write(requestObject.StreamingExperiencePreferredProtocol);
            }

            if(requestObject.IsSetUserSettings())
            {
                context.Writer.WritePropertyName("UserSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUserSettingsListValue in requestObject.UserSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = UserSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StreamingPropertiesMarshaller Instance = new StreamingPropertiesMarshaller();

    }
}