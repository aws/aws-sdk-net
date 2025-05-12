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
    /// Container for the parameters to the ListConnectionGroups operation.
    /// Lists the connection groups in your Amazon Web Services account.
    /// </summary>
    public partial class ListConnectionGroupsRequest : AmazonCloudFrontRequest
    {
        private ConnectionGroupAssociationFilter _associationFilter;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property AssociationFilter. 
        /// <para>
        /// Filter by associated Anycast IP list ID.
        /// </para>
        /// </summary>
        public ConnectionGroupAssociationFilter AssociationFilter
        {
            get { return this._associationFilter; }
            set { this._associationFilter = value; }
        }

        // Check to see if AssociationFilter property is set
        internal bool IsSetAssociationFilter()
        {
            return this._associationFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of connection groups to retrieve.
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
        /// The maximum number of connection groups to return.
        /// </para>
        /// </summary>
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}