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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// A set of filters by which to return Recovery Instances.
    /// </summary>
    public partial class DescribeRecoveryInstancesRequestFilters
    {
        private List<string> _recoveryInstanceIDs = new List<string>();
        private List<string> _sourceServerIDs = new List<string>();

        /// <summary>
        /// Gets and sets the property RecoveryInstanceIDs. 
        /// <para>
        /// An array of Recovery Instance IDs that should be returned. An empty array means all
        /// Recovery Instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> RecoveryInstanceIDs
        {
            get { return this._recoveryInstanceIDs; }
            set { this._recoveryInstanceIDs = value; }
        }

        // Check to see if RecoveryInstanceIDs property is set
        internal bool IsSetRecoveryInstanceIDs()
        {
            return this._recoveryInstanceIDs != null && this._recoveryInstanceIDs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceServerIDs. 
        /// <para>
        /// An array of Source Server IDs for which associated Recovery Instances should be returned.
        /// </para>
        /// </summary>
        public List<string> SourceServerIDs
        {
            get { return this._sourceServerIDs; }
            set { this._sourceServerIDs = value; }
        }

        // Check to see if SourceServerIDs property is set
        internal bool IsSetSourceServerIDs()
        {
            return this._sourceServerIDs != null && this._sourceServerIDs.Count > 0; 
        }

    }
}