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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// The cluster management and job scheduling software associated with the cluster.
    /// </summary>
    public partial class SchedulerRequest
    {
        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The software PCS uses to manage cluster scaling and job scheduling.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchedulerType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the specified scheduling software that PCS uses to manage cluster scaling
        /// and job scheduling. For more information, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/slurm-versions.html">Slurm
        /// versions in PCS</a> in the <i>PCS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>24.11 | 25.05 | 25.11 | 26.05</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
