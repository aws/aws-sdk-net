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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Filters Marshaller
    /// </summary>
    public class FiltersMarshaller : IRequestMarshaller<Filters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Filters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChannels())
            {
                context.Writer.WritePropertyName("Channels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectChannelsListValue in requestObject.Channels)
                {
                        context.Writer.Write(requestObjectChannelsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetQueues())
            {
                context.Writer.WritePropertyName("Queues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectQueuesListValue in requestObject.Queues)
                {
                        context.Writer.Write(requestObjectQueuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRoutingProfiles())
            {
                context.Writer.WritePropertyName("RoutingProfiles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRoutingProfilesListValue in requestObject.RoutingProfiles)
                {
                        context.Writer.Write(requestObjectRoutingProfilesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FiltersMarshaller Instance = new FiltersMarshaller();

    }
}