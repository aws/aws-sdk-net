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
 * Do not modify this file. This file is generated from the cloudfront-2016-01-28.normal.json service model.
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
    /// Container for the parameters to the ListDistributionsByWebACLId operation.
    /// List the distributions that are associated with a specified AWS WAF web ACL.
    /// </summary>
    public partial class ListDistributionsByWebACLIdRequest : AmazonCloudFrontRequest
    {
        private string _marker;
        private string _maxItems;
        private string _webACLId;

        /// <summary>
        /// Gets and sets the property Marker. Use Marker and MaxItems to control pagination of
        /// results. If you have more than MaxItems distributions that satisfy the request, the
        /// response includes a NextMarker element. To get the next page of results, submit another
        /// request. For the value of Marker, specify the value of NextMarker from the last response.
        /// (For the first request, omit Marker.)
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
        /// Gets and sets the property MaxItems. The maximum number of distributions that you
        /// want CloudFront to return in the response body. The maximum and default values are
        /// both 100.
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

        /// <summary>
        /// Gets and sets the property WebACLId. The Id of the AWS WAF web ACL for which you want
        /// to list the associated distributions. If you specify "null" for the Id, the request
        /// returns a list of the distributions that aren't associated with a web ACL.
        /// </summary>
        public string WebACLId
        {
            get { return this._webACLId; }
            set { this._webACLId = value; }
        }

        // Check to see if WebACLId property is set
        internal bool IsSetWebACLId()
        {
            return this._webACLId != null;
        }

    }
}