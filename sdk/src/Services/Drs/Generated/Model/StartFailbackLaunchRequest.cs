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
    /// Container for the parameters to the StartFailbackLaunch operation.
    /// Initiates a Job for launching the machine that is being failed back to from the specified
    /// Recovery Instance. This will run conversion on the failback client and will reboot
    /// your machine, thus completing the failback process.
    /// </summary>
    public partial class StartFailbackLaunchRequest : AmazonDrsRequest
    {
        private List<string> _recoveryInstanceIDs = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property RecoveryInstanceIDs. 
        /// <para>
        /// The IDs of the Recovery Instance whose failback launch we want to request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be associated with the failback launch Job.
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