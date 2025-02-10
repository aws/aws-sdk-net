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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceMapping Marshaller
    /// </summary>
    public class ResourceMappingMarshaller : IRequestMarshaller<ResourceMapping, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceMapping requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppRegistryAppName())
            {
                context.Writer.WritePropertyName("appRegistryAppName");
                context.Writer.WriteStringValue(requestObject.AppRegistryAppName);
            }

            if(requestObject.IsSetEksSourceName())
            {
                context.Writer.WritePropertyName("eksSourceName");
                context.Writer.WriteStringValue(requestObject.EksSourceName);
            }

            if(requestObject.IsSetLogicalStackName())
            {
                context.Writer.WritePropertyName("logicalStackName");
                context.Writer.WriteStringValue(requestObject.LogicalStackName);
            }

            if(requestObject.IsSetMappingType())
            {
                context.Writer.WritePropertyName("mappingType");
                context.Writer.WriteStringValue(requestObject.MappingType);
            }

            if(requestObject.IsSetPhysicalResourceId())
            {
                context.Writer.WritePropertyName("physicalResourceId");
                context.Writer.WriteStartObject();

                var marshaller = PhysicalResourceIdMarshaller.Instance;
                marshaller.Marshall(requestObject.PhysicalResourceId, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceGroupName())
            {
                context.Writer.WritePropertyName("resourceGroupName");
                context.Writer.WriteStringValue(requestObject.ResourceGroupName);
            }

            if(requestObject.IsSetResourceName())
            {
                context.Writer.WritePropertyName("resourceName");
                context.Writer.WriteStringValue(requestObject.ResourceName);
            }

            if(requestObject.IsSetTerraformSourceName())
            {
                context.Writer.WritePropertyName("terraformSourceName");
                context.Writer.WriteStringValue(requestObject.TerraformSourceName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceMappingMarshaller Instance = new ResourceMappingMarshaller();

    }
}