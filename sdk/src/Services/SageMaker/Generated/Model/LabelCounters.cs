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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides a breakdown of the number of objects labeled.
    /// </summary>
    public partial class LabelCounters
    {
        private int? _failedNonRetryableError;
        private int? _humanLabeled;
        private int? _machineLabeled;
        private int? _totalLabeled;
        private int? _unlabeled;

        /// <summary>
        /// Gets and sets the property FailedNonRetryableError. 
        /// <para>
        /// The total number of objects that could not be labeled due to an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? FailedNonRetryableError
        {
            get { return this._failedNonRetryableError; }
            set { this._failedNonRetryableError = value; }
        }

        // Check to see if FailedNonRetryableError property is set
        internal bool IsSetFailedNonRetryableError()
        {
            return this._failedNonRetryableError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HumanLabeled. 
        /// <para>
        /// The total number of objects labeled by a human worker.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? HumanLabeled
        {
            get { return this._humanLabeled; }
            set { this._humanLabeled = value; }
        }

        // Check to see if HumanLabeled property is set
        internal bool IsSetHumanLabeled()
        {
            return this._humanLabeled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MachineLabeled. 
        /// <para>
        /// The total number of objects labeled by automated data labeling.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MachineLabeled
        {
            get { return this._machineLabeled; }
            set { this._machineLabeled = value; }
        }

        // Check to see if MachineLabeled property is set
        internal bool IsSetMachineLabeled()
        {
            return this._machineLabeled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalLabeled. 
        /// <para>
        /// The total number of objects labeled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TotalLabeled
        {
            get { return this._totalLabeled; }
            set { this._totalLabeled = value; }
        }

        // Check to see if TotalLabeled property is set
        internal bool IsSetTotalLabeled()
        {
            return this._totalLabeled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unlabeled. 
        /// <para>
        /// The total number of objects not yet labeled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Unlabeled
        {
            get { return this._unlabeled; }
            set { this._unlabeled = value; }
        }

        // Check to see if Unlabeled property is set
        internal bool IsSetUnlabeled()
        {
            return this._unlabeled.HasValue; 
        }

    }
}