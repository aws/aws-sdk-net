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
    /// The statistics of a mitigation action task.
    /// </summary>
    public partial class DetectMitigationActionsTaskStatistics
    {
        private long? _actionsExecuted;
        private long? _actionsFailed;
        private long? _actionsSkipped;

        /// <summary>
        /// Gets and sets the property ActionsExecuted. 
        /// <para>
        ///  The actions that were performed. 
        /// </para>
        /// </summary>
        public long? ActionsExecuted
        {
            get { return this._actionsExecuted; }
            set { this._actionsExecuted = value; }
        }

        // Check to see if ActionsExecuted property is set
        internal bool IsSetActionsExecuted()
        {
            return this._actionsExecuted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActionsFailed. 
        /// <para>
        ///  The actions that failed. 
        /// </para>
        /// </summary>
        public long? ActionsFailed
        {
            get { return this._actionsFailed; }
            set { this._actionsFailed = value; }
        }

        // Check to see if ActionsFailed property is set
        internal bool IsSetActionsFailed()
        {
            return this._actionsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActionsSkipped. 
        /// <para>
        ///  The actions that were skipped. 
        /// </para>
        /// </summary>
        public long? ActionsSkipped
        {
            get { return this._actionsSkipped; }
            set { this._actionsSkipped = value; }
        }

        // Check to see if ActionsSkipped property is set
        internal bool IsSetActionsSkipped()
        {
            return this._actionsSkipped.HasValue; 
        }

    }
}