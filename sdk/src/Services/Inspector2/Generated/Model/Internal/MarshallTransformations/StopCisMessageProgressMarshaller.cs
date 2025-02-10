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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StopCisMessageProgress Marshaller
    /// </summary>
    public class StopCisMessageProgressMarshaller : IRequestMarshaller<StopCisMessageProgress, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StopCisMessageProgress requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetErrorChecks())
            {
                context.Writer.WritePropertyName("errorChecks");
                context.Writer.WriteNumberValue(requestObject.ErrorChecks.Value);
            }

            if(requestObject.IsSetFailedChecks())
            {
                context.Writer.WritePropertyName("failedChecks");
                context.Writer.WriteNumberValue(requestObject.FailedChecks.Value);
            }

            if(requestObject.IsSetInformationalChecks())
            {
                context.Writer.WritePropertyName("informationalChecks");
                context.Writer.WriteNumberValue(requestObject.InformationalChecks.Value);
            }

            if(requestObject.IsSetNotApplicableChecks())
            {
                context.Writer.WritePropertyName("notApplicableChecks");
                context.Writer.WriteNumberValue(requestObject.NotApplicableChecks.Value);
            }

            if(requestObject.IsSetNotEvaluatedChecks())
            {
                context.Writer.WritePropertyName("notEvaluatedChecks");
                context.Writer.WriteNumberValue(requestObject.NotEvaluatedChecks.Value);
            }

            if(requestObject.IsSetSuccessfulChecks())
            {
                context.Writer.WritePropertyName("successfulChecks");
                context.Writer.WriteNumberValue(requestObject.SuccessfulChecks.Value);
            }

            if(requestObject.IsSetTotalChecks())
            {
                context.Writer.WritePropertyName("totalChecks");
                context.Writer.WriteNumberValue(requestObject.TotalChecks.Value);
            }

            if(requestObject.IsSetUnknownChecks())
            {
                context.Writer.WritePropertyName("unknownChecks");
                context.Writer.WriteNumberValue(requestObject.UnknownChecks.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StopCisMessageProgressMarshaller Instance = new StopCisMessageProgressMarshaller();

    }
}