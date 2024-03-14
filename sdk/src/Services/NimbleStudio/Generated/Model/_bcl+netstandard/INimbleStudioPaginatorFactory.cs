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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Paginators for the NimbleStudio service
    ///</summary>
    public interface INimbleStudioPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListEulaAcceptances operation
        ///</summary>
        IListEulaAcceptancesPaginator ListEulaAcceptances(ListEulaAcceptancesRequest request);

        /// <summary>
        /// Paginator for ListEulas operation
        ///</summary>
        IListEulasPaginator ListEulas(ListEulasRequest request);

        /// <summary>
        /// Paginator for ListLaunchProfileMembers operation
        ///</summary>
        IListLaunchProfileMembersPaginator ListLaunchProfileMembers(ListLaunchProfileMembersRequest request);

        /// <summary>
        /// Paginator for ListLaunchProfiles operation
        ///</summary>
        IListLaunchProfilesPaginator ListLaunchProfiles(ListLaunchProfilesRequest request);

        /// <summary>
        /// Paginator for ListStreamingImages operation
        ///</summary>
        IListStreamingImagesPaginator ListStreamingImages(ListStreamingImagesRequest request);

        /// <summary>
        /// Paginator for ListStreamingSessionBackups operation
        ///</summary>
        IListStreamingSessionBackupsPaginator ListStreamingSessionBackups(ListStreamingSessionBackupsRequest request);

        /// <summary>
        /// Paginator for ListStreamingSessions operation
        ///</summary>
        IListStreamingSessionsPaginator ListStreamingSessions(ListStreamingSessionsRequest request);

        /// <summary>
        /// Paginator for ListStudioComponents operation
        ///</summary>
        IListStudioComponentsPaginator ListStudioComponents(ListStudioComponentsRequest request);

        /// <summary>
        /// Paginator for ListStudioMembers operation
        ///</summary>
        IListStudioMembersPaginator ListStudioMembers(ListStudioMembersRequest request);

        /// <summary>
        /// Paginator for ListStudios operation
        ///</summary>
        IListStudiosPaginator ListStudios(ListStudiosRequest request);
    }
}