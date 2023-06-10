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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EksPodProperties Marshaller
    /// </summary>
    public class EksPodPropertiesMarshaller : IRequestMarshaller<EksPodProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EksPodProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContainers())
            {
                context.Writer.WritePropertyName("containers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContainersListValue in requestObject.Containers)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EksContainerMarshaller.Instance;
                    marshaller.Marshall(requestObjectContainersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDnsPolicy())
            {
                context.Writer.WritePropertyName("dnsPolicy");
                context.Writer.Write(requestObject.DnsPolicy);
            }

            if(requestObject.IsSetHostNetwork())
            {
                context.Writer.WritePropertyName("hostNetwork");
                context.Writer.Write(requestObject.HostNetwork);
            }

            if(requestObject.IsSetMetadata())
            {
                context.Writer.WritePropertyName("metadata");
                context.Writer.WriteObjectStart();

                var marshaller = EksMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.Metadata, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServiceAccountName())
            {
                context.Writer.WritePropertyName("serviceAccountName");
                context.Writer.Write(requestObject.ServiceAccountName);
            }

            if(requestObject.IsSetVolumes())
            {
                context.Writer.WritePropertyName("volumes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVolumesListValue in requestObject.Volumes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EksVolumeMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EksPodPropertiesMarshaller Instance = new EksPodPropertiesMarshaller();

    }
}