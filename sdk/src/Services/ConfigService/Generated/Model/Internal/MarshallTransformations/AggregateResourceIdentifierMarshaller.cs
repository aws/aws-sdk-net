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
    /// AggregateResourceIdentifier Marshaller
    /// </summary>       
    public class AggregateResourceIdentifierMarshaller : IRequestMarshaller<AggregateResourceIdentifier, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AggregateResourceIdentifier requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.Write(requestObject.ResourceId);
            }

            if(requestObject.IsSetResourceName())
            {
                context.Writer.WritePropertyName("ResourceName");
                context.Writer.Write(requestObject.ResourceName);
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.Write(requestObject.ResourceType);
            }

            if(requestObject.IsSetSourceAccountId())
            {
                context.Writer.WritePropertyName("SourceAccountId");
                context.Writer.Write(requestObject.SourceAccountId);
            }

            if(requestObject.IsSetSourceRegion())
            {
                context.Writer.WritePropertyName("SourceRegion");
                context.Writer.Write(requestObject.SourceRegion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AggregateResourceIdentifierMarshaller Instance = new AggregateResourceIdentifierMarshaller();

    }
}