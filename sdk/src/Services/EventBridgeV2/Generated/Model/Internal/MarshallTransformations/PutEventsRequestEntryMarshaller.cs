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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutEventsRequestEntry Marshaller
    /// </summary>
    public class PutEventsRequestEntryMarshaller : IRequestMarshaller<PutEventsRequestEntry, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PutEventsRequestEntry requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetDetail())
            {
                context.Writer.WriteTextString("Detail");
                context.Writer.WriteTextString(requestObject.Detail);
            }
            if (requestObject.IsSetDetailType())
            {
                context.Writer.WriteTextString("DetailType");
                context.Writer.WriteTextString(requestObject.DetailType);
            }
            if (requestObject.IsSetResources())
            {
                context.Writer.WriteTextString("Resources");
                context.Writer.WriteStartArray(requestObject.Resources.Count);
                foreach(var requestObjectResourcesListValue in requestObject.Resources)
                {
                        context.Writer.WriteTextString(requestObjectResourcesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSource())
            {
                context.Writer.WriteTextString("Source");
                context.Writer.WriteTextString(requestObject.Source);
            }
            if (requestObject.IsSetSystemMetadata())
            {
                context.Writer.WriteTextString("SystemMetadata");
                context.Writer.WriteStartMap(null);

                var marshaller = PutEventsSystemMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.SystemMetadata, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetTime())
            {
                context.Writer.WriteTextString("Time");
                context.Writer.WriteDateTime(requestObject.Time.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PutEventsRequestEntryMarshaller Instance = new PutEventsRequestEntryMarshaller();

    }
}