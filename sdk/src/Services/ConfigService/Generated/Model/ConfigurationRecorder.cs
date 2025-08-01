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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Records configuration changes to the resource types in scope.
    /// 
    ///  
    /// <para>
    /// For more information about the configuration recorder, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/stop-start-recorder.html">
    /// <b>Working with the Configuration Recorder</b> </a> in the <i>Config Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ConfigurationRecorder
    {
        private string _arn;
        private string _name;
        private RecordingGroup _recordingGroup;
        private RecordingMode _recordingMode;
        private RecordingScope _recordingScope;
        private string _rolearn;
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified configuration recorder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration recorder.
        /// </para>
        ///  
        /// <para>
        /// For customer managed configuration recorders, Config automatically assigns the name
        /// of "default" when creating a configuration recorder if you do not specify a name at
        /// creation time.
        /// </para>
        ///  
        /// <para>
        /// For service-linked configuration recorders, Config automatically assigns a name that
        /// has the prefix "<c>AWSConfigurationRecorderFor</c>" to a new service-linked configuration
        /// recorder.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Changing the name of a configuration recorder</b> 
        /// </para>
        ///  
        /// <para>
        /// To change the name of the customer managed configuration recorder, you must delete
        /// it and create a new customer managed configuration recorder with a new name.
        /// </para>
        ///  
        /// <para>
        /// You cannot change the name of a service-linked configuration recorder.
        /// </para>
        ///  </note>
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
        /// Specifies which resource types are in scope for the configuration recorder to record.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b> High Number of Config Evaluations</b> 
        /// </para>
        ///  
        /// <para>
        /// You might notice increased activity in your account during your initial month recording
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
        /// (Amazon EC2) Spot Instances, Amazon EMR jobs, and Auto Scaling.
        /// </para>
        ///  
        /// <para>
        /// If you want to avoid the increased activity from running ephemeral workloads, you
        /// can set up the configuration recorder to exclude these resource types from being recorded,
        /// or run these types of workloads in a separate account with Config turned off to avoid
        /// increased configuration recording and rule evaluations.
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
        /// Gets and sets the property RecordingMode. 
        /// <para>
        /// Specifies the default recording frequency for the configuration recorder. Config supports
        /// <i>Continuous recording</i> and <i>Daily recording</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Continuous recording allows you to record configuration changes continuously whenever
        /// a change occurs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Daily recording allows you to receive a configuration item (CI) representing the most
        /// recent state of your resources over the last 24-hour period, only if it’s different
        /// from the previous CI recorded. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <b>Some resource types require continuous recording</b> 
        /// </para>
        ///  
        /// <para>
        /// Firewall Manager depends on continuous recording to monitor your resources. If you
        /// are using Firewall Manager, it is recommended that you set the recording frequency
        /// to Continuous.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also override the recording frequency for specific resource types.
        /// </para>
        /// </summary>
        public RecordingMode RecordingMode
        {
            get { return this._recordingMode; }
            set { this._recordingMode = value; }
        }

        // Check to see if RecordingMode property is set
        internal bool IsSetRecordingMode()
        {
            return this._recordingMode != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingScope. 
        /// <para>
        /// Specifies whether the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ConfigurationItem.html">ConfigurationItems</a>
        /// in scope for the specified configuration recorder are recorded for free (<c>INTERNAL</c>)
        /// or if it impacts the costs to your bill (<c>PAID</c>).
        /// </para>
        /// </summary>
        public RecordingScope RecordingScope
        {
            get { return this._recordingScope; }
            set { this._recordingScope = value; }
        }

        // Check to see if RecordingScope property is set
        internal bool IsSetRecordingScope()
        {
            return this._recordingScope != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role assumed by Config and used by the specified
        /// configuration recorder.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>The server will reject a request without a defined <c>roleARN</c> for the configuration
        /// recorder</b> 
        /// </para>
        ///  
        /// <para>
        /// While the API model does not require this field, the server will reject a request
        /// without a defined <c>roleARN</c> for the configuration recorder.
        /// </para>
        ///  
        /// <para>
        ///  <b>Policies and compliance results</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// policies</a> and <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies.html">other
        /// policies managed in Organizations</a> can impact whether Config has permissions to
        /// record configuration changes for your resources. Additionally, rules directly evaluate
        /// the configuration of a resource and rules don't take into account these policies when
        /// running evaluations. Make sure that the policies in effect align with how you intend
        /// to use Config.
        /// </para>
        ///  
        /// <para>
        ///  <b>Keep Minimum Permisions When Reusing an IAM role</b> 
        /// </para>
        ///  
        /// <para>
        /// If you use an Amazon Web Services service that uses Config, such as Security Hub or
        /// Control Tower, and an IAM role has already been created, make sure that the IAM role
        /// that you use when setting up Config keeps the same minimum permissions as the pre-existing
        /// IAM role. You must do this to ensure that the other Amazon Web Services service continues
        /// to run as expected. 
        /// </para>
        ///  
        /// <para>
        /// For example, if Control Tower has an IAM role that allows Config to read S3 objects,
        /// make sure that the same permissions are granted to the IAM role you use when setting
        /// up Config. Otherwise, it may interfere with how Control Tower operates.
        /// </para>
        ///  
        /// <para>
        ///  <b>The service-linked IAM role for Config must be used for service-linked configuration
        /// recorders</b> 
        /// </para>
        ///  
        /// <para>
        /// For service-linked configuration recorders, you must use the service-linked IAM role
        /// for Config: <a href="https://docs.aws.amazon.com/config/latest/developerguide/using-service-linked-roles.html">AWSServiceRoleForConfig</a>.
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

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// For service-linked configuration recorders, specifies the linked Amazon Web Services
        /// service for the configuration recorder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ServicePrincipal
        {
            get { return this._servicePrincipal; }
            set { this._servicePrincipal = value; }
        }

        // Check to see if ServicePrincipal property is set
        internal bool IsSetServicePrincipal()
        {
            return this._servicePrincipal != null;
        }

    }
}