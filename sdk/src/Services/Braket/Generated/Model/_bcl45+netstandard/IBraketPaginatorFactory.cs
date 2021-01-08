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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Paginators for the Braket service
    ///</summary>
    public interface IBraketPaginatorFactory
    {

        /// <summary>
        /// Paginator for SearchDevices operation
        ///</summary>
        ISearchDevicesPaginator SearchDevices(SearchDevicesRequest request);

        /// <summary>
        /// Paginator for SearchQuantumTasks operation
        ///</summary>
        ISearchQuantumTasksPaginator SearchQuantumTasks(SearchQuantumTasksRequest request);
    }
}
#endif