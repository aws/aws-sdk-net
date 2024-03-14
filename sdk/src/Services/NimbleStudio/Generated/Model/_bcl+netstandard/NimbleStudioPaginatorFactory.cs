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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Paginators for the NimbleStudio service
    ///</summary>
    public class NimbleStudioPaginatorFactory : INimbleStudioPaginatorFactory
    {
        private readonly IAmazonNimbleStudio client;

        internal NimbleStudioPaginatorFactory(IAmazonNimbleStudio client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEulaAcceptances operation
        ///</summary>
        public IListEulaAcceptancesPaginator ListEulaAcceptances(ListEulaAcceptancesRequest request) 
        {
            return new ListEulaAcceptancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEulas operation
        ///</summary>
        public IListEulasPaginator ListEulas(ListEulasRequest request) 
        {
            return new ListEulasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLaunchProfileMembers operation
        ///</summary>
        public IListLaunchProfileMembersPaginator ListLaunchProfileMembers(ListLaunchProfileMembersRequest request) 
        {
            return new ListLaunchProfileMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLaunchProfiles operation
        ///</summary>
        public IListLaunchProfilesPaginator ListLaunchProfiles(ListLaunchProfilesRequest request) 
        {
            return new ListLaunchProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamingImages operation
        ///</summary>
        public IListStreamingImagesPaginator ListStreamingImages(ListStreamingImagesRequest request) 
        {
            return new ListStreamingImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamingSessionBackups operation
        ///</summary>
        public IListStreamingSessionBackupsPaginator ListStreamingSessionBackups(ListStreamingSessionBackupsRequest request) 
        {
            return new ListStreamingSessionBackupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamingSessions operation
        ///</summary>
        public IListStreamingSessionsPaginator ListStreamingSessions(ListStreamingSessionsRequest request) 
        {
            return new ListStreamingSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStudioComponents operation
        ///</summary>
        public IListStudioComponentsPaginator ListStudioComponents(ListStudioComponentsRequest request) 
        {
            return new ListStudioComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStudioMembers operation
        ///</summary>
        public IListStudioMembersPaginator ListStudioMembers(ListStudioMembersRequest request) 
        {
            return new ListStudioMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStudios operation
        ///</summary>
        public IListStudiosPaginator ListStudios(ListStudiosRequest request) 
        {
            return new ListStudiosPaginator(this.client, request);
        }
    }
}