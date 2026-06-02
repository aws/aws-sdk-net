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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Resiliencehubv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Resiliencehubv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MultiAzTargets Marshaller
    /// </summary>
    public class MultiAzTargetsMarshaller : IRequestMarshaller<MultiAzTargets, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MultiAzTargets requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDisasterRecoveryApproach())
            {
                context.Writer.WritePropertyName("disasterRecoveryApproach");
                context.Writer.WriteStringValue(requestObject.DisasterRecoveryApproach);
            }

            if(requestObject.IsSetRpoInMinutes())
            {
                context.Writer.WritePropertyName("rpoInMinutes");
                context.Writer.WriteNumberValue(requestObject.RpoInMinutes.Value);
            }

            if(requestObject.IsSetRtoInMinutes())
            {
                context.Writer.WritePropertyName("rtoInMinutes");
                context.Writer.WriteNumberValue(requestObject.RtoInMinutes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MultiAzTargetsMarshaller Instance = new MultiAzTargetsMarshaller();

    }
}