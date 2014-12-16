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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Configuration for accessing Amazon ListJobs service
    /// </summary>
    public partial class ListJobsResponse : ListJobsResult, IPageableResponse<GlacierJobDescription, ListJobsRequest>
    {
        /// <summary>
        /// Gets and sets the ListJobsResult property.
        /// Represents the output of a ListJobs operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ListJobsResult class are now available on the ListJobsResponse class. You should use the properties on ListJobsResponse instead of accessing them through ListJobsResult.")]
        public ListJobsResult ListJobsResult
        {
            get
            {
                return this;
            }
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        bool IPageableResponse<GlacierJobDescription, ListJobsRequest>.MoreResultsAvailable()
        {
            return !String.IsNullOrEmpty(this.Marker);
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        void IPageableResponse<GlacierJobDescription, ListJobsRequest>.SetPaginationTokens(ListJobsRequest request)
        {
            
            request.Marker = this.Marker;
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        IEnumerable<GlacierJobDescription> IPageableResponse<GlacierJobDescription, ListJobsRequest>.SelectResult()
        {
            return this.JobList;
        }
    }
}