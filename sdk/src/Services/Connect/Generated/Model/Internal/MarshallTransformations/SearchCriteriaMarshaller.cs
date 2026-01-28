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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetActiveRegions())
            {
                context.Writer.WritePropertyName("ActiveRegions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActiveRegionsListValue in requestObject.ActiveRegions)
                {
                        context.Writer.Write(requestObjectActiveRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAdditionalTimeRange())
            {
                context.Writer.WritePropertyName("AdditionalTimeRange");
                context.Writer.WriteObjectStart();

                var marshaller = SearchContactsAdditionalTimeRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.AdditionalTimeRange, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAgentHierarchyGroups())
            {
                context.Writer.WritePropertyName("AgentHierarchyGroups");
                context.Writer.WriteObjectStart();

                var marshaller = AgentHierarchyGroupsMarshaller.Instance;
                marshaller.Marshall(requestObject.AgentHierarchyGroups, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAgentIds())
            {
                context.Writer.WritePropertyName("AgentIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAgentIdsListValue in requestObject.AgentIds)
                {
                        context.Writer.Write(requestObjectAgentIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetChannels())
            {
                context.Writer.WritePropertyName("Channels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectChannelsListValue in requestObject.Channels)
                {
                        context.Writer.Write(requestObjectChannelsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetContactAnalysis())
            {
                context.Writer.WritePropertyName("ContactAnalysis");
                context.Writer.WriteObjectStart();

                var marshaller = ContactAnalysisMarshaller.Instance;
                marshaller.Marshall(requestObject.ContactAnalysis, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContactTags())
            {
                context.Writer.WritePropertyName("ContactTags");
                context.Writer.WriteObjectStart();

                var marshaller = ControlPlaneTagFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ContactTags, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInitiationMethods())
            {
                context.Writer.WritePropertyName("InitiationMethods");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInitiationMethodsListValue in requestObject.InitiationMethods)
                {
                        context.Writer.Write(requestObjectInitiationMethodsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteObjectStart();

                var marshaller = NameCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.Name, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetQueueIds())
            {
                context.Writer.WritePropertyName("QueueIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectQueueIdsListValue in requestObject.QueueIds)
                {
                        context.Writer.Write(requestObjectQueueIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRoutingCriteria())
            {
                context.Writer.WritePropertyName("RoutingCriteria");
                context.Writer.WriteObjectStart();

                var marshaller = SearchableRoutingCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.RoutingCriteria, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSearchableContactAttributes())
            {
                context.Writer.WritePropertyName("SearchableContactAttributes");
                context.Writer.WriteObjectStart();

                var marshaller = SearchableContactAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.SearchableContactAttributes, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSearchableSegmentAttributes())
            {
                context.Writer.WritePropertyName("SearchableSegmentAttributes");
                context.Writer.WriteObjectStart();

                var marshaller = SearchableSegmentAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.SearchableSegmentAttributes, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchCriteriaMarshaller Instance = new SearchCriteriaMarshaller();

    }
}