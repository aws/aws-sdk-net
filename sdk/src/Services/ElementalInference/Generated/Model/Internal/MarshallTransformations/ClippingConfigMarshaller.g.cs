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

using Amazon.ElementalInference.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ElementalInference.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ClippingConfig Marshaller
    /// </summary>
    public partial class ClippingConfigMarshaller : IRequestMarshaller<ClippingConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ClippingConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCallbackMetadata())
            {
                context.Writer.WritePropertyName("callbackMetadata");
                context.Writer.WriteStringValue(requestObject.CallbackMetadata);
            }

            if (requestObject.IsSetDataSourceConfiguration())
            {
                context.Writer.WritePropertyName("dataSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ClippingConfigMarshaller Instance = new ClippingConfigMarshaller();
    }
}
