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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// Paginators for the SSMQuickSetup service
    /// </summary>
    public interface ISSMQuickSetupPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListConfigurationManagers operation
        /// </summary>
        [AWSPaginator(InputToken = ["StartingToken"], LimitKey = "MaxItems", OutputToken = ["NextToken"])]
        IListConfigurationManagersPaginator ListConfigurationManagers(ListConfigurationManagersRequest request);

        /// <summary>
        /// Paginator for ListConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["StartingToken"], LimitKey = "MaxItems", OutputToken = ["NextToken"])]
        IListConfigurationsPaginator ListConfigurations(ListConfigurationsRequest request);
    }
}
