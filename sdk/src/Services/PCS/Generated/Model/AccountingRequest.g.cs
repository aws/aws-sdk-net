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
    /// The accounting configuration includes configurable settings for Slurm accounting.
    /// It's a property of the <b>ClusterSlurmConfiguration</b> object.
    /// </summary>
    public partial class AccountingRequest
    {
        /// <summary>
        /// Gets and sets the property DefaultPurgeTimeInDays. 
        /// <para>
        /// The default value for all purge settings for <c>slurmdbd.conf</c>. For more information,
        /// see the <a href="https://slurm.schedmd.com/slurmdbd.conf.html">slurmdbd.conf documentation
        /// at SchedMD</a>.
        /// </para>
        ///  
        /// <para>
        /// The default value for <c>defaultPurgeTimeInDays</c> is <c>-1</c>.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>-1</c> means there is no purge time and records persist as long as the
        /// cluster exists.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>0</c> isn't a valid value.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = -1, Max = 10000)]
        public int? DefaultPurgeTimeInDays { get; set; }

        /// <summary>
        /// Checks to see if the DefaultPurgeTimeInDays property is set.
        /// </summary>
        internal bool IsSetDefaultPurgeTimeInDays() => this.DefaultPurgeTimeInDays.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The default value for <c>mode</c> is <c>NONE</c>. A value of <c>STANDARD</c> means
        /// Slurm accounting is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccountingMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;
    }
}
