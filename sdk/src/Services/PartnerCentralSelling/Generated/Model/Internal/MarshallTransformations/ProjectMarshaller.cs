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
                context.Writer.WriteStringValue(requestObject.AdditionalComments);
            }

            if(requestObject.IsSetApnPrograms())
            {
                context.Writer.WritePropertyName("ApnPrograms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectApnProgramsListValue in requestObject.ApnPrograms)
                {
                        context.Writer.WriteStringValue(requestObjectApnProgramsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCompetitorName())
            {
                context.Writer.WritePropertyName("CompetitorName");
                context.Writer.WriteStringValue(requestObject.CompetitorName);
            }

            if(requestObject.IsSetCustomerBusinessProblem())
            {
                context.Writer.WritePropertyName("CustomerBusinessProblem");
                context.Writer.WriteStringValue(requestObject.CustomerBusinessProblem);
            }

            if(requestObject.IsSetCustomerUseCase())
            {
                context.Writer.WritePropertyName("CustomerUseCase");
                context.Writer.WriteStringValue(requestObject.CustomerUseCase);
            }

            if(requestObject.IsSetDeliveryModels())
            {
                context.Writer.WritePropertyName("DeliveryModels");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDeliveryModelsListValue in requestObject.DeliveryModels)
                {
                        context.Writer.WriteStringValue(requestObjectDeliveryModelsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExpectedCustomerSpend())
            {
                context.Writer.WritePropertyName("ExpectedCustomerSpend");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExpectedCustomerSpendListValue in requestObject.ExpectedCustomerSpend)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ExpectedCustomerSpendMarshaller.Instance;
                    marshaller.Marshall(requestObjectExpectedCustomerSpendListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOtherCompetitorNames())
            {
                context.Writer.WritePropertyName("OtherCompetitorNames");
                context.Writer.WriteStringValue(requestObject.OtherCompetitorNames);
            }

            if(requestObject.IsSetOtherSolutionDescription())
            {
                context.Writer.WritePropertyName("OtherSolutionDescription");
                context.Writer.WriteStringValue(requestObject.OtherSolutionDescription);
            }

            if(requestObject.IsSetRelatedOpportunityIdentifier())
            {
                context.Writer.WritePropertyName("RelatedOpportunityIdentifier");
                context.Writer.WriteStringValue(requestObject.RelatedOpportunityIdentifier);
            }

            if(requestObject.IsSetSalesActivities())
            {
                context.Writer.WritePropertyName("SalesActivities");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSalesActivitiesListValue in requestObject.SalesActivities)
                {
                        context.Writer.WriteStringValue(requestObjectSalesActivitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProjectMarshaller Instance = new ProjectMarshaller();

    }
}