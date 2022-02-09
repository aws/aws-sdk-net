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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the ListRecoveryGroups operation.
    /// </summary>
    public partial class ListRecoveryGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RecoveryGroupOutput> _recoveryGroups = new List<RecoveryGroupOutput>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that identifies which batch of results you want to see.
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
        /// Gets and sets the property RecoveryGroups. 
        /// <para>
        /// A list of recovery groups.
        /// </para>
        /// </summary>
        public List<RecoveryGroupOutput> RecoveryGroups
        {
            get { return this._recoveryGroups; }
            set { this._recoveryGroups = value; }
        }

        // Check to see if RecoveryGroups property is set
        internal bool IsSetRecoveryGroups()
        {
            return this._recoveryGroups != null && this._recoveryGroups.Count > 0; 
        }

    }
}