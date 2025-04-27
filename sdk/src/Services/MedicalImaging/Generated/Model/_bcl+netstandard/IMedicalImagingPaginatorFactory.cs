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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Paginators for the MedicalImaging service
    ///</summary>
    public interface IMedicalImagingPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDatastores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatastoresPaginator ListDatastores(ListDatastoresRequest request);

        /// <summary>
        /// Paginator for ListDICOMImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDICOMImportJobsPaginator ListDICOMImportJobs(ListDICOMImportJobsRequest request);

        /// <summary>
        /// Paginator for ListImageSetVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImageSetVersionsPaginator ListImageSetVersions(ListImageSetVersionsRequest request);

        /// <summary>
        /// Paginator for SearchImageSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchImageSetsPaginator SearchImageSets(SearchImageSetsRequest request);
    }
}