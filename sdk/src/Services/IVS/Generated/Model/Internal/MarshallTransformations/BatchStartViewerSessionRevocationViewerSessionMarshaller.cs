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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IVS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchStartViewerSessionRevocationViewerSession Marshaller
    /// </summary>
    public class BatchStartViewerSessionRevocationViewerSessionMarshaller : IRequestMarshaller<BatchStartViewerSessionRevocationViewerSession, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchStartViewerSessionRevocationViewerSession requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChannelArn())
            {
                context.Writer.WritePropertyName("channelArn");
                context.Writer.WriteStringValue(requestObject.ChannelArn);
            }

            if(requestObject.IsSetViewerId())
            {
                context.Writer.WritePropertyName("viewerId");
                context.Writer.WriteStringValue(requestObject.ViewerId);
            }

            if(requestObject.IsSetViewerSessionVersionsLessThanOrEqualTo())
            {
                context.Writer.WritePropertyName("viewerSessionVersionsLessThanOrEqualTo");
                context.Writer.WriteNumberValue(requestObject.ViewerSessionVersionsLessThanOrEqualTo.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchStartViewerSessionRevocationViewerSessionMarshaller Instance = new BatchStartViewerSessionRevocationViewerSessionMarshaller();

    }
}