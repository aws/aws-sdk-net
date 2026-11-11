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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StreamingProperties Marshaller
    /// </summary>
    public partial class StreamingPropertiesMarshaller : IRequestMarshaller<StreamingProperties, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(StreamingProperties requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetGlobalAccelerator())
            {
                context.Writer.WriteTextString("GlobalAccelerator");
                context.Writer.WriteStartMap(null);

                var marshaller = GlobalAcceleratorForDirectoryMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalAccelerator, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetStorageConnectors())
            {
                context.Writer.WriteTextString("StorageConnectors");
                context.Writer.WriteStartArray(requestObject.StorageConnectors.Count);
                foreach (var requestObjectStorageConnectorsListValue in requestObject.StorageConnectors)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StorageConnectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectStorageConnectorsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStreamingExperiencePreferredProtocol())
            {
                context.Writer.WriteTextString("StreamingExperiencePreferredProtocol");
                context.Writer.WriteTextString(requestObject.StreamingExperiencePreferredProtocol);
            }

            if (requestObject.IsSetUserSettings())
            {
                context.Writer.WriteTextString("UserSettings");
                context.Writer.WriteStartArray(requestObject.UserSettings.Count);
                foreach (var requestObjectUserSettingsListValue in requestObject.UserSettings)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = UserSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserSettingsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static StreamingPropertiesMarshaller Instance = new StreamingPropertiesMarshaller();
    }
}
