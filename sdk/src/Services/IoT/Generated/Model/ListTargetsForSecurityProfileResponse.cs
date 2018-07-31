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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the ListTargetsForSecurityProfile operation.
    /// </summary>
    public partial class ListTargetsForSecurityProfileResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SecurityProfileTarget> _securityProfileTargets = new List<SecurityProfileTarget>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that can be used to retrieve the next set of results, or <code>null</code>
        /// if there are no additional results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SecurityProfileTargets. 
        /// <para>
        /// The thing groups to which the security profile is attached.
        /// </para>
        /// </summary>
        public List<SecurityProfileTarget> SecurityProfileTargets
        {
            get { return this._securityProfileTargets; }
            set { this._securityProfileTargets = value; }
        }

        // Check to see if SecurityProfileTargets property is set
        internal bool IsSetSecurityProfileTargets()
        {
            return this._securityProfileTargets != null && this._securityProfileTargets.Count > 0; 
        }

    }
}