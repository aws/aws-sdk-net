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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the ListFieldLevelEncryptionProfiles operation.
    /// Request a list of field-level encryption profiles that have been created in CloudFront
    /// for this account.
    /// </summary>
    public partial class ListFieldLevelEncryptionProfilesRequest : AmazonCloudFrontRequest
    {
        private string _marker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this when paginating results to indicate where to begin in your list of profiles.
        /// The results include profiles in the list that occur after the marker. To get the next
        /// page of results, set the <code>Marker</code> to the value of the <code>NextMarker</code>
        /// from the current page's response (which is also the ID of the last profile on that
        /// page).
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of field-level encryption profiles you want in the response body.
        /// 
        /// </para>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}