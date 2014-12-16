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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Configuration for accessing Amazon ListPlatformApplications service
    /// </summary>
    public partial class ListPlatformApplicationsResponse : ListPlatformApplicationsResult, IPageableResponse<PlatformApplication, ListPlatformApplicationsRequest>
    {
        /// <summary>
        /// Gets and sets the ListPlatformApplicationsResult property.
        /// Represents the output of a ListPlatformApplications operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ListPlatformApplicationsResult class are now available on the ListPlatformApplicationsResponse class. You should use the properties on ListPlatformApplicationsResponse instead of accessing them through ListPlatformApplicationsResult.")]
        public ListPlatformApplicationsResult ListPlatformApplicationsResult
        {
            get
            {
                return this;
            }
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        bool IPageableResponse<PlatformApplication, ListPlatformApplicationsRequest>.MoreResultsAvailable()
        {
            return !String.IsNullOrEmpty(this.NextToken);
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        void IPageableResponse<PlatformApplication, ListPlatformApplicationsRequest>.SetPaginationTokens(ListPlatformApplicationsRequest request)
        {
            
            request.NextToken = this.NextToken;
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        IEnumerable<PlatformApplication> IPageableResponse<PlatformApplication, ListPlatformApplicationsRequest>.SelectResult()
        {
            return this.PlatformApplications;
        }
    }
}