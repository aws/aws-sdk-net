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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// A structure that contains the configuration of which variation to use as the "control"
    /// version. The "control" version is used for comparison with other variations. This
    /// structure also specifies how much experiment traffic is allocated to each variation.
    /// </summary>
    public partial class OnlineAbConfig
    {
        private string _controlTreatmentName;
        private Dictionary<string, long> _treatmentWeights = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Gets and sets the property ControlTreatmentName. 
        /// <para>
        /// The name of the variation that is to be the default variation that the other variations
        /// are compared to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ControlTreatmentName
        {
            get { return this._controlTreatmentName; }
            set { this._controlTreatmentName = value; }
        }

        // Check to see if ControlTreatmentName property is set
        internal bool IsSetControlTreatmentName()
        {
            return this._controlTreatmentName != null;
        }

        /// <summary>
        /// Gets and sets the property TreatmentWeights. 
        /// <para>
        /// A set of key-value pairs. The keys are variation names, and the values are the portion
        /// of experiment traffic to be assigned to that variation. Specify the traffic portion
        /// in thousandths of a percent, so 20,000 for a variation would allocate 20% of the experiment
        /// traffic to that variation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> TreatmentWeights
        {
            get { return this._treatmentWeights; }
            set { this._treatmentWeights = value; }
        }

        // Check to see if TreatmentWeights property is set
        internal bool IsSetTreatmentWeights()
        {
            return this._treatmentWeights != null && (this._treatmentWeights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}