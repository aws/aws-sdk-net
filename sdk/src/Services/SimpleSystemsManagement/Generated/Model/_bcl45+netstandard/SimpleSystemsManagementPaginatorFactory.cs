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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Paginators for the SimpleSystemsManagement service
    ///</summary>
    public class SimpleSystemsManagementPaginatorFactory : ISimpleSystemsManagementPaginatorFactory
    {
        private readonly IAmazonSimpleSystemsManagement client;

        internal SimpleSystemsManagementPaginatorFactory(IAmazonSimpleSystemsManagement client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeActivations operation
        ///</summary>
        public IDescribeActivationsPaginator DescribeActivations(DescribeActivationsRequest request) 
        {
            return new DescribeActivationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceInformation operation
        ///</summary>
        public IDescribeInstanceInformationPaginator DescribeInstanceInformation(DescribeInstanceInformationRequest request) 
        {
            return new DescribeInstanceInformationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeParameters operation
        ///</summary>
        public IDescribeParametersPaginator DescribeParameters(DescribeParametersRequest request) 
        {
            return new DescribeParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetParameterHistory operation
        ///</summary>
        public IGetParameterHistoryPaginator GetParameterHistory(GetParameterHistoryRequest request) 
        {
            return new GetParameterHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetParametersByPath operation
        ///</summary>
        public IGetParametersByPathPaginator GetParametersByPath(GetParametersByPathRequest request) 
        {
            return new GetParametersByPathPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        public IListAssociationsPaginator ListAssociations(ListAssociationsRequest request) 
        {
            return new ListAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCommandInvocations operation
        ///</summary>
        public IListCommandInvocationsPaginator ListCommandInvocations(ListCommandInvocationsRequest request) 
        {
            return new ListCommandInvocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCommands operation
        ///</summary>
        public IListCommandsPaginator ListCommands(ListCommandsRequest request) 
        {
            return new ListCommandsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDocuments operation
        ///</summary>
        public IListDocumentsPaginator ListDocuments(ListDocumentsRequest request) 
        {
            return new ListDocumentsPaginator(this.client, request);
        }
    }
}
#endif