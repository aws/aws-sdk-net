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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoMerging Marshaller
    /// </summary>
    public class AutoMergingMarshaller : IRequestMarshaller<AutoMerging, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoMerging requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConflictResolution())
            {
                context.Writer.WritePropertyName("ConflictResolution");
                context.Writer.WriteStartObject();

                var marshaller = ConflictResolutionMarshaller.Instance;
                marshaller.Marshall(requestObject.ConflictResolution, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConsolidation())
            {
                context.Writer.WritePropertyName("Consolidation");
                context.Writer.WriteStartObject();

                var marshaller = ConsolidationMarshaller.Instance;
                marshaller.Marshall(requestObject.Consolidation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetMinAllowedConfidenceScoreForMerging())
            {
                context.Writer.WritePropertyName("MinAllowedConfidenceScoreForMerging");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MinAllowedConfidenceScoreForMerging.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MinAllowedConfidenceScoreForMerging.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MinAllowedConfidenceScoreForMerging.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoMergingMarshaller Instance = new AutoMergingMarshaller();

    }
}