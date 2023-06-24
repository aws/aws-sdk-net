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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the ListRecoveryPointsByLegalHold operation.
    /// </summary>
    public partial class ListRecoveryPointsByLegalHoldResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RecoveryPointMember> _recoveryPoints = new List<RecoveryPointMember>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// This return is the next item following a partial list of returned resources.
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
        /// Gets and sets the property RecoveryPoints. 
        /// <para>
        /// This is a list of the recovery points returned by <code>ListRecoveryPointsByLegalHold</code>.
        /// </para>
        /// </summary>
        public List<RecoveryPointMember> RecoveryPoints
        {
            get { return this._recoveryPoints; }
            set { this._recoveryPoints = value; }
        }

        // Check to see if RecoveryPoints property is set
        internal bool IsSetRecoveryPoints()
        {
            return this._recoveryPoints != null && this._recoveryPoints.Count > 0; 
        }

    }
}