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
    /// Project Marshaller
    /// </summary>
    public class ProjectMarshaller : IRequestMarshaller<Project, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Project requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalComments())
            {
                context.Writer.WritePropertyName("AdditionalComments");
                context.Writer.Write(requestObject.AdditionalComments);
            }

            if(requestObject.IsSetApnPrograms())
            {
                context.Writer.WritePropertyName("ApnPrograms");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectApnProgramsListValue in requestObject.ApnPrograms)
                {
                        context.Writer.Write(requestObjectApnProgramsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAwsPartition())
            {
                context.Writer.WritePropertyName("AwsPartition");
                context.Writer.Write(requestObject.AwsPartition);
            }

            if(requestObject.IsSetCompetitorName())
            {
                context.Writer.WritePropertyName("CompetitorName");
                context.Writer.Write(requestObject.CompetitorName);
            }

            if(requestObject.IsSetCustomerBusinessProblem())
            {
                context.Writer.WritePropertyName("CustomerBusinessProblem");
                context.Writer.Write(requestObject.CustomerBusinessProblem);
            }

            if(requestObject.IsSetCustomerUseCase())
            {
                context.Writer.WritePropertyName("CustomerUseCase");
                context.Writer.Write(requestObject.CustomerUseCase);
            }

            if(requestObject.IsSetDeliveryModels())
            {
                context.Writer.WritePropertyName("DeliveryModels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDeliveryModelsListValue in requestObject.DeliveryModels)
                {
                        context.Writer.Write(requestObjectDeliveryModelsListValue);
                }
                context.Writer.WriteArrayEnd();
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

            if(requestObject.IsSetOtherCompetitorNames())
            {
                context.Writer.WritePropertyName("OtherCompetitorNames");
                context.Writer.Write(requestObject.OtherCompetitorNames);
            }

            if(requestObject.IsSetOtherSolutionDescription())
            {
                context.Writer.WritePropertyName("OtherSolutionDescription");
                context.Writer.Write(requestObject.OtherSolutionDescription);
            }

            if(requestObject.IsSetRelatedOpportunityIdentifier())
            {
                context.Writer.WritePropertyName("RelatedOpportunityIdentifier");
                context.Writer.Write(requestObject.RelatedOpportunityIdentifier);
            }

            if(requestObject.IsSetSalesActivities())
            {
                context.Writer.WritePropertyName("SalesActivities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSalesActivitiesListValue in requestObject.SalesActivities)
                {
                        context.Writer.Write(requestObjectSalesActivitiesListValue);
                }
                context.Writer.WriteArrayEnd();
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
        public readonly static ProjectMarshaller Instance = new ProjectMarshaller();

    }
}