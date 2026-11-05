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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The summary of an ML Detect behavior model.
    /// </summary>
    public partial class BehaviorModelTrainingSummary
    {
        /// <summary>
        /// Gets and sets the property BehaviorName. 
        /// <para>
        ///  The name of the behavior. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string BehaviorName { get; set; }

        /// <summary>
        /// Checks to see if the BehaviorName property is set.
        /// </summary>
        internal bool IsSetBehaviorName() => this.BehaviorName != null;

        /// <summary>
        /// Gets and sets the property DatapointsCollectionPercentage. 
        /// <para>
        ///  The percentage of datapoints collected. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? DatapointsCollectionPercentage { get; set; }

        /// <summary>
        /// Checks to see if the DatapointsCollectionPercentage property is set.
        /// </summary>
        internal bool IsSetDatapointsCollectionPercentage() => this.DatapointsCollectionPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property LastModelRefreshDate. 
        /// <para>
        ///  The date the model was last refreshed. 
        /// </para>
        /// </summary>
        public DateTime? LastModelRefreshDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModelRefreshDate property is set.
        /// </summary>
        internal bool IsSetLastModelRefreshDate() => this.LastModelRefreshDate.HasValue;

        /// <summary>
        /// Gets and sets the property ModelStatus. 
        /// <para>
        ///  The status of the behavior model. 
        /// </para>
        /// </summary>
        public ModelStatus ModelStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelStatus property is set.
        /// </summary>
        internal bool IsSetModelStatus() => this.ModelStatus != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        ///  The name of the security profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SecurityProfileName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileName property is set.
        /// </summary>
        internal bool IsSetSecurityProfileName() => this.SecurityProfileName != null;

        /// <summary>
        /// Gets and sets the property TrainingDataCollectionStartDate. 
        /// <para>
        ///  The date a training model started collecting data. 
        /// </para>
        /// </summary>
        public DateTime? TrainingDataCollectionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataCollectionStartDate property is set.
        /// </summary>
        internal bool IsSetTrainingDataCollectionStartDate() => this.TrainingDataCollectionStartDate.HasValue;
    }
}
