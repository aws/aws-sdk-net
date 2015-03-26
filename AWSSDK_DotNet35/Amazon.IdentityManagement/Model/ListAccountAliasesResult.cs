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
    /// Contains the response to a successful <a>ListAccountAliases</a> request.
    /// </summary>
    public partial class ListAccountAliasesResult : AmazonWebServiceResponse
    {
        private List<string> _accountAliases = new List<string>();
        private bool? _isTruncated;
        private string _marker;

        /// <summary>
        /// Gets and sets the property AccountAliases. 
        /// <para>
        /// A list of aliases associated with the account.
        /// </para>
        /// </summary>
        public List<string> AccountAliases
        {
            get { return this._accountAliases; }
            set { this._accountAliases = value; }
        }

        // Check to see if AccountAliases property is set
        internal bool IsSetAccountAliases()
        {
            return this._accountAliases != null && this._accountAliases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        ///  A flag that indicates whether there are more account aliases to list. If your results
        /// were truncated, you can make a subsequent pagination request using the <code>Marker</code>
        /// request parameter to retrieve more account aliases in the list. 
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  Use this only when paginating results, and only in a subsequent request after you've
        /// received a response where the results are truncated. Set it to the value of the <code>Marker</code>
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

    }
}