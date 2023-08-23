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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRecommendationStatusRequestEntry Marshaller
    /// </summary>
    public class UpdateRecommendationStatusRequestEntryMarshaller : IRequestMarshaller<UpdateRecommendationStatusRequestEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateRecommendationStatusRequestEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEntryId())
            {
                context.Writer.WritePropertyName("entryId");
                context.Writer.Write(requestObject.EntryId);
            }

            if(requestObject.IsSetExcluded())
            {
                context.Writer.WritePropertyName("excluded");
                context.Writer.Write(requestObject.Excluded);
            }

            if(requestObject.IsSetExcludeReason())
            {
                context.Writer.WritePropertyName("excludeReason");
                context.Writer.Write(requestObject.ExcludeReason);
            }

            if(requestObject.IsSetItem())
            {
                context.Writer.WritePropertyName("item");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateRecommendationStatusItemMarshaller.Instance;
                marshaller.Marshall(requestObject.Item, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReferenceId())
            {
                context.Writer.WritePropertyName("referenceId");
                context.Writer.Write(requestObject.ReferenceId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateRecommendationStatusRequestEntryMarshaller Instance = new UpdateRecommendationStatusRequestEntryMarshaller();

    }
}