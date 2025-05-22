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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
    public partial class Accounting
    {
        private int? _defaultPurgeTimeInDays;
        private AccountingMode _mode;

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
        [AWSProperty(Min=-1, Max=10000)]
        public int? DefaultPurgeTimeInDays
        {
            get { return this._defaultPurgeTimeInDays; }
            set { this._defaultPurgeTimeInDays = value; }
        }

        // Check to see if DefaultPurgeTimeInDays property is set
        internal bool IsSetDefaultPurgeTimeInDays()
        {
            return this._defaultPurgeTimeInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The default value for <c>mode</c> is <c>STANDARD</c>. A value of <c>STANDARD</c> means
        /// Slurm accounting is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountingMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}