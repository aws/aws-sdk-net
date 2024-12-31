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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the ListDistributionsByAnycastIpListId operation.
    /// Lists the distributions in your account that are associated with the specified <c>AnycastIpListId</c>.
    /// </summary>
    public partial class ListDistributionsByAnycastIpListIdRequest : AmazonCloudFrontRequest
    {
        private string _anycastIpListId;
        private string _marker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property AnycastIpListId. 
        /// <para>
        /// The ID of the Anycast static IP list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnycastIpListId
        {
            get { return this._anycastIpListId; }
            set { this._anycastIpListId = value; }
        }

        // Check to see if AnycastIpListId property is set
        internal bool IsSetAnycastIpListId()
        {
            return this._anycastIpListId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this field when paginating results to indicate where to begin in your list. The
        /// response includes items in the list that occur after the marker. To get the next page
        /// of the list, set this field's value to the value of <c>NextMarker</c> from the current
        /// page's response.
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
        /// The maximum number of distributions that you want returned in the response.
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