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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime.Internal;
using Amazon.Glacier.Model;

namespace Amazon.Glacier
{
    public partial class AmazonGlacierClient
    {

        #region ListJobsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListJobs operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonGlacierClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;GlacierJobDescription&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<GlacierJobDescription> ListJobsEnumerator(ListJobsRequest request)
        {
            return Paginator.Paginate<GlacierJobDescription, ListJobsRequest, ListJobsResponse>(request, this.ListJobs);
        }
      
        #endregion

        #region ListMultipartUploadsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation on AmazonGlacierClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;UploadListElement&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<UploadListElement> ListMultipartUploadsEnumerator(ListMultipartUploadsRequest request)
        {
            return Paginator.Paginate<UploadListElement, ListMultipartUploadsRequest, ListMultipartUploadsResponse>(request, this.ListMultipartUploads);
        }
      
        #endregion

        #region ListPartsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListParts operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation on AmazonGlacierClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;PartListElement&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<PartListElement> ListPartsEnumerator(ListPartsRequest request)
        {
            return Paginator.Paginate<PartListElement, ListPartsRequest, ListPartsResponse>(request, this.ListParts);
        }
      
        #endregion

        #region ListVaultsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListVaults operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVaults operation on AmazonGlacierClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;DescribeVaultOutput&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<DescribeVaultOutput> ListVaultsEnumerator(ListVaultsRequest request)
        {
            return Paginator.Paginate<DescribeVaultOutput, ListVaultsRequest, ListVaultsResponse>(request, this.ListVaults);
        }
      
        #endregion

 
    }

    public partial interface IAmazonGlacier
    {
        #region ListJobsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListJobs operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonGlacierClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;GlacierJobDescription&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<GlacierJobDescription> ListJobsEnumerator(ListJobsRequest request);
      
        #endregion

        #region ListMultipartUploadsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation on AmazonGlacierClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;UploadListElement&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<UploadListElement> ListMultipartUploadsEnumerator(ListMultipartUploadsRequest request);
      
        #endregion

        #region ListPartsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListParts operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation on AmazonGlacierClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;PartListElement&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<PartListElement> ListPartsEnumerator(ListPartsRequest request);
      
        #endregion

        #region ListVaultsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListVaults operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVaults operation on AmazonGlacierClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;DescribeVaultOutput&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<DescribeVaultOutput> ListVaultsEnumerator(ListVaultsRequest request);
      
        #endregion

 
    }
}