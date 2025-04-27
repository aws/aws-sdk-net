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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Paginators for the IVS service
    ///</summary>
    public interface IIVSPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListPlaybackKeyPairs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPlaybackKeyPairsPaginator ListPlaybackKeyPairs(ListPlaybackKeyPairsRequest request);

        /// <summary>
        /// Paginator for ListPlaybackRestrictionPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPlaybackRestrictionPoliciesPaginator ListPlaybackRestrictionPolicies(ListPlaybackRestrictionPoliciesRequest request);

        /// <summary>
        /// Paginator for ListRecordingConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecordingConfigurationsPaginator ListRecordingConfigurations(ListRecordingConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListStreamKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStreamKeysPaginator ListStreamKeys(ListStreamKeysRequest request);

        /// <summary>
        /// Paginator for ListStreams operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStreamsPaginator ListStreams(ListStreamsRequest request);

        /// <summary>
        /// Paginator for ListStreamSessions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStreamSessionsPaginator ListStreamSessions(ListStreamSessionsRequest request);
    }
}