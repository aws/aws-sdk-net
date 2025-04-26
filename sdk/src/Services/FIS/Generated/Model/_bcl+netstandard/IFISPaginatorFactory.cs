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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Paginators for the FIS service
    ///</summary>
    public interface IFISPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListActionsPaginator ListActions(ListActionsRequest request);

        /// <summary>
        /// Paginator for ListExperimentResolvedTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExperimentResolvedTargetsPaginator ListExperimentResolvedTargets(ListExperimentResolvedTargetsRequest request);

        /// <summary>
        /// Paginator for ListExperiments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExperimentsPaginator ListExperiments(ListExperimentsRequest request);

        /// <summary>
        /// Paginator for ListExperimentTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExperimentTemplatesPaginator ListExperimentTemplates(ListExperimentTemplatesRequest request);

        /// <summary>
        /// Paginator for ListTargetAccountConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTargetAccountConfigurationsPaginator ListTargetAccountConfigurations(ListTargetAccountConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListTargetResourceTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTargetResourceTypesPaginator ListTargetResourceTypes(ListTargetResourceTypesRequest request);
    }
}