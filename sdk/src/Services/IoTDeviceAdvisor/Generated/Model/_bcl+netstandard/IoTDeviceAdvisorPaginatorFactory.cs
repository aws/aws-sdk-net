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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Paginators for the IoTDeviceAdvisor service
    ///</summary>
    public class IoTDeviceAdvisorPaginatorFactory : IIoTDeviceAdvisorPaginatorFactory
    {
        private readonly IAmazonIoTDeviceAdvisor client;

        internal IoTDeviceAdvisorPaginatorFactory(IAmazonIoTDeviceAdvisor client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListSuiteDefinitions operation
        ///</summary>
        public IListSuiteDefinitionsPaginator ListSuiteDefinitions(ListSuiteDefinitionsRequest request) 
        {
            return new ListSuiteDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSuiteRuns operation
        ///</summary>
        public IListSuiteRunsPaginator ListSuiteRuns(ListSuiteRunsRequest request) 
        {
            return new ListSuiteRunsPaginator(this.client, request);
        }
    }
}