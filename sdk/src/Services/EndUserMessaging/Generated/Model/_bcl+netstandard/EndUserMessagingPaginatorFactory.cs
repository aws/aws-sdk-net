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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Paginators for the EndUserMessaging service
    ///</summary>
    public class EndUserMessagingPaginatorFactory : IEndUserMessagingPaginatorFactory
    {
        private readonly IAmazonEndUserMessaging client;

        internal EndUserMessagingPaginatorFactory(IAmazonEndUserMessaging client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBrandProfileAttributes operation
        ///</summary>
        public IListBrandProfileAttributesPaginator ListBrandProfileAttributes(ListBrandProfileAttributesRequest request) 
        {
            return new ListBrandProfileAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBrandProfiles operation
        ///</summary>
        public IListBrandProfilesPaginator ListBrandProfiles(ListBrandProfilesRequest request) 
        {
            return new ListBrandProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotifyCodeConfigurations operation
        ///</summary>
        public IListNotifyCodeConfigurationsPaginator ListNotifyCodeConfigurations(ListNotifyCodeConfigurationsRequest request) 
        {
            return new ListNotifyCodeConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRegistrationsFromBrandProfile operation
        ///</summary>
        public IListRegistrationsFromBrandProfilePaginator ListRegistrationsFromBrandProfile(ListRegistrationsFromBrandProfileRequest request) 
        {
            return new ListRegistrationsFromBrandProfilePaginator(this.client, request);
        }
    }
}