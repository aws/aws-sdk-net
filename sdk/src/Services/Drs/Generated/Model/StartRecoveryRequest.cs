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
    /// Container for the parameters to the StartRecovery operation.
    /// Launches Recovery Instances for the specified Source Servers. For each Source Server
    /// you may choose a point in time snapshot to launch from, or use an on demand snapshot.
    /// </summary>
    public partial class StartRecoveryRequest : AmazonDrsRequest
    {
        private bool? _isDrill;
        private List<StartRecoveryRequestSourceServer> _sourceServers = new List<StartRecoveryRequestSourceServer>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property IsDrill. 
        /// <para>
        /// Whether this Source Server Recovery operation is a drill or not.
        /// </para>
        /// </summary>
        public bool IsDrill
        {
            get { return this._isDrill.GetValueOrDefault(); }
            set { this._isDrill = value; }
        }

        // Check to see if IsDrill property is set
        internal bool IsSetIsDrill()
        {
            return this._isDrill.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceServers. 
        /// <para>
        /// The Source Servers that we want to start a Recovery Job for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public List<StartRecoveryRequestSourceServer> SourceServers
        {
            get { return this._sourceServers; }
            set { this._sourceServers = value; }
        }

        // Check to see if SourceServers property is set
        internal bool IsSetSourceServers()
        {
            return this._sourceServers != null && this._sourceServers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be associated with the Recovery Job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}