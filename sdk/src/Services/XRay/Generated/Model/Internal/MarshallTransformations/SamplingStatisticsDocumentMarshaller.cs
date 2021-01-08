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

namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SamplingStatisticsDocument Marshaller
    /// </summary>       
    public class SamplingStatisticsDocumentMarshaller : IRequestMarshaller<SamplingStatisticsDocument, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SamplingStatisticsDocument requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBorrowCount())
            {
                context.Writer.WritePropertyName("BorrowCount");
                context.Writer.Write(requestObject.BorrowCount);
            }

            if(requestObject.IsSetClientID())
            {
                context.Writer.WritePropertyName("ClientID");
                context.Writer.Write(requestObject.ClientID);
            }

            if(requestObject.IsSetRequestCount())
            {
                context.Writer.WritePropertyName("RequestCount");
                context.Writer.Write(requestObject.RequestCount);
            }

            if(requestObject.IsSetRuleName())
            {
                context.Writer.WritePropertyName("RuleName");
                context.Writer.Write(requestObject.RuleName);
            }

            if(requestObject.IsSetSampledCount())
            {
                context.Writer.WritePropertyName("SampledCount");
                context.Writer.Write(requestObject.SampledCount);
            }

            if(requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.Write(requestObject.Timestamp);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SamplingStatisticsDocumentMarshaller Instance = new SamplingStatisticsDocumentMarshaller();

    }
}