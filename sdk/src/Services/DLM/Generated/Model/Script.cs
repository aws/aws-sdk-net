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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Custom snapshot policies that target instances only]</b> Information about pre
    /// and/or post scripts for a snapshot lifecycle policy that targets instances. For more
    /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/automate-app-consistent-backups.html">
    /// Automating application-consistent snapshots with pre and post scripts</a>.
    /// </summary>
    public partial class Script
    {
        private bool? _executeOperationOnScriptFailure;
        private string _executionHandler;
        private ExecutionHandlerServiceValues _executionHandlerService;
        private int? _executionTimeout;
        private int? _maximumRetryCount;
        private List<string> _stages = new List<string>();

        /// <summary>
        /// Gets and sets the property ExecuteOperationOnScriptFailure. 
        /// <para>
        /// Indicates whether Amazon Data Lifecycle Manager should default to crash-consistent
        /// snapshots if the pre script fails.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To default to crash consistent snapshot if the pre script fails, specify <code>true</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To skip the instance for snapshot creation if the pre script fails, specify <code>false</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This parameter is supported only if you run a pre script. If you run a post script
        /// only, omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: true
        /// </para>
        /// </summary>
        public bool ExecuteOperationOnScriptFailure
        {
            get { return this._executeOperationOnScriptFailure.GetValueOrDefault(); }
            set { this._executeOperationOnScriptFailure = value; }
        }

        // Check to see if ExecuteOperationOnScriptFailure property is set
        internal bool IsSetExecuteOperationOnScriptFailure()
        {
            return this._executeOperationOnScriptFailure.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionHandler. 
        /// <para>
        /// The SSM document that includes the pre and/or post scripts to run.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are automating VSS backups, specify <code>AWS_VSS_BACKUP</code>. In this case,
        /// Amazon Data Lifecycle Manager automatically uses the <code>AWSEC2-CreateVssSnapshot</code>
        /// SSM document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using a custom SSM document that you own, specify either the name or ARN
        /// of the SSM document. If you are using a custom SSM document that is shared with you,
        /// specify the ARN of the SSM document.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string ExecutionHandler
        {
            get { return this._executionHandler; }
            set { this._executionHandler = value; }
        }

        // Check to see if ExecutionHandler property is set
        internal bool IsSetExecutionHandler()
        {
            return this._executionHandler != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionHandlerService. 
        /// <para>
        /// Indicates the service used to execute the pre and/or post scripts.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are using custom SSM documents, specify <code>AWS_SYSTEMS_MANAGER</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are automating VSS Backups, omit this parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: AWS_SYSTEMS_MANAGER
        /// </para>
        /// </summary>
        public ExecutionHandlerServiceValues ExecutionHandlerService
        {
            get { return this._executionHandlerService; }
            set { this._executionHandlerService = value; }
        }

        // Check to see if ExecutionHandlerService property is set
        internal bool IsSetExecutionHandlerService()
        {
            return this._executionHandlerService != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimeout. 
        /// <para>
        /// Specifies a timeout period, in seconds, after which Amazon Data Lifecycle Manager
        /// fails the script run attempt if it has not completed. If a script does not complete
        /// within its timeout period, Amazon Data Lifecycle Manager fails the attempt. The timeout
        /// period applies to the pre and post scripts individually. 
        /// </para>
        ///  
        /// <para>
        /// If you are automating VSS Backups, omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: 10
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=120)]
        public int ExecutionTimeout
        {
            get { return this._executionTimeout.GetValueOrDefault(); }
            set { this._executionTimeout = value; }
        }

        // Check to see if ExecutionTimeout property is set
        internal bool IsSetExecutionTimeout()
        {
            return this._executionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumRetryCount. 
        /// <para>
        /// Specifies the number of times Amazon Data Lifecycle Manager should retry scripts that
        /// fail.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the pre script fails, Amazon Data Lifecycle Manager retries the entire snapshot
        /// creation process, including running the pre and post scripts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the post script fails, Amazon Data Lifecycle Manager retries the post script only;
        /// in this case, the pre script will have completed and the snapshot might have been
        /// created.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you do not want Amazon Data Lifecycle Manager to retry failed scripts, specify
        /// <code>0</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public int MaximumRetryCount
        {
            get { return this._maximumRetryCount.GetValueOrDefault(); }
            set { this._maximumRetryCount = value; }
        }

        // Check to see if MaximumRetryCount property is set
        internal bool IsSetMaximumRetryCount()
        {
            return this._maximumRetryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// Indicate which scripts Amazon Data Lifecycle Manager should run on target instances.
        /// Pre scripts run before Amazon Data Lifecycle Manager initiates snapshot creation.
        /// Post scripts run after Amazon Data Lifecycle Manager initiates snapshot creation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To run a pre script only, specify <code>PRE</code>. In this case, Amazon Data Lifecycle
        /// Manager calls the SSM document with the <code>pre-script</code> parameter before initiating
        /// snapshot creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To run a post script only, specify <code>POST</code>. In this case, Amazon Data Lifecycle
        /// Manager calls the SSM document with the <code>post-script</code> parameter after initiating
        /// snapshot creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To run both pre and post scripts, specify both <code>PRE</code> and <code>POST</code>.
        /// In this case, Amazon Data Lifecycle Manager calls the SSM document with the <code>pre-script</code>
        /// parameter before initiating snapshot creation, and then it calls the SSM document
        /// again with the <code>post-script</code> parameter after initiating snapshot creation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you are automating VSS Backups, omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: PRE and POST
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> Stages
        {
            get { return this._stages; }
            set { this._stages = value; }
        }

        // Check to see if Stages property is set
        internal bool IsSetStages()
        {
            return this._stages != null && this._stages.Count > 0; 
        }

    }
}