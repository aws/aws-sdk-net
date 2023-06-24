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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The fair share policy for a scheduling policy.
    /// </summary>
    public partial class FairsharePolicy
    {
        private int? _computeReservation;
        private int? _shareDecaySeconds;
        private List<ShareAttributes> _shareDistribution = new List<ShareAttributes>();

        /// <summary>
        /// Gets and sets the property ComputeReservation. 
        /// <para>
        /// A value used to reserve some of the available maximum vCPU for fair share identifiers
        /// that aren't already used.
        /// </para>
        ///  
        /// <para>
        /// The reserved ratio is <code>(<i>computeReservation</i>/100)^<i>ActiveFairShares</i>
        /// </code> where <code> <i>ActiveFairShares</i> </code> is the number of active fair
        /// share identifiers.
        /// </para>
        ///  
        /// <para>
        /// For example, a <code>computeReservation</code> value of 50 indicates that Batchreserves
        /// 50% of the maximum available vCPU if there's only one fair share identifier. It reserves
        /// 25% if there are two fair share identifiers. It reserves 12.5% if there are three
        /// fair share identifiers. A <code>computeReservation</code> value of 25 indicates that
        /// Batch should reserve 25% of the maximum available vCPU if there's only one fair share
        /// identifier, 6.25% if there are two fair share identifiers, and 1.56% if there are
        /// three fair share identifiers.
        /// </para>
        ///  
        /// <para>
        /// The minimum value is 0 and the maximum value is 99.
        /// </para>
        /// </summary>
        public int ComputeReservation
        {
            get { return this._computeReservation.GetValueOrDefault(); }
            set { this._computeReservation = value; }
        }

        // Check to see if ComputeReservation property is set
        internal bool IsSetComputeReservation()
        {
            return this._computeReservation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShareDecaySeconds. 
        /// <para>
        /// The amount of time (in seconds) to use to calculate a fair share percentage for each
        /// fair share identifier in use. A value of zero (0) indicates that only current usage
        /// is measured. The decay allows for more recently run jobs to have more weight than
        /// jobs that ran earlier. The maximum supported value is 604800 (1 week).
        /// </para>
        /// </summary>
        public int ShareDecaySeconds
        {
            get { return this._shareDecaySeconds.GetValueOrDefault(); }
            set { this._shareDecaySeconds = value; }
        }

        // Check to see if ShareDecaySeconds property is set
        internal bool IsSetShareDecaySeconds()
        {
            return this._shareDecaySeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShareDistribution. 
        /// <para>
        /// An array of <code>SharedIdentifier</code> objects that contain the weights for the
        /// fair share identifiers for the fair share policy. Fair share identifiers that aren't
        /// included have a default weight of <code>1.0</code>.
        /// </para>
        /// </summary>
        public List<ShareAttributes> ShareDistribution
        {
            get { return this._shareDistribution; }
            set { this._shareDistribution = value; }
        }

        // Check to see if ShareDistribution property is set
        internal bool IsSetShareDistribution()
        {
            return this._shareDistribution != null && this._shareDistribution.Count > 0; 
        }

    }
}