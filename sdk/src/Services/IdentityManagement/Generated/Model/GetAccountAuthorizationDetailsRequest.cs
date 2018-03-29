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
    /// Retrieves information about all IAM users, groups, roles, and policies in your AWS
    /// account, including their relationships to one another. Use this API to obtain a snapshot
    /// of the configuration of IAM permissions (users, groups, roles, and policies) in your
    /// account.
    /// 
    ///  <note> 
    /// <para>
    /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
    /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
    /// text. For example, if you use Java, you can use the <code>decode</code> method of
    /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
    /// and SDKs provide similar functionality.
    /// </para>
    ///  </note> 
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
        /// A list of entity types used to filter the results. Only the entities that match the
        /// types you specify are included in the output. Use the value <code>LocalManagedPolicy</code>
        /// to include customer managed policies.
        /// </para>
        ///  
        /// <para>
        /// The format for this parameter is a comma-separated (if more than one) list of strings.
        /// Each string value in the list must be one of the valid values listed below.
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
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response that you received to indicate where the next call should start.
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
        /// (Optional) Use this only when paginating results to indicate the maximum number of
        /// items you want in the response. If additional items exist beyond the maximum you specify,
        /// the <code>IsTruncated</code> response element is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If you do not include this parameter, it defaults to 100. Note that IAM might return
        /// fewer results, even when there are more results available. In that case, the <code>IsTruncated</code>
        /// response element returns <code>true</code> and <code>Marker</code> contains a value
        /// to include in the subsequent call that tells the service where to continue from.
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