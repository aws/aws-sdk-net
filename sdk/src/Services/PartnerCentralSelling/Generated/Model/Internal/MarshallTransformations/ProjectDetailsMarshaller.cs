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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProjectDetails Marshaller
    /// </summary>
    public class ProjectDetailsMarshaller : IRequestMarshaller<ProjectDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProjectDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBusinessProblem())
            {
                context.Writer.WritePropertyName("BusinessProblem");
                context.Writer.Write(requestObject.BusinessProblem);
            }

            if(requestObject.IsSetExpectedCustomerSpend())
            {
                context.Writer.WritePropertyName("ExpectedCustomerSpend");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExpectedCustomerSpendListValue in requestObject.ExpectedCustomerSpend)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ExpectedCustomerSpendMarshaller.Instance;
                    marshaller.Marshall(requestObjectExpectedCustomerSpendListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetCompletionDate())
            {
                context.Writer.WritePropertyName("TargetCompletionDate");
                context.Writer.Write(requestObject.TargetCompletionDate);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.Write(requestObject.Title);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProjectDetailsMarshaller Instance = new ProjectDetailsMarshaller();

    }
}