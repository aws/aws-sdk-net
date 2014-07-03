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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListGroupPolicies operation.
    /// Lists the names of the policies associated with the specified group. If there are
    /// none, the            action returns an empty list.
    /// 
    ///         
    /// <para>
    /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
    /// </para>
    /// </summary>
    public partial class ListGroupPoliciesRequest : AmazonIdentityManagementServiceRequest
    {
        private string _groupName;
        private string _marker;
        private int? _maxItems;


        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group to list policies for.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this only when paginating results, and only in a subsequent request after you've
        /// received            a response where the results are truncated. Set it to the value of the
        /// <code>Marker</code>            element in the response you just received.
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
        /// Use this only when paginating results to indicate the maximum number of policy names
        /// you want            in the response. If there are additional policy names beyond the maximum
        /// you specify, the                <code>IsTruncated</code> response element is <code>true</code>.
        /// This parameter is optional.            If you do not include it, it defaults to 100.
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