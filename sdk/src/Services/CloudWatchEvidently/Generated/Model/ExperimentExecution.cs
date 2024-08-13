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
    /// This structure contains the date and time that the experiment started and ended.
    /// </summary>
    public partial class ExperimentExecution
    {
        private DateTime? _endedTime;
        private DateTime? _startedTime;

        /// <summary>
        /// Gets and sets the property EndedTime. 
        /// <para>
        /// The date and time that the experiment ended.
        /// </para>
        /// </summary>
        public DateTime? EndedTime
        {
            get { return this._endedTime; }
            set { this._endedTime = value; }
        }

        // Check to see if EndedTime property is set
        internal bool IsSetEndedTime()
        {
            return this._endedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedTime. 
        /// <para>
        /// The date and time that the experiment started.
        /// </para>
        /// </summary>
        public DateTime? StartedTime
        {
            get { return this._startedTime; }
            set { this._startedTime = value; }
        }

        // Check to see if StartedTime property is set
        internal bool IsSetStartedTime()
        {
            return this._startedTime.HasValue; 
        }

    }
}