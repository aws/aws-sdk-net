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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Paginators for the CustomerProfiles service
    ///</summary>
    public interface ICustomerProfilesPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetSimilarProfiles operation
        ///</summary>
        IGetSimilarProfilesPaginator GetSimilarProfiles(GetSimilarProfilesRequest request);

        /// <summary>
        /// Paginator for ListEventStreams operation
        ///</summary>
        IListEventStreamsPaginator ListEventStreams(ListEventStreamsRequest request);

        /// <summary>
        /// Paginator for ListEventTriggers operation
        ///</summary>
        IListEventTriggersPaginator ListEventTriggers(ListEventTriggersRequest request);

        /// <summary>
        /// Paginator for ListObjectTypeAttributes operation
        ///</summary>
        IListObjectTypeAttributesPaginator ListObjectTypeAttributes(ListObjectTypeAttributesRequest request);

        /// <summary>
        /// Paginator for ListRuleBasedMatches operation
        ///</summary>
        IListRuleBasedMatchesPaginator ListRuleBasedMatches(ListRuleBasedMatchesRequest request);

        /// <summary>
        /// Paginator for ListSegmentDefinitions operation
        ///</summary>
        IListSegmentDefinitionsPaginator ListSegmentDefinitions(ListSegmentDefinitionsRequest request);
    }
}