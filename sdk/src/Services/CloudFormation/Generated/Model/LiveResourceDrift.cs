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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains drift information for a resource property, including actual value, previous
    /// deployment value, and drift detection timestamp.
    /// </summary>
    public partial class LiveResourceDrift
    {
        private string _actualValue;
        private DateTime? _driftDetectionTimestamp;
        private string _previousValue;

        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The current live configuration value of the resource property.
        /// </para>
        /// </summary>
        public string ActualValue
        {
            get { return this._actualValue; }
            set { this._actualValue = value; }
        }

        // Check to see if ActualValue property is set
        internal bool IsSetActualValue()
        {
            return this._actualValue != null;
        }

        /// <summary>
        /// Gets and sets the property DriftDetectionTimestamp. 
        /// <para>
        /// The timestamp when drift was detected for this resource property.
        /// </para>
        /// </summary>
        public DateTime DriftDetectionTimestamp
        {
            get { return this._driftDetectionTimestamp.GetValueOrDefault(); }
            set { this._driftDetectionTimestamp = value; }
        }

        // Check to see if DriftDetectionTimestamp property is set
        internal bool IsSetDriftDetectionTimestamp()
        {
            return this._driftDetectionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreviousValue. 
        /// <para>
        /// The configuration value from the previous CloudFormation deployment.
        /// </para>
        /// </summary>
        public string PreviousValue
        {
            get { return this._previousValue; }
            set { this._previousValue = value; }
        }

        // Check to see if PreviousValue property is set
        internal bool IsSetPreviousValue()
        {
            return this._previousValue != null;
        }

    }
}