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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Drs.Model
{
    /// <summary>
    /// A server within a recovery plan execution step, enriched with execution state.
    /// </summary>
    public partial class RecoveryPlanExecutionServer
    {
        private RecoveryPlanServerImpactLevel _impactLevel;
        private string _jobid;
        private string _serverArn;

        /// <summary>
        /// Gets and sets the property ImpactLevel. 
        /// <para>
        /// Defaults to CRITICAL if not specified.
        /// </para>
        /// </summary>
        public RecoveryPlanServerImpactLevel ImpactLevel
        {
            get { return this._impactLevel; }
            set { this._impactLevel = value; }
        }

        // Check to see if ImpactLevel property is set
        internal bool IsSetImpactLevel()
        {
            return this._impactLevel != null;
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The DRS recovery job ID. Populated when recovery is initiated for this server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property ServerArn. 
        /// <para>
        /// The ARN of the source server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ServerArn
        {
            get { return this._serverArn; }
            set { this._serverArn = value; }
        }

        // Check to see if ServerArn property is set
        internal bool IsSetServerArn()
        {
            return this._serverArn != null;
        }

    }
}