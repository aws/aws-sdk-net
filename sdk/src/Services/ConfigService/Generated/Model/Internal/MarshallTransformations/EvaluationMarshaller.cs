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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Evaluation Marshaller
    /// </summary>
    public class EvaluationMarshaller : IRequestMarshaller<Evaluation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Evaluation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnnotation())
            {
                context.Writer.WritePropertyName("Annotation");
                context.Writer.WriteStringValue(requestObject.Annotation);
            }

            if(requestObject.IsSetComplianceResourceId())
            {
                context.Writer.WritePropertyName("ComplianceResourceId");
                context.Writer.WriteStringValue(requestObject.ComplianceResourceId);
            }

            if(requestObject.IsSetComplianceResourceType())
            {
                context.Writer.WritePropertyName("ComplianceResourceType");
                context.Writer.WriteStringValue(requestObject.ComplianceResourceType);
            }

            if(requestObject.IsSetComplianceType())
            {
                context.Writer.WritePropertyName("ComplianceType");
                context.Writer.WriteStringValue(requestObject.ComplianceType);
            }

            if(requestObject.IsSetOrderingTimestamp())
            {
                context.Writer.WritePropertyName("OrderingTimestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.OrderingTimestamp.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EvaluationMarshaller Instance = new EvaluationMarshaller();

    }
}