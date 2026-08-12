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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContextContent Marshaller
    /// </summary>
    public class ContextContentMarshaller : IRequestMarshaller<ContextContent, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContextContent requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("accountIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountIdsListValue in requestObject.AccountIds)
                {
                        context.Writer.WriteStringValue(requestObjectAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAdditionalContext())
            {
                context.Writer.WritePropertyName("additionalContext");
                context.Writer.WriteStringValue(requestObject.AdditionalContext);
            }

            if(requestObject.IsSetApplicationOverview())
            {
                context.Writer.WritePropertyName("applicationOverview");
                context.Writer.WriteStringValue(requestObject.ApplicationOverview);
            }

            if(requestObject.IsSetApplicationType())
            {
                context.Writer.WritePropertyName("applicationType");
                context.Writer.WriteStringValue(requestObject.ApplicationType);
            }

            if(requestObject.IsSetArchitectureOverview())
            {
                context.Writer.WritePropertyName("architectureOverview");
                context.Writer.WriteStringValue(requestObject.ArchitectureOverview);
            }

            if(requestObject.IsSetAwsServices())
            {
                context.Writer.WritePropertyName("awsServices");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAwsServicesListValue in requestObject.AwsServices)
                {
                        context.Writer.WriteStringValue(requestObjectAwsServicesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCriticality())
            {
                context.Writer.WritePropertyName("criticality");
                context.Writer.WriteStringValue(requestObject.Criticality);
            }

            if(requestObject.IsSetIndustry())
            {
                context.Writer.WritePropertyName("industry");
                context.Writer.WriteStringValue(requestObject.Industry);
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.WriteStringValue(requestObjectRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("resourceTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTagsListValue in requestObject.ResourceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContextResourceTagMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("resourceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContextContentMarshaller Instance = new ContextContentMarshaller();

    }
}