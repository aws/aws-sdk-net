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
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListPlaybackKeyPairs operation
        ///</summary>
        IListPlaybackKeyPairsPaginator ListPlaybackKeyPairs(ListPlaybackKeyPairsRequest request);

        /// <summary>
        /// Paginator for ListRecordingConfigurations operation
        ///</summary>
        IListRecordingConfigurationsPaginator ListRecordingConfigurations(ListRecordingConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListStreamKeys operation
        ///</summary>
        IListStreamKeysPaginator ListStreamKeys(ListStreamKeysRequest request);

        /// <summary>
        /// Paginator for ListStreams operation
        ///</summary>
        IListStreamsPaginator ListStreams(ListStreamsRequest request);
    }
}