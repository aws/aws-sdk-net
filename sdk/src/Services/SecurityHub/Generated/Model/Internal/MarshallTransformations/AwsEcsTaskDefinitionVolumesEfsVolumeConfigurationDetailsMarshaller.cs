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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetails Marshaller
    /// </summary>
    public class AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetailsMarshaller : IRequestMarshaller<AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthorizationConfig())
            {
                context.Writer.WritePropertyName("AuthorizationConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationAuthorizationConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthorizationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilesystemId())
            {
                context.Writer.WritePropertyName("FilesystemId");
                context.Writer.WriteStringValue(requestObject.FilesystemId);
            }

            if(requestObject.IsSetRootDirectory())
            {
                context.Writer.WritePropertyName("RootDirectory");
                context.Writer.WriteStringValue(requestObject.RootDirectory);
            }

            if(requestObject.IsSetTransitEncryption())
            {
                context.Writer.WritePropertyName("TransitEncryption");
                context.Writer.WriteStringValue(requestObject.TransitEncryption);
            }

            if(requestObject.IsSetTransitEncryptionPort())
            {
                context.Writer.WritePropertyName("TransitEncryptionPort");
                context.Writer.WriteNumberValue(requestObject.TransitEncryptionPort.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetailsMarshaller Instance = new AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetailsMarshaller();

    }
}