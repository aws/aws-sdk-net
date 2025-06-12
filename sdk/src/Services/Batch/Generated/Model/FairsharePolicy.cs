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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The fair-share scheduling policy details.
    /// </summary>
    public partial class FairsharePolicy
    {
        private int? _computeReservation;
        private int? _shareDecaySeconds;
        private List<ShareAttributes> _shareDistribution = AWSConfigs.InitializeCollections ? new List<ShareAttributes>() : null;

        /// <summary>
        /// Gets and sets the property ComputeReservation. 
        /// <para>
        /// A value used to reserve some of the available maximum vCPU for share identifiers that
        /// aren't already used.
        /// </para>
        ///  
        /// <para>
        /// The reserved ratio is <c>(<i>computeReservation</i>/100)^<i>ActiveFairShares</i> </c>
        /// where <c> <i>ActiveFairShares</i> </c> is the number of active share identifiers.
        /// </para>
        ///  
        /// <para>
        /// For example, a <c>computeReservation</c> value of 50 indicates that Batch reserves
        /// 50% of the maximum available vCPU if there's only one share identifier. It reserves
        /// 25% if there are two share identifiers. It reserves 12.5% if there are three share
        /// identifiers. A <c>computeReservation</c> value of 25 indicates that Batch should reserve
        /// 25% of the maximum available vCPU if there's only one share identifier, 6.25% if there
        /// are two fair share identifiers, and 1.56% if there are three share identifiers.
        /// </para>
        ///  
        /// <para>
        /// The minimum value is 0 and the maximum value is 99.
        /// </para>
        /// </summary>
        public int? ComputeReservation
        {
            get { return this._computeReservation; }
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
        /// The amount of time (in seconds) to use to calculate a fair-share percentage for each
        /// share identifier in use. A value of zero (0) indicates the default minimum time window
        /// (600 seconds). The maximum supported value is 604800 (1 week).
        /// </para>
        ///  
        /// <para>
        /// The decay allows for more recently run jobs to have more weight than jobs that ran
        /// earlier. Consider adjusting this number if you have jobs that (on average) run longer
        /// than ten minutes, or a large difference in job count or job run times between share
        /// identifiers, and the allocation of resources doesn't meet your needs.
        /// </para>
        /// </summary>
        public int? ShareDecaySeconds
        {
            get { return this._shareDecaySeconds; }
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
        /// An array of <c>SharedIdentifier</c> objects that contain the weights for the share
        /// identifiers for the fair-share policy. Share identifiers that aren't included have
        /// a default weight of <c>1.0</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ShareAttributes> ShareDistribution
        {
            get { return this._shareDistribution; }
            set { this._shareDistribution = value; }
        }

        // Check to see if ShareDistribution property is set
        internal bool IsSetShareDistribution()
        {
            return this._shareDistribution != null && (this._shareDistribution.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}