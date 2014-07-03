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
    /// Container for the parameters to the ListAccountAliases operation.
    /// Lists the account aliases associated with the account. For information about using
    /// an AWS            account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html"
    /// target="_blank">Using an Alias for Your AWS Account ID</a> in <i>Using AWS Identity
    /// and                Access Management</i>.
    /// 
    ///         
    /// <para>
    /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
    /// </para>
    /// </summary>
    public partial class ListAccountAliasesRequest : AmazonIdentityManagementServiceRequest
    {
        private string _marker;
        private int? _maxItems;


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
        /// Use this only when paginating results to indicate the maximum number of account aliases
        /// you            want in the response. If there are additional account aliases beyond the maximum
        /// you specify,            the <code>IsTruncated</code> response element is <code>true</code>.
        /// This parameter is            optional. If you do not include it, it defaults to 100.
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