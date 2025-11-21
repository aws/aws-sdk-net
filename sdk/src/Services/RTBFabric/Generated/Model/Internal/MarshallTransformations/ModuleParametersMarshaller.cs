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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RTBFabric.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RTBFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModuleParameters Marshaller
    /// </summary>
    public class ModuleParametersMarshaller : IRequestMarshaller<ModuleParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ModuleParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetNoBid())
            {
                context.Writer.WritePropertyName("noBid");
                context.Writer.WriteStartObject();

                var marshaller = NoBidModuleParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.NoBid, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOpenRtbAttribute())
            {
                context.Writer.WritePropertyName("openRtbAttribute");
                context.Writer.WriteStartObject();

                var marshaller = OpenRtbAttributeModuleParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenRtbAttribute, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRateLimiter())
            {
                context.Writer.WritePropertyName("rateLimiter");
                context.Writer.WriteStartObject();

                var marshaller = RateLimiterModuleParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RateLimiter, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ModuleParametersMarshaller Instance = new ModuleParametersMarshaller();

    }
}