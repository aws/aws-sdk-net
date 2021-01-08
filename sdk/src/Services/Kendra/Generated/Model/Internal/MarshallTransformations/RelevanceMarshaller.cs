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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Relevance Marshaller
    /// </summary>       
    public class RelevanceMarshaller : IRequestMarshaller<Relevance, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Relevance requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDuration())
            {
                context.Writer.WritePropertyName("Duration");
                context.Writer.Write(requestObject.Duration);
            }

            if(requestObject.IsSetFreshness())
            {
                context.Writer.WritePropertyName("Freshness");
                context.Writer.Write(requestObject.Freshness);
            }

            if(requestObject.IsSetImportance())
            {
                context.Writer.WritePropertyName("Importance");
                context.Writer.Write(requestObject.Importance);
            }

            if(requestObject.IsSetRankOrder())
            {
                context.Writer.WritePropertyName("RankOrder");
                context.Writer.Write(requestObject.RankOrder);
            }

            if(requestObject.IsSetValueImportanceMap())
            {
                context.Writer.WritePropertyName("ValueImportanceMap");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectValueImportanceMapKvp in requestObject.ValueImportanceMap)
                {
                    context.Writer.WritePropertyName(requestObjectValueImportanceMapKvp.Key);
                    var requestObjectValueImportanceMapValue = requestObjectValueImportanceMapKvp.Value;

                        context.Writer.Write(requestObjectValueImportanceMapValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RelevanceMarshaller Instance = new RelevanceMarshaller();

    }
}