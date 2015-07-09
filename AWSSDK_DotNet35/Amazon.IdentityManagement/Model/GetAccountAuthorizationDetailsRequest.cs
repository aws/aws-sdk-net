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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccountAuthorizationDetails operation.
    /// Retrieves information about all IAM users, groups, roles, and policies in your account,
    /// including their relationships to one another. Use this API to obtain a snapshot of
    /// the configuration of IAM permissions (users, groups, roles, and policies) in your
    /// account.
    /// 
    ///  
    /// <para>
    /// You can optionally filter the results using the <code>Filter</code> parameter. You
    /// can paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
    /// </para>
    /// </summary>
    public partial class GetAccountAuthorizationDetailsRequest : AmazonIdentityManagementServiceRequest
    {
        private List<string> _filter = new List<string>();
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A list of entity types (user, group, role, local managed policy, or AWS managed policy)
        /// for filtering the results.
        /// </para>
        /// </summary>
        public List<string> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you have received a
        /// response where the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response you just received.
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
        /// Use this only when paginating results to indicate the maximum number of items you
        /// want in the response. If there are additional items beyond the maximum you specify,
        /// the <code>IsTruncated</code> response element is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you do not include it, it defaults to 100.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}