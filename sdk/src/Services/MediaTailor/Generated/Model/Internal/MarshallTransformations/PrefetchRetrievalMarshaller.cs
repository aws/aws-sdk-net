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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PrefetchRetrieval Marshaller
    /// </summary>
    public class PrefetchRetrievalMarshaller : IRequestMarshaller<PrefetchRetrieval, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PrefetchRetrieval requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDynamicVariables())
            {
                context.Writer.WritePropertyName("DynamicVariables");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDynamicVariablesKvp in requestObject.DynamicVariables)
                {
                    context.Writer.WritePropertyName(requestObjectDynamicVariablesKvp.Key);
                    var requestObjectDynamicVariablesValue = requestObjectDynamicVariablesKvp.Value;

                        context.Writer.Write(requestObjectDynamicVariablesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.Write(requestObject.EndTime);
            }

            if(requestObject.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.Write(requestObject.StartTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PrefetchRetrievalMarshaller Instance = new PrefetchRetrievalMarshaller();

    }
}