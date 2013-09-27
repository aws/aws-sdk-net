/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the ListInvalidations operation.
    /// <para> List invalidation batches. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListInvalidations"/>
    public class ListInvalidationsRequest : AmazonWebServiceRequest
    {
        private string distributionId;
        private string marker;
        private string maxItems;

        /// <summary>
        /// The distribution's id.
        ///  
        /// </summary>
        public string DistributionId
        {
            get { return this.distributionId; }
            set { this.distributionId = value; }
        }

        /// <summary>
        /// Sets the DistributionId property
        /// </summary>
        /// <param name="distributionId">The value to set for the DistributionId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListInvalidationsRequest WithDistributionId(string distributionId)
        {
            this.distributionId = distributionId;
            return this;
        }
            

        // Check to see if DistributionId property is set
        internal bool IsSetDistributionId()
        {
            return this.distributionId != null;
        }

        /// <summary>
        /// Use this parameter when paginating results to indicate where to begin in your list of invalidation batches. Because the results are returned
        /// in decreasing order from most recent to oldest, the most recent results are on the first page, the second page will contain earlier results,
        /// and so on. To get the next page of results, set the Marker to the value of the NextMarker from the current page's response. This value is
        /// the same as the ID of the last invalidation batch on that page.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListInvalidationsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// The maximum number of invalidation batches you want in the response body.
        ///  
        /// </summary>
        public string MaxItems
        {
            get { return this.maxItems; }
            set { this.maxItems = value; }
        }

        /// <summary>
        /// Sets the MaxItems property
        /// </summary>
        /// <param name="maxItems">The value to set for the MaxItems property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListInvalidationsRequest WithMaxItems(string maxItems)
        {
            this.maxItems = maxItems;
            return this;
        }
            

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems != null;
        }
    }
}
    
