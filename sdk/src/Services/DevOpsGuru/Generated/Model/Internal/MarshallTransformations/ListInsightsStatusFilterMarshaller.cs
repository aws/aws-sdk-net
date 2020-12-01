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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListInsightsStatusFilter Marshaller
    /// </summary>       
    public class ListInsightsStatusFilterMarshaller : IRequestMarshaller<ListInsightsStatusFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListInsightsStatusFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAny())
            {
                context.Writer.WritePropertyName("Any");
                context.Writer.WriteObjectStart();

                var marshaller = ListInsightsAnyStatusFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Any, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetClosed())
            {
                context.Writer.WritePropertyName("Closed");
                context.Writer.WriteObjectStart();

                var marshaller = ListInsightsClosedStatusFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Closed, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOngoing())
            {
                context.Writer.WritePropertyName("Ongoing");
                context.Writer.WriteObjectStart();

                var marshaller = ListInsightsOngoingStatusFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Ongoing, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ListInsightsStatusFilterMarshaller Instance = new ListInsightsStatusFilterMarshaller();

    }
}