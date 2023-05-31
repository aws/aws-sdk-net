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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Records configuration changes to specified resource types. For more information about
    /// the configuration recorder, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/stop-start-recorder.html">
    /// <b>Managing the Configuration Recorder</b> </a> in the <i>Config Developer Guide</i>.
    /// </summary>
    public partial class ConfigurationRecorder
    {
        private string _name;
        private RecordingGroup _recordingGroup;
        private string _rolearn;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration recorder. Config automatically assigns the name of "default"
        /// when creating the configuration recorder.
        /// </para>
        ///  
        /// <para>
        /// You cannot change the name of the configuration recorder after it has been created.
        /// To change the configuration recorder name, you must delete it and create a new configuration
        /// recorder with a new name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingGroup. 
        /// <para>
        /// Specifies which resource types Config records for configuration changes.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b> High Number of Config Evaluations</b> 
        /// </para>
        ///  
        /// <para>
        /// You may notice increased activity in your account during your initial month recording
        /// with Config when compared to subsequent months. During the initial bootstrapping process,
        /// Config runs evaluations on all the resources in your account that you have selected
        /// for Config to record.
        /// </para>
        ///  
        /// <para>
        /// If you are running ephemeral workloads, you may see increased activity from Config
        /// as it records configuration changes associated with creating and deleting these temporary
        /// resources. An <i>ephemeral workload</i> is a temporary use of computing resources
        /// that are loaded and run when needed. Examples include Amazon Elastic Compute Cloud
        /// (Amazon EC2) Spot Instances, Amazon EMR jobs, and Auto Scaling. If you want to avoid
        /// the increased activity from running ephemeral workloads, you can run these types of
        /// workloads in a separate account with Config turned off to avoid increased configuration
        /// recording and rule evaluations.
        /// </para>
        ///  </note>
        /// </summary>
        public RecordingGroup RecordingGroup
        {
            get { return this._recordingGroup; }
            set { this._recordingGroup = value; }
        }

        // Check to see if RecordingGroup property is set
        internal bool IsSetRecordingGroup()
        {
            return this._recordingGroup != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// Amazon Resource Name (ARN) of the IAM role assumed by Config and used by the configuration
        /// recorder.
        /// </para>
        ///  <note> 
        /// <para>
        /// While the API model does not require this field, the server will reject a request
        /// without a defined <code>roleARN</code> for the configuration recorder.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <b>Pre-existing Config role</b> 
        /// </para>
        ///  
        /// <para>
        /// If you have used an Amazon Web Services service that uses Config, such as Security
        /// Hub or Control Tower, and an Config role has already been created, make sure that
        /// the IAM role that you use when setting up Config keeps the same minimum permissions
        /// as the already created Config role. You must do this so that the other Amazon Web
        /// Services service continues to run as expected. 
        /// </para>
        ///  
        /// <para>
        /// For example, if Control Tower has an IAM role that allows Config to read Amazon Simple
        /// Storage Service (Amazon S3) objects, make sure that the same permissions are granted
        /// within the IAM role you use when setting up Config. Otherwise, it may interfere with
        /// how Control Tower operates. For more information about IAM roles for Config, see <a
        /// href="https://docs.aws.amazon.com/config/latest/developerguide/security-iam.html">
        /// <b>Identity and Access Management for Config</b> </a> in the <i>Config Developer Guide</i>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public string RoleARN
        {
            get { return this._rolearn; }
            set { this._rolearn = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._rolearn != null;
        }

    }
}