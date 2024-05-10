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
 * Do not modify this file. This file is generated from the support-app-2021-08-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SupportApp.Model
{
    /// <summary>
    /// Paginators for the SupportApp service
    ///</summary>
    public class SupportAppPaginatorFactory : ISupportAppPaginatorFactory
    {
        private readonly IAmazonSupportApp client;

        internal SupportAppPaginatorFactory(IAmazonSupportApp client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListSlackChannelConfigurations operation
        ///</summary>
        public IListSlackChannelConfigurationsPaginator ListSlackChannelConfigurations(ListSlackChannelConfigurationsRequest request) 
        {
            return new ListSlackChannelConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSlackWorkspaceConfigurations operation
        ///</summary>
        public IListSlackWorkspaceConfigurationsPaginator ListSlackWorkspaceConfigurations(ListSlackWorkspaceConfigurationsRequest request) 
        {
            return new ListSlackWorkspaceConfigurationsPaginator(this.client, request);
        }
    }
}