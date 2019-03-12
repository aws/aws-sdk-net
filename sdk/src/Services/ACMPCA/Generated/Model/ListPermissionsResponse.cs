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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// This is the response object from the ListPermissions operation.
    /// </summary>
    public partial class ListPermissionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Permission> _permissions = new List<Permission>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the list is truncated, this value is present and should be used for the <b>NextToken</b>
        /// parameter in a subsequent pagination request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// Summary information about each permission assigned by the specified private CA, including
        /// the action enabled, the policy provided, and the time of creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public List<Permission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

    }
}