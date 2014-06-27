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
    /// Container for the parameters to the ListCloudFrontOriginAccessIdentities operation.
    /// List origin access identities.
    /// </summary>
    public partial class ListCloudFrontOriginAccessIdentitiesRequest : AmazonWebServiceRequest
    {
        private string _marker;
        private string _maxItems;


        /// <summary>
        /// Gets and sets the property Marker. Use this when paginating results to indicate where
        /// to begin in your list of origin access identities. The results include identities
        /// in the list that occur after the marker.    To get the next page of results, set the
        /// Marker to the value of the NextMarker from the current page's response (which is also
        /// the ID of the last identity on that page).
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListCloudFrontOriginAccessIdentitiesRequest WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property MaxItems. The maximum number of origin access identities
        /// you want in the response body.
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }


        /// <summary>
        /// Sets the MaxItems property
        /// </summary>
        /// <param name="maxItems">The value to set for the MaxItems property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListCloudFrontOriginAccessIdentitiesRequest WithMaxItems(string maxItems)
        {
            this._maxItems = maxItems;
            return this;
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}