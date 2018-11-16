/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The combination of AWS Regions and accounts targeted by the current Automation execution.
    /// </summary>
    public partial class TargetLocation
    {
        private List<string> _accounts = new List<string>();
        private string _executionRoleName;
        private List<string> _regions = new List<string>();
        private string _targetLocationMaxConcurrency;
        private string _targetLocationMaxErrors;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The AWS accounts targeted by the current Automation execution.
        /// </para>
        /// </summary>
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && this._accounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleName. 
        /// <para>
        /// The Automation execution role used by the currently executing Automation.
        /// </para>
        /// </summary>
        public string ExecutionRoleName
        {
            get { return this._executionRoleName; }
            set { this._executionRoleName = value; }
        }

        // Check to see if ExecutionRoleName property is set
        internal bool IsSetExecutionRoleName()
        {
            return this._executionRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The AWS Regions targeted by the current Automation execution.
        /// </para>
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetLocationMaxConcurrency. 
        /// <para>
        /// The maxium number of AWS accounts and AWS regions allowed to run the Automation concurrently
        /// 
        /// </para>
        /// </summary>
        public string TargetLocationMaxConcurrency
        {
            get { return this._targetLocationMaxConcurrency; }
            set { this._targetLocationMaxConcurrency = value; }
        }

        // Check to see if TargetLocationMaxConcurrency property is set
        internal bool IsSetTargetLocationMaxConcurrency()
        {
            return this._targetLocationMaxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLocationMaxErrors. 
        /// <para>
        /// The maxium number of errors allowed before the system stops queueing additional Automation
        /// executions for the currently executing Automation. 
        /// </para>
        /// </summary>
        public string TargetLocationMaxErrors
        {
            get { return this._targetLocationMaxErrors; }
            set { this._targetLocationMaxErrors = value; }
        }

        // Check to see if TargetLocationMaxErrors property is set
        internal bool IsSetTargetLocationMaxErrors()
        {
            return this._targetLocationMaxErrors != null;
        }

    }
}