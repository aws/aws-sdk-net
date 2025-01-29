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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SpekeKeyProvider Marshaller
    /// </summary>
    public class SpekeKeyProviderMarshaller : IRequestMarshaller<SpekeKeyProvider, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SpekeKeyProvider requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDrmSystems())
            {
                context.Writer.WritePropertyName("DrmSystems");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDrmSystemsListValue in requestObject.DrmSystems)
                {
                        context.Writer.WriteStringValue(requestObjectDrmSystemsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEncryptionContractConfiguration())
            {
                context.Writer.WritePropertyName("EncryptionContractConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionContractConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionContractConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.WriteStringValue(requestObject.ResourceId);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStringValue(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SpekeKeyProviderMarshaller Instance = new SpekeKeyProviderMarshaller();

    }
}