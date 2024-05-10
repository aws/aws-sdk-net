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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesThinClient.Model
{
    /// <summary>
    /// Paginators for the WorkSpacesThinClient service
    ///</summary>
    public interface IWorkSpacesThinClientPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        IListDevicesPaginator ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListSoftwareSets operation
        ///</summary>
        IListSoftwareSetsPaginator ListSoftwareSets(ListSoftwareSetsRequest request);
    }
}