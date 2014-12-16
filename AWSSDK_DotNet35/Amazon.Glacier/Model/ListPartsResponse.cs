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
    /// Configuration for accessing Amazon ListParts service
    /// </summary>
    public partial class ListPartsResponse : ListPartsResult, IPageableResponse<PartListElement, ListPartsRequest>
    {
        /// <summary>
        /// Gets and sets the ListPartsResult property.
        /// Represents the output of a ListParts operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ListPartsResult class are now available on the ListPartsResponse class. You should use the properties on ListPartsResponse instead of accessing them through ListPartsResult.")]
        public ListPartsResult ListPartsResult
        {
            get
            {
                return this;
            }
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        bool IPageableResponse<PartListElement, ListPartsRequest>.MoreResultsAvailable()
        {
            return !String.IsNullOrEmpty(this.Marker);
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        void IPageableResponse<PartListElement, ListPartsRequest>.SetPaginationTokens(ListPartsRequest request)
        {
            
            request.Marker = this.Marker;
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        IEnumerable<PartListElement> IPageableResponse<PartListElement, ListPartsRequest>.SelectResult()
        {
            return this.Parts;
        }
    }
}