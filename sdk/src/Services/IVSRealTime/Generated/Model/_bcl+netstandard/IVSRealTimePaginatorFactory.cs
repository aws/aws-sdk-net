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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Paginators for the IVSRealTime service
    ///</summary>
    public class IVSRealTimePaginatorFactory : IIVSRealTimePaginatorFactory
    {
        private readonly IAmazonIVSRealTime client;

        internal IVSRealTimePaginatorFactory(IAmazonIVSRealTime client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCompositions operation
        ///</summary>
        public IListCompositionsPaginator ListCompositions(ListCompositionsRequest request) 
        {
            return new ListCompositionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEncoderConfigurations operation
        ///</summary>
        public IListEncoderConfigurationsPaginator ListEncoderConfigurations(ListEncoderConfigurationsRequest request) 
        {
            return new ListEncoderConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIngestConfigurations operation
        ///</summary>
        public IListIngestConfigurationsPaginator ListIngestConfigurations(ListIngestConfigurationsRequest request) 
        {
            return new ListIngestConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListParticipantEvents operation
        ///</summary>
        public IListParticipantEventsPaginator ListParticipantEvents(ListParticipantEventsRequest request) 
        {
            return new ListParticipantEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListParticipantReplicas operation
        ///</summary>
        public IListParticipantReplicasPaginator ListParticipantReplicas(ListParticipantReplicasRequest request) 
        {
            return new ListParticipantReplicasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListParticipants operation
        ///</summary>
        public IListParticipantsPaginator ListParticipants(ListParticipantsRequest request) 
        {
            return new ListParticipantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPublicKeys operation
        ///</summary>
        public IListPublicKeysPaginator ListPublicKeys(ListPublicKeysRequest request) 
        {
            return new ListPublicKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStages operation
        ///</summary>
        public IListStagesPaginator ListStages(ListStagesRequest request) 
        {
            return new ListStagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStageSessions operation
        ///</summary>
        public IListStageSessionsPaginator ListStageSessions(ListStageSessionsRequest request) 
        {
            return new ListStageSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStorageConfigurations operation
        ///</summary>
        public IListStorageConfigurationsPaginator ListStorageConfigurations(ListStorageConfigurationsRequest request) 
        {
            return new ListStorageConfigurationsPaginator(this.client, request);
        }
    }
}