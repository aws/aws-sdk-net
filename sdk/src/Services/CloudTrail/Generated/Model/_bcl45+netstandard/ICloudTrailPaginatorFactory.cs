#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Paginators for the CloudTrail service
    ///</summary>
    public interface ICloudTrailPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListPublicKeys operation
        ///</summary>
        IListPublicKeysPaginator ListPublicKeys(ListPublicKeysRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        IListTagsPaginator ListTags(ListTagsRequest request);

        /// <summary>
        /// Paginator for ListTrails operation
        ///</summary>
        IListTrailsPaginator ListTrails(ListTrailsRequest request);

        /// <summary>
        /// Paginator for LookupEvents operation
        ///</summary>
        ILookupEventsPaginator LookupEvents(LookupEventsRequest request);
    }
}
#endif