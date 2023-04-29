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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Paginators for the VoiceID service
    ///</summary>
    public class VoiceIDPaginatorFactory : IVoiceIDPaginatorFactory
    {
        private readonly IAmazonVoiceID client;

        internal VoiceIDPaginatorFactory(IAmazonVoiceID client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFraudsterRegistrationJobs operation
        ///</summary>
        public IListFraudsterRegistrationJobsPaginator ListFraudsterRegistrationJobs(ListFraudsterRegistrationJobsRequest request) 
        {
            return new ListFraudsterRegistrationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFraudsters operation
        ///</summary>
        public IListFraudstersPaginator ListFraudsters(ListFraudstersRequest request) 
        {
            return new ListFraudstersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSpeakerEnrollmentJobs operation
        ///</summary>
        public IListSpeakerEnrollmentJobsPaginator ListSpeakerEnrollmentJobs(ListSpeakerEnrollmentJobsRequest request) 
        {
            return new ListSpeakerEnrollmentJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSpeakers operation
        ///</summary>
        public IListSpeakersPaginator ListSpeakers(ListSpeakersRequest request) 
        {
            return new ListSpeakersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWatchlists operation
        ///</summary>
        public IListWatchlistsPaginator ListWatchlists(ListWatchlistsRequest request) 
        {
            return new ListWatchlistsPaginator(this.client, request);
        }
    }
}