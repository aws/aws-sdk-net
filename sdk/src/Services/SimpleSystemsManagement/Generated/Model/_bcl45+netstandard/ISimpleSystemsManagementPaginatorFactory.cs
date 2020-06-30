#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Paginators for the SimpleSystemsManagement service
    ///</summary>
    public interface ISimpleSystemsManagementPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeActivations operation
        ///</summary>
        IDescribeActivationsPaginator DescribeActivations(DescribeActivationsRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceInformation operation
        ///</summary>
        IDescribeInstanceInformationPaginator DescribeInstanceInformation(DescribeInstanceInformationRequest request);

        /// <summary>
        /// Paginator for DescribeParameters operation
        ///</summary>
        IDescribeParametersPaginator DescribeParameters(DescribeParametersRequest request);

        /// <summary>
        /// Paginator for GetParameterHistory operation
        ///</summary>
        IGetParameterHistoryPaginator GetParameterHistory(GetParameterHistoryRequest request);

        /// <summary>
        /// Paginator for GetParametersByPath operation
        ///</summary>
        IGetParametersByPathPaginator GetParametersByPath(GetParametersByPathRequest request);

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        IListAssociationsPaginator ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCommandInvocations operation
        ///</summary>
        IListCommandInvocationsPaginator ListCommandInvocations(ListCommandInvocationsRequest request);

        /// <summary>
        /// Paginator for ListCommands operation
        ///</summary>
        IListCommandsPaginator ListCommands(ListCommandsRequest request);

        /// <summary>
        /// Paginator for ListDocuments operation
        ///</summary>
        IListDocumentsPaginator ListDocuments(ListDocumentsRequest request);
    }
}
#endif