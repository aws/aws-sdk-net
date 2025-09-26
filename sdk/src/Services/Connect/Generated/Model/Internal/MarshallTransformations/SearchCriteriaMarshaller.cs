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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchCriteria Marshaller
    /// </summary>
    public class SearchCriteriaMarshaller : IRequestMarshaller<SearchCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SearchCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalTimeRange())
            {
                context.Writer.WritePropertyName("AdditionalTimeRange");
                context.Writer.WriteStartObject();

                var marshaller = SearchContactsAdditionalTimeRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.AdditionalTimeRange, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAgentHierarchyGroups())
            {
                context.Writer.WritePropertyName("AgentHierarchyGroups");
                context.Writer.WriteStartObject();

                var marshaller = AgentHierarchyGroupsMarshaller.Instance;
                marshaller.Marshall(requestObject.AgentHierarchyGroups, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAgentIds())
            {
                context.Writer.WritePropertyName("AgentIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAgentIdsListValue in requestObject.AgentIds)
                {
                        context.Writer.WriteStringValue(requestObjectAgentIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetChannels())
            {
                context.Writer.WritePropertyName("Channels");
                context.Writer.WriteStartArray();
                foreach(var requestObjectChannelsListValue in requestObject.Channels)
                {
                        context.Writer.WriteStringValue(requestObjectChannelsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContactAnalysis())
            {
                context.Writer.WritePropertyName("ContactAnalysis");
                context.Writer.WriteStartObject();

                var marshaller = ContactAnalysisMarshaller.Instance;
                marshaller.Marshall(requestObject.ContactAnalysis, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInitiationMethods())
            {
                context.Writer.WritePropertyName("InitiationMethods");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInitiationMethodsListValue in requestObject.InitiationMethods)
                {
                        context.Writer.WriteStringValue(requestObjectInitiationMethodsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStartObject();

                var marshaller = NameCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.Name, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQueueIds())
            {
                context.Writer.WritePropertyName("QueueIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectQueueIdsListValue in requestObject.QueueIds)
                {
                        context.Writer.WriteStringValue(requestObjectQueueIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRoutingCriteria())
            {
                context.Writer.WritePropertyName("RoutingCriteria");
                context.Writer.WriteStartObject();

                var marshaller = SearchableRoutingCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.RoutingCriteria, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSearchableContactAttributes())
            {
                context.Writer.WritePropertyName("SearchableContactAttributes");
                context.Writer.WriteStartObject();

                var marshaller = SearchableContactAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.SearchableContactAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSearchableSegmentAttributes())
            {
                context.Writer.WritePropertyName("SearchableSegmentAttributes");
                context.Writer.WriteStartObject();

                var marshaller = SearchableSegmentAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.SearchableSegmentAttributes, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchCriteriaMarshaller Instance = new SearchCriteriaMarshaller();

    }
}