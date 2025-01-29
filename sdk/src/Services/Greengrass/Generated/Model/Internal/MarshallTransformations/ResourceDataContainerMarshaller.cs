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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceDataContainer Marshaller
    /// </summary>
    public class ResourceDataContainerMarshaller : IRequestMarshaller<ResourceDataContainer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceDataContainer requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLocalDeviceResourceData())
            {
                context.Writer.WritePropertyName("LocalDeviceResourceData");
                context.Writer.WriteStartObject();

                var marshaller = LocalDeviceResourceDataMarshaller.Instance;
                marshaller.Marshall(requestObject.LocalDeviceResourceData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLocalVolumeResourceData())
            {
                context.Writer.WritePropertyName("LocalVolumeResourceData");
                context.Writer.WriteStartObject();

                var marshaller = LocalVolumeResourceDataMarshaller.Instance;
                marshaller.Marshall(requestObject.LocalVolumeResourceData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3MachineLearningModelResourceData())
            {
                context.Writer.WritePropertyName("S3MachineLearningModelResourceData");
                context.Writer.WriteStartObject();

                var marshaller = S3MachineLearningModelResourceDataMarshaller.Instance;
                marshaller.Marshall(requestObject.S3MachineLearningModelResourceData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSageMakerMachineLearningModelResourceData())
            {
                context.Writer.WritePropertyName("SageMakerMachineLearningModelResourceData");
                context.Writer.WriteStartObject();

                var marshaller = SageMakerMachineLearningModelResourceDataMarshaller.Instance;
                marshaller.Marshall(requestObject.SageMakerMachineLearningModelResourceData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecretsManagerSecretResourceData())
            {
                context.Writer.WritePropertyName("SecretsManagerSecretResourceData");
                context.Writer.WriteStartObject();

                var marshaller = SecretsManagerSecretResourceDataMarshaller.Instance;
                marshaller.Marshall(requestObject.SecretsManagerSecretResourceData, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceDataContainerMarshaller Instance = new ResourceDataContainerMarshaller();

    }
}