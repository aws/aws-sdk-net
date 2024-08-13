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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Describes the details of the flow run, including the timestamp, status, and message.
    /// </summary>
    public partial class ExecutionDetails
    {
        private string _mostRecentExecutionMessage;
        private ExecutionStatus _mostRecentExecutionStatus;
        private DateTime? _mostRecentExecutionTime;

        /// <summary>
        /// Gets and sets the property MostRecentExecutionMessage. 
        /// <para>
        ///  Describes the details of the most recent flow run. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string MostRecentExecutionMessage
        {
            get { return this._mostRecentExecutionMessage; }
            set { this._mostRecentExecutionMessage = value; }
        }

        // Check to see if MostRecentExecutionMessage property is set
        internal bool IsSetMostRecentExecutionMessage()
        {
            return this._mostRecentExecutionMessage != null;
        }

        /// <summary>
        /// Gets and sets the property MostRecentExecutionStatus. 
        /// <para>
        ///  Specifies the status of the most recent flow run. 
        /// </para>
        /// </summary>
        public ExecutionStatus MostRecentExecutionStatus
        {
            get { return this._mostRecentExecutionStatus; }
            set { this._mostRecentExecutionStatus = value; }
        }

        // Check to see if MostRecentExecutionStatus property is set
        internal bool IsSetMostRecentExecutionStatus()
        {
            return this._mostRecentExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MostRecentExecutionTime. 
        /// <para>
        ///  Specifies the time of the most recent flow run. 
        /// </para>
        /// </summary>
        public DateTime? MostRecentExecutionTime
        {
            get { return this._mostRecentExecutionTime; }
            set { this._mostRecentExecutionTime = value; }
        }

        // Check to see if MostRecentExecutionTime property is set
        internal bool IsSetMostRecentExecutionTime()
        {
            return this._mostRecentExecutionTime.HasValue; 
        }

    }
}