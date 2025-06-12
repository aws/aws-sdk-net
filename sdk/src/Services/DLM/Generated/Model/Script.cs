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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<string> _stages = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ExecuteOperationOnScriptFailure. 
        /// <para>
        /// Indicates whether Amazon Data Lifecycle Manager should default to crash-consistent
        /// snapshots if the pre script fails.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To default to crash consistent snapshot if the pre script fails, specify <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To skip the instance for snapshot creation if the pre script fails, specify <c>false</c>.
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
        public bool? ExecuteOperationOnScriptFailure
        {
            get { return this._executeOperationOnScriptFailure; }
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
        /// If you are automating VSS backups, specify <c>AWS_VSS_BACKUP</c>. In this case, Amazon
        /// Data Lifecycle Manager automatically uses the <c>AWSEC2-CreateVssSnapshot</c> SSM
        /// document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are automating application-consistent snapshots for SAP HANA workloads, specify
        /// <c>AWSSystemsManagerSAP-CreateDLMSnapshotForSAPHANA</c>.
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
        /// If you are using custom SSM documents or automating application-consistent snapshots
        /// of SAP HANA workloads, specify <c>AWS_SYSTEMS_MANAGER</c>.
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
        public int? ExecutionTimeout
        {
            get { return this._executionTimeout; }
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
        /// <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public int? MaximumRetryCount
        {
            get { return this._maximumRetryCount; }
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
        /// To run a pre script only, specify <c>PRE</c>. In this case, Amazon Data Lifecycle
        /// Manager calls the SSM document with the <c>pre-script</c> parameter before initiating
        /// snapshot creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To run a post script only, specify <c>POST</c>. In this case, Amazon Data Lifecycle
        /// Manager calls the SSM document with the <c>post-script</c> parameter after initiating
        /// snapshot creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To run both pre and post scripts, specify both <c>PRE</c> and <c>POST</c>. In this
        /// case, Amazon Data Lifecycle Manager calls the SSM document with the <c>pre-script</c>
        /// parameter before initiating snapshot creation, and then it calls the SSM document
        /// again with the <c>post-script</c> parameter after initiating snapshot creation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you are automating VSS Backups, omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: PRE and POST
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._stages != null && (this._stages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}