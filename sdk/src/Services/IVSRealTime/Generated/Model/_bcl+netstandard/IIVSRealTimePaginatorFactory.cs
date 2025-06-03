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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Paginators for the IVSRealTime service
    ///</summary>
    public interface IIVSRealTimePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListCompositions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCompositionsPaginator ListCompositions(ListCompositionsRequest request);

        /// <summary>
        /// Paginator for ListEncoderConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEncoderConfigurationsPaginator ListEncoderConfigurations(ListEncoderConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListIngestConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIngestConfigurationsPaginator ListIngestConfigurations(ListIngestConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListParticipantEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListParticipantEventsPaginator ListParticipantEvents(ListParticipantEventsRequest request);

        /// <summary>
        /// Paginator for ListParticipantReplicas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListParticipantReplicasPaginator ListParticipantReplicas(ListParticipantReplicasRequest request);

        /// <summary>
        /// Paginator for ListParticipants operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListParticipantsPaginator ListParticipants(ListParticipantsRequest request);

        /// <summary>
        /// Paginator for ListPublicKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPublicKeysPaginator ListPublicKeys(ListPublicKeysRequest request);

        /// <summary>
        /// Paginator for ListStages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStagesPaginator ListStages(ListStagesRequest request);

        /// <summary>
        /// Paginator for ListStageSessions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStageSessionsPaginator ListStageSessions(ListStageSessionsRequest request);

        /// <summary>
        /// Paginator for ListStorageConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStorageConfigurationsPaginator ListStorageConfigurations(ListStorageConfigurationsRequest request);
    }
}