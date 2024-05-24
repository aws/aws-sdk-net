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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Paginators for the MedicalImaging service
    ///</summary>
    public class MedicalImagingPaginatorFactory : IMedicalImagingPaginatorFactory
    {
        private readonly IAmazonMedicalImaging client;

        internal MedicalImagingPaginatorFactory(IAmazonMedicalImaging client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDatastores operation
        ///</summary>
        public IListDatastoresPaginator ListDatastores(ListDatastoresRequest request) 
        {
            return new ListDatastoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDICOMImportJobs operation
        ///</summary>
        public IListDICOMImportJobsPaginator ListDICOMImportJobs(ListDICOMImportJobsRequest request) 
        {
            return new ListDICOMImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImageSetVersions operation
        ///</summary>
        public IListImageSetVersionsPaginator ListImageSetVersions(ListImageSetVersionsRequest request) 
        {
            return new ListImageSetVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchImageSets operation
        ///</summary>
        public ISearchImageSetsPaginator SearchImageSets(SearchImageSetsRequest request) 
        {
            return new SearchImageSetsPaginator(this.client, request);
        }
    }
}