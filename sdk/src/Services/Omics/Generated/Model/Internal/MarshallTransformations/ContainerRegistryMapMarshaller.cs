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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContainerRegistryMap Marshaller
    /// </summary>
    public class ContainerRegistryMapMarshaller : IRequestMarshaller<ContainerRegistryMap, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerRegistryMap requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetImageMappings())
            {
                context.Writer.WritePropertyName("imageMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectImageMappingsListValue in requestObject.ImageMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ImageMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectImageMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRegistryMappings())
            {
                context.Writer.WritePropertyName("registryMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRegistryMappingsListValue in requestObject.RegistryMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RegistryMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectRegistryMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerRegistryMapMarshaller Instance = new ContainerRegistryMapMarshaller();

    }
}