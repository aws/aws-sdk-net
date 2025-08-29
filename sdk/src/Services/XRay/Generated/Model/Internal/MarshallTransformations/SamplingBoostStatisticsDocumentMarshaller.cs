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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SamplingBoostStatisticsDocument Marshaller
    /// </summary>
    public class SamplingBoostStatisticsDocumentMarshaller : IRequestMarshaller<SamplingBoostStatisticsDocument, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SamplingBoostStatisticsDocument requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnomalyCount())
            {
                context.Writer.WritePropertyName("AnomalyCount");
                context.Writer.Write(requestObject.AnomalyCount);
            }

            if(requestObject.IsSetRuleName())
            {
                context.Writer.WritePropertyName("RuleName");
                context.Writer.Write(requestObject.RuleName);
            }

            if(requestObject.IsSetSampledAnomalyCount())
            {
                context.Writer.WritePropertyName("SampledAnomalyCount");
                context.Writer.Write(requestObject.SampledAnomalyCount);
            }

            if(requestObject.IsSetServiceName())
            {
                context.Writer.WritePropertyName("ServiceName");
                context.Writer.Write(requestObject.ServiceName);
            }

            if(requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.Write(requestObject.Timestamp);
            }

            if(requestObject.IsSetTotalCount())
            {
                context.Writer.WritePropertyName("TotalCount");
                context.Writer.Write(requestObject.TotalCount);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SamplingBoostStatisticsDocumentMarshaller Instance = new SamplingBoostStatisticsDocumentMarshaller();

    }
}