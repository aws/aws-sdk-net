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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EksContainerResourceRequirements Marshaller
    /// </summary>
    public class EksContainerResourceRequirementsMarshaller : IRequestMarshaller<EksContainerResourceRequirements, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EksContainerResourceRequirements requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLimits())
            {
                context.Writer.WritePropertyName("limits");
                context.Writer.WriteStartObject();
                foreach (var requestObjectLimitsKvp in requestObject.Limits)
                {
                    context.Writer.WritePropertyName(requestObjectLimitsKvp.Key);
                    var requestObjectLimitsValue = requestObjectLimitsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectLimitsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequests())
            {
                context.Writer.WritePropertyName("requests");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRequestsKvp in requestObject.Requests)
                {
                    context.Writer.WritePropertyName(requestObjectRequestsKvp.Key);
                    var requestObjectRequestsValue = requestObjectRequestsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectRequestsValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EksContainerResourceRequirementsMarshaller Instance = new EksContainerResourceRequirementsMarshaller();

    }
}