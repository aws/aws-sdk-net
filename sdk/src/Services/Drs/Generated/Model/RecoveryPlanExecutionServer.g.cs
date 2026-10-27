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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ImpactLevel. Defaults to CRITICAL if not specified.
        /// </summary>
        public RecoveryPlanServerImpactLevel ImpactLevel { get; set; }

        /// <summary>
        /// Checks to see if the ImpactLevel property is set.
        /// </summary>
        internal bool IsSetImpactLevel() => this.ImpactLevel != null;

        /// <summary>
        /// Gets and sets the property JobID. The DRS recovery job ID. Populated when recovery
        /// is initiated for this server.
        /// </summary>
        [AWSProperty(Min = 24, Max = 24)]
        public string JobID { get; set; }

        /// <summary>
        /// Checks to see if the JobID property is set.
        /// </summary>
        internal bool IsSetJobID() => this.JobID != null;

        /// <summary>
        /// Gets and sets the property ServerArn. 
        /// <para>
        /// The ARN of the source server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ServerArn { get; set; }

        /// <summary>
        /// Checks to see if the ServerArn property is set.
        /// </summary>
        internal bool IsSetServerArn() => this.ServerArn != null;
    }
}
