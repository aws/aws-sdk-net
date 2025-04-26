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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Paginators for the VoiceID service
    ///</summary>
    public interface IVoiceIDPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListFraudsterRegistrationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFraudsterRegistrationJobsPaginator ListFraudsterRegistrationJobs(ListFraudsterRegistrationJobsRequest request);

        /// <summary>
        /// Paginator for ListFraudsters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFraudstersPaginator ListFraudsters(ListFraudstersRequest request);

        /// <summary>
        /// Paginator for ListSpeakerEnrollmentJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSpeakerEnrollmentJobsPaginator ListSpeakerEnrollmentJobs(ListSpeakerEnrollmentJobsRequest request);

        /// <summary>
        /// Paginator for ListSpeakers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSpeakersPaginator ListSpeakers(ListSpeakersRequest request);

        /// <summary>
        /// Paginator for ListWatchlists operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWatchlistsPaginator ListWatchlists(ListWatchlistsRequest request);
    }
}