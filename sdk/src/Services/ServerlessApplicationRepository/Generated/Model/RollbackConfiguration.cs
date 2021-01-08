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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// This property corresponds to the <i>AWS CloudFormation <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RollbackConfiguration">RollbackConfiguration</a>
    /// </i> Data Type.
    /// </summary>
    public partial class RollbackConfiguration
    {
        private int? _monitoringTimeInMinutes;
        private List<RollbackTrigger> _rollbackTriggers = new List<RollbackTrigger>();

        /// <summary>
        /// Gets and sets the property MonitoringTimeInMinutes. 
        /// <para>
        /// This property corresponds to the content of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RollbackConfiguration">RollbackConfiguration</a>
        /// </i> Data Type.
        /// </para>
        /// </summary>
        public int MonitoringTimeInMinutes
        {
            get { return this._monitoringTimeInMinutes.GetValueOrDefault(); }
            set { this._monitoringTimeInMinutes = value; }
        }

        // Check to see if MonitoringTimeInMinutes property is set
        internal bool IsSetMonitoringTimeInMinutes()
        {
            return this._monitoringTimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RollbackTriggers. 
        /// <para>
        /// This property corresponds to the content of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RollbackConfiguration">RollbackConfiguration</a>
        /// </i> Data Type.
        /// </para>
        /// </summary>
        public List<RollbackTrigger> RollbackTriggers
        {
            get { return this._rollbackTriggers; }
            set { this._rollbackTriggers = value; }
        }

        // Check to see if RollbackTriggers property is set
        internal bool IsSetRollbackTriggers()
        {
            return this._rollbackTriggers != null && this._rollbackTriggers.Count > 0; 
        }

    }
}