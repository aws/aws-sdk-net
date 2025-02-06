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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3AccessPointConfiguration Marshaller
    /// </summary>
    public class S3AccessPointConfigurationMarshaller : IRequestMarshaller<S3AccessPointConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3AccessPointConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessPointPolicy())
            {
                context.Writer.WritePropertyName("accessPointPolicy");
                context.Writer.WriteStringValue(requestObject.AccessPointPolicy);
            }

            if(requestObject.IsSetNetworkOrigin())
            {
                context.Writer.WritePropertyName("networkOrigin");
                context.Writer.WriteStartObject();

                var marshaller = NetworkOriginConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkOrigin, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPublicAccessBlock())
            {
                context.Writer.WritePropertyName("publicAccessBlock");
                context.Writer.WriteStartObject();

                var marshaller = S3PublicAccessBlockConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PublicAccessBlock, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3AccessPointConfigurationMarshaller Instance = new S3AccessPointConfigurationMarshaller();

    }
}