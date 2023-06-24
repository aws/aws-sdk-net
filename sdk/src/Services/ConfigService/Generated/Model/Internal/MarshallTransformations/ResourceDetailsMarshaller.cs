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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceDetails Marshaller
    /// </summary>
    public class ResourceDetailsMarshaller : IRequestMarshaller<ResourceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetResourceConfiguration())
            {
                context.Writer.WritePropertyName("ResourceConfiguration");
                context.Writer.Write(requestObject.ResourceConfiguration);
            }

            if(requestObject.IsSetResourceConfigurationSchemaType())
            {
                context.Writer.WritePropertyName("ResourceConfigurationSchemaType");
                context.Writer.Write(requestObject.ResourceConfigurationSchemaType);
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.Write(requestObject.ResourceId);
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.Write(requestObject.ResourceType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceDetailsMarshaller Instance = new ResourceDetailsMarshaller();

    }
}