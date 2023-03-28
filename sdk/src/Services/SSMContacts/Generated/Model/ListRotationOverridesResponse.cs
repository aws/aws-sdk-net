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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// This is the response object from the ListRotationOverrides operation.
    /// </summary>
    public partial class ListRotationOverridesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RotationOverride> _rotationOverrides = new List<RotationOverride>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. Use this token to get the next set
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property RotationOverrides. 
        /// <para>
        /// A list of rotation overrides in the specified time range.
        /// </para>
        /// </summary>
        public List<RotationOverride> RotationOverrides
        {
            get { return this._rotationOverrides; }
            set { this._rotationOverrides = value; }
        }

        // Check to see if RotationOverrides property is set
        internal bool IsSetRotationOverrides()
        {
            return this._rotationOverrides != null && this._rotationOverrides.Count > 0; 
        }

    }
}