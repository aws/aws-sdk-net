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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ThreatIntelIndicator Marshaller
    /// </summary>       
    public class ThreatIntelIndicatorMarshaller : IRequestMarshaller<ThreatIntelIndicator, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ThreatIntelIndicator requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCategory())
            {
                context.Writer.WritePropertyName("Category");
                context.Writer.Write(requestObject.Category);
            }

            if(requestObject.IsSetLastObservedAt())
            {
                context.Writer.WritePropertyName("LastObservedAt");
                context.Writer.Write(requestObject.LastObservedAt);
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.Write(requestObject.Source);
            }

            if(requestObject.IsSetSourceUrl())
            {
                context.Writer.WritePropertyName("SourceUrl");
                context.Writer.Write(requestObject.SourceUrl);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.Write(requestObject.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ThreatIntelIndicatorMarshaller Instance = new ThreatIntelIndicatorMarshaller();

    }
}