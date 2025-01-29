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
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Cvss Marshaller
    /// </summary>
    public class CvssMarshaller : IRequestMarshaller<Cvss, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Cvss requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdjustments())
            {
                context.Writer.WritePropertyName("Adjustments");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdjustmentsListValue in requestObject.Adjustments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdjustmentMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdjustmentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBaseScore())
            {
                context.Writer.WritePropertyName("BaseScore");
                if(StringUtils.IsSpecialDoubleValue(requestObject.BaseScore.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.BaseScore.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.BaseScore.Value);
                }
            }

            if(requestObject.IsSetBaseVector())
            {
                context.Writer.WritePropertyName("BaseVector");
                context.Writer.WriteStringValue(requestObject.BaseVector);
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteStringValue(requestObject.Source);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CvssMarshaller Instance = new CvssMarshaller();

    }
}