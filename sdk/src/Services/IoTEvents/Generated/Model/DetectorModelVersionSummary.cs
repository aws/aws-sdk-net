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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information about the detector model version.
    /// </summary>
    public partial class DetectorModelVersionSummary
    {
        private DateTime? _creationTime;
        private string _detectorModelArn;
        private string _detectorModelName;
        private string _detectorModelVersion;
        private EvaluationMethod _evaluationMethod;
        private DateTime? _lastUpdateTime;
        private string _roleArn;
        private DetectorModelVersionStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the detector model version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectorModelArn. 
        /// <para>
        /// The ARN of the detector model version.
        /// </para>
        /// </summary>
        public string DetectorModelArn
        {
            get { return this._detectorModelArn; }
            set { this._detectorModelArn = value; }
        }

        // Check to see if DetectorModelArn property is set
        internal bool IsSetDetectorModelArn()
        {
            return this._detectorModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorModelName. 
        /// <para>
        /// The name of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DetectorModelName
        {
            get { return this._detectorModelName; }
            set { this._detectorModelName = value; }
        }

        // Check to see if DetectorModelName property is set
        internal bool IsSetDetectorModelName()
        {
            return this._detectorModelName != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorModelVersion. 
        /// <para>
        /// The ID of the detector model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DetectorModelVersion
        {
            get { return this._detectorModelVersion; }
            set { this._detectorModelVersion = value; }
        }

        // Check to see if DetectorModelVersion property is set
        internal bool IsSetDetectorModelVersion()
        {
            return this._detectorModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationMethod. 
        /// <para>
        /// Information about the order in which events are evaluated and how actions are executed.
        /// 
        /// </para>
        /// </summary>
        public EvaluationMethod EvaluationMethod
        {
            get { return this._evaluationMethod; }
            set { this._evaluationMethod = value; }
        }

        // Check to see if EvaluationMethod property is set
        internal bool IsSetEvaluationMethod()
        {
            return this._evaluationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time the detector model version was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants the detector model permission to perform its tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the detector model version.
        /// </para>
        /// </summary>
        public DetectorModelVersionStatus Status
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