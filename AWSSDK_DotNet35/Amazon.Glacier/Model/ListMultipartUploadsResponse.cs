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
    /// Configuration for accessing Amazon ListMultipartUploads service
    /// </summary>
    public partial class ListMultipartUploadsResponse : ListMultipartUploadsResult, IPageableResponse<UploadListElement, ListMultipartUploadsRequest>
    {
        /// <summary>
        /// Gets and sets the ListMultipartUploadsResult property.
        /// Represents the output of a ListMultipartUploads operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ListMultipartUploadsResult class are now available on the ListMultipartUploadsResponse class. You should use the properties on ListMultipartUploadsResponse instead of accessing them through ListMultipartUploadsResult.")]
        public ListMultipartUploadsResult ListMultipartUploadsResult
        {
            get
            {
                return this;
            }
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        bool IPageableResponse<UploadListElement, ListMultipartUploadsRequest>.MoreResultsAvailable()
        {
            return !String.IsNullOrEmpty(this.Marker);
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        void IPageableResponse<UploadListElement, ListMultipartUploadsRequest>.SetPaginationTokens(ListMultipartUploadsRequest request)
        {
            
            request.UploadIdMarker = this.Marker;
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        IEnumerable<UploadListElement> IPageableResponse<UploadListElement, ListMultipartUploadsRequest>.SelectResult()
        {
            return this.UploadsList;
        }
    }
}