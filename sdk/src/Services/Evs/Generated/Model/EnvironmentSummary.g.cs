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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// A list of environments with summarized environment details.
    /// </summary>
    public partial class EnvironmentSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The date and time that the environment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string EnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArn property is set.
        /// </summary>
        internal bool IsSetEnvironmentArn() => this.EnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        ///  The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property EnvironmentState. 
        /// <para>
        /// The state of an environment.
        /// </para>
        /// </summary>
        public EnvironmentState EnvironmentState { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentState property is set.
        /// </summary>
        internal bool IsSetEnvironmentState() => this.EnvironmentState != null;

        /// <summary>
        /// Gets and sets the property EnvironmentStatus. 
        /// <para>
        /// Reports impaired functionality that stems from issues internal to the environment,
        /// such as impaired reachability.
        /// </para>
        /// </summary>
        public CheckResult EnvironmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentStatus property is set.
        /// </summary>
        internal bool IsSetEnvironmentStatus() => this.EnvironmentStatus != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        ///  The date and time that the environment was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VcfVersion. 
        /// <para>
        /// The VCF version of the environment.
        /// </para>
        /// </summary>
        public VcfVersion VcfVersion { get; set; }

        /// <summary>
        /// Checks to see if the VcfVersion property is set.
        /// </summary>
        internal bool IsSetVcfVersion() => this.VcfVersion != null;
    }
}
