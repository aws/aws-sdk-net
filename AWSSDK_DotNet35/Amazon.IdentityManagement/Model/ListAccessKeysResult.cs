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
    /// Contains the response to a successful <a>ListAccessKeys</a> request.
    /// </summary>
    public partial class ListAccessKeysResult : AmazonWebServiceResponse
    {
        private List<AccessKeyMetadata> _accessKeyMetadata = new List<AccessKeyMetadata>();
        private bool? _isTruncated;
        private string _marker;

        /// <summary>
        /// Gets and sets the property AccessKeyMetadata. 
        /// <para>
        /// A list of access key metadata.
        /// </para>
        /// </summary>
        public List<AccessKeyMetadata> AccessKeyMetadata
        {
            get { return this._accessKeyMetadata; }
            set { this._accessKeyMetadata = value; }
        }

        // Check to see if AccessKeyMetadata property is set
        internal bool IsSetAccessKeyMetadata()
        {
            return this._accessKeyMetadata != null && this._accessKeyMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more items to return. If your results were
        /// truncated, you can make a subsequent pagination request using the <code>Marker</code>
        /// request parameter to retrieve more items. Note that IAM might return fewer than the
        /// <code>MaxItems</code> number of results even when there are more results available.
        /// We recommend that you check <code>IsTruncated</code> after every call to ensure that
        /// you receive all of your results.
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
        /// When <code>IsTruncated</code> is <code>true</code>, this element is present and contains
        /// the value to use for the <code>Marker</code> parameter in a subsequent pagination
        /// request.
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