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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private string _behaviorName;
        private double? _datapointsCollectionPercentage;
        private DateTime? _lastModelRefreshDate;
        private ModelStatus _modelStatus;
        private string _securityProfileName;
        private DateTime? _trainingDataCollectionStartDate;

        /// <summary>
        /// Gets and sets the property BehaviorName. 
        /// <para>
        ///  The name of the behavior. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BehaviorName
        {
            get { return this._behaviorName; }
            set { this._behaviorName = value; }
        }

        // Check to see if BehaviorName property is set
        internal bool IsSetBehaviorName()
        {
            return this._behaviorName != null;
        }

        /// <summary>
        /// Gets and sets the property DatapointsCollectionPercentage. 
        /// <para>
        ///  The percentage of datapoints collected. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? DatapointsCollectionPercentage
        {
            get { return this._datapointsCollectionPercentage; }
            set { this._datapointsCollectionPercentage = value; }
        }

        // Check to see if DatapointsCollectionPercentage property is set
        internal bool IsSetDatapointsCollectionPercentage()
        {
            return this._datapointsCollectionPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModelRefreshDate. 
        /// <para>
        ///  The date the model was last refreshed. 
        /// </para>
        /// </summary>
        public DateTime? LastModelRefreshDate
        {
            get { return this._lastModelRefreshDate; }
            set { this._lastModelRefreshDate = value; }
        }

        // Check to see if LastModelRefreshDate property is set
        internal bool IsSetLastModelRefreshDate()
        {
            return this._lastModelRefreshDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelStatus. 
        /// <para>
        ///  The status of the behavior model. 
        /// </para>
        /// </summary>
        public ModelStatus ModelStatus
        {
            get { return this._modelStatus; }
            set { this._modelStatus = value; }
        }

        // Check to see if ModelStatus property is set
        internal bool IsSetModelStatus()
        {
            return this._modelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        ///  The name of the security profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataCollectionStartDate. 
        /// <para>
        ///  The date a training model started collecting data. 
        /// </para>
        /// </summary>
        public DateTime? TrainingDataCollectionStartDate
        {
            get { return this._trainingDataCollectionStartDate; }
            set { this._trainingDataCollectionStartDate = value; }
        }

        // Check to see if TrainingDataCollectionStartDate property is set
        internal bool IsSetTrainingDataCollectionStartDate()
        {
            return this._trainingDataCollectionStartDate.HasValue; 
        }

    }
}