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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Determines the duration and renewal status of the commitment period for a radio unit.
    /// 
    ///  
    /// <para>
    /// For pricing, see <a href="http://aws.amazon.com/private5g/pricing">Amazon Web Services
    /// Private 5G Pricing</a>.
    /// </para>
    /// </summary>
    public partial class CommitmentConfiguration
    {
        private bool? _automaticRenewal;
        private CommitmentLength _commitmentLength;

        /// <summary>
        /// Gets and sets the property AutomaticRenewal. 
        /// <para>
        /// Determines whether the commitment period for a radio unit is set to automatically
        /// renew for an additional 1 year after your current commitment period expires.
        /// </para>
        ///  
        /// <para>
        /// Set to <code>True</code>, if you want your commitment period to automatically renew.
        /// Set to <code>False</code> if you do not want your commitment to automatically renew.
        /// </para>
        ///  
        /// <para>
        /// You can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set a 1-year commitment to automatically renew for an additional 1 year. The hourly
        /// rate for the additional year will continue to be the same as your existing 1-year
        /// rate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set a 3-year commitment to automatically renew for an additional 1 year. The hourly
        /// rate for the additional year will continue to be the same as your existing 3-year
        /// rate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Turn off a previously-enabled automatic renewal on a 1-year or 3-year commitment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You cannot use the automatic-renewal option for a 60-day commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AutomaticRenewal
        {
            get { return this._automaticRenewal.GetValueOrDefault(); }
            set { this._automaticRenewal = value; }
        }

        // Check to see if AutomaticRenewal property is set
        internal bool IsSetAutomaticRenewal()
        {
            return this._automaticRenewal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CommitmentLength. 
        /// <para>
        /// The duration of the commitment period for the radio unit. You can choose a 60-day,
        /// 1-year, or 3-year period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CommitmentLength CommitmentLength
        {
            get { return this._commitmentLength; }
            set { this._commitmentLength = value; }
        }

        // Check to see if CommitmentLength property is set
        internal bool IsSetCommitmentLength()
        {
            return this._commitmentLength != null;
        }

    }
}