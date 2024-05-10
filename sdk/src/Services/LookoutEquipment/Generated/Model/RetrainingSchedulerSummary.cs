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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Provides information about the specified retraining scheduler, including model name,
    /// status, start date, frequency, and lookback window.
    /// </summary>
    public partial class RetrainingSchedulerSummary
    {
        private string _lookbackWindow;
        private string _modelArn;
        private string _modelName;
        private string _retrainingFrequency;
        private DateTime? _retrainingStartDate;
        private RetrainingSchedulerStatus _status;

        /// <summary>
        /// Gets and sets the property LookbackWindow. 
        /// <para>
        /// The number of past days of data used for retraining.
        /// </para>
        /// </summary>
        public string LookbackWindow
        {
            get { return this._lookbackWindow; }
            set { this._lookbackWindow = value; }
        }

        // Check to see if LookbackWindow property is set
        internal bool IsSetLookbackWindow()
        {
            return this._lookbackWindow != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The ARN of the model that the retraining scheduler is attached to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model that the retraining scheduler is attached to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property RetrainingFrequency. 
        /// <para>
        /// The frequency at which the model retraining is set. This follows the <a href="https://en.wikipedia.org/wiki/ISO_8601#Durations">ISO
        /// 8601</a> guidelines.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string RetrainingFrequency
        {
            get { return this._retrainingFrequency; }
            set { this._retrainingFrequency = value; }
        }

        // Check to see if RetrainingFrequency property is set
        internal bool IsSetRetrainingFrequency()
        {
            return this._retrainingFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property RetrainingStartDate. 
        /// <para>
        /// The start date for the retraining scheduler. Lookout for Equipment truncates the time
        /// you provide to the nearest UTC day.
        /// </para>
        /// </summary>
        public DateTime? RetrainingStartDate
        {
            get { return this._retrainingStartDate; }
            set { this._retrainingStartDate = value; }
        }

        // Check to see if RetrainingStartDate property is set
        internal bool IsSetRetrainingStartDate()
        {
            return this._retrainingStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the retraining scheduler. 
        /// </para>
        /// </summary>
        public RetrainingSchedulerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}