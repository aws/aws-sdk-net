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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// This is the response object from the GetApplication operation.
    /// </summary>
    public partial class GetApplicationResponse : AmazonWebServiceResponse
    {
        private string _applicationArn;
        private string _applicationId;
        private DateTime? _creationTime;
        private DeployedVersionSummary _deployedVersion;
        private string _description;
        private EngineType _engineType;
        private string _environmentId;
        private string _kmsKeyId;
        private DateTime? _lastStartTime;
        private ApplicationVersionSummary _latestVersion;
        private List<string> _listenerArns = new List<string>();
        private List<int> _listenerPorts = new List<int>();
        private string _loadBalancerDnsName;
        private List<LogGroupSummary> _logGroups = new List<LogGroupSummary>();
        private string _name;
        private ApplicationLifecycle _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<string> _targetGroupArns = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when this application was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeployedVersion. 
        /// <para>
        /// The version of the application that is deployed.
        /// </para>
        /// </summary>
        public DeployedVersionSummary DeployedVersion
        {
            get { return this._deployedVersion; }
            set { this._deployedVersion = value; }
        }

        // Check to see if DeployedVersion property is set
        internal bool IsSetDeployedVersion()
        {
            return this._deployedVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The type of the target platform for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of the runtime environment where you want to deploy the application.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of a customer managed key.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LastStartTime. 
        /// <para>
        /// The timestamp when you last started the application. Null until the application runs
        /// for the first time.
        /// </para>
        /// </summary>
        public DateTime LastStartTime
        {
            get { return this._lastStartTime.GetValueOrDefault(); }
            set { this._lastStartTime = value; }
        }

        // Check to see if LastStartTime property is set
        internal bool IsSetLastStartTime()
        {
            return this._lastStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The latest version of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationVersionSummary LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the network load balancer listener created in your
        /// Amazon Web Services account. Amazon Web Services Mainframe Modernization creates this
        /// listener for you the first time you deploy an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> ListenerArns
        {
            get { return this._listenerArns; }
            set { this._listenerArns = value; }
        }

        // Check to see if ListenerArns property is set
        internal bool IsSetListenerArns()
        {
            return this._listenerArns != null && this._listenerArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListenerPorts. 
        /// <para>
        /// The port associated with the network load balancer listener created in your Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<int> ListenerPorts
        {
            get { return this._listenerPorts; }
            set { this._listenerPorts = value; }
        }

        // Check to see if ListenerPorts property is set
        internal bool IsSetListenerPorts()
        {
            return this._listenerPorts != null && this._listenerPorts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerDnsName. 
        /// <para>
        /// The public DNS name of the load balancer created in your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string LoadBalancerDnsName
        {
            get { return this._loadBalancerDnsName; }
            set { this._loadBalancerDnsName = value; }
        }

        // Check to see if LoadBalancerDnsName property is set
        internal bool IsSetLoadBalancerDnsName()
        {
            return this._loadBalancerDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroups. 
        /// <para>
        /// The list of log summaries. Each log summary includes the log type as well as the log
        /// group identifier. These are CloudWatch logs. Amazon Web Services Mainframe Modernization
        /// pushes the application log to CloudWatch under the customer's account.
        /// </para>
        /// </summary>
        public List<LogGroupSummary> LogGroups
        {
            get { return this._logGroups; }
            set { this._logGroups = value; }
        }

        // Check to see if LogGroups property is set
        internal bool IsSetLogGroups()
        {
            return this._logGroups != null && this._logGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique identifier of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationLifecycle Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the reported status.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetGroupArns. 
        /// <para>
        /// Returns the Amazon Resource Names (ARNs) of the target groups that are attached to
        /// the network load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> TargetGroupArns
        {
            get { return this._targetGroupArns; }
            set { this._targetGroupArns = value; }
        }

        // Check to see if TargetGroupArns property is set
        internal bool IsSetTargetGroupArns()
        {
            return this._targetGroupArns != null && this._targetGroupArns.Count > 0; 
        }

    }
}