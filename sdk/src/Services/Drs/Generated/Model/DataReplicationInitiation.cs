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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Data replication initiation.
    /// </summary>
    public partial class DataReplicationInitiation
    {
        private string _nextAttemptDateTime;
        private string _startDateTime;
        private List<DataReplicationInitiationStep> _steps = AWSConfigs.InitializeCollections ? new List<DataReplicationInitiationStep>() : null;

        /// <summary>
        /// Gets and sets the property NextAttemptDateTime. 
        /// <para>
        /// The date and time of the next attempt to initiate data replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string NextAttemptDateTime
        {
            get { return this._nextAttemptDateTime; }
            set { this._nextAttemptDateTime = value; }
        }

        // Check to see if NextAttemptDateTime property is set
        internal bool IsSetNextAttemptDateTime()
        {
            return this._nextAttemptDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time of the current attempt to initiate data replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string StartDateTime
        {
            get { return this._startDateTime; }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// The steps of the current attempt to initiate data replication.
        /// </para>
        /// </summary>
        public List<DataReplicationInitiationStep> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}