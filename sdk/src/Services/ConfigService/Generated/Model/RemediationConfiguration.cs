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
    /// An object that represents the details about the remediation configuration that includes
    /// the remediation action, parameters, and data to execute the action.
    /// </summary>
    public partial class RemediationConfiguration
    {
        private string _arn;
        private bool? _automatic;
        private string _configRuleName;
        private string _createdByService;
        private ExecutionControls _executionControls;
        private int? _maximumAutomaticAttempts;
        private Dictionary<string, RemediationParameterValue> _parameters = new Dictionary<string, RemediationParameterValue>();
        private string _resourceType;
        private long? _retryAttemptSeconds;
        private string _targetId;
        private RemediationTargetType _targetType;
        private string _targetVersion;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) of remediation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Automatic. 
        /// <para>
        /// The remediation is triggered automatically.
        /// </para>
        /// </summary>
        public bool Automatic
        {
            get { return this._automatic.GetValueOrDefault(); }
            set { this._automatic = value; }
        }

        // Check to see if Automatic property is set
        internal bool IsSetAutomatic()
        {
            return this._automatic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedByService. 
        /// <para>
        /// Name of the service that owns the service-linked rule, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string CreatedByService
        {
            get { return this._createdByService; }
            set { this._createdByService = value; }
        }

        // Check to see if CreatedByService property is set
        internal bool IsSetCreatedByService()
        {
            return this._createdByService != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionControls. 
        /// <para>
        /// An ExecutionControls object.
        /// </para>
        /// </summary>
        public ExecutionControls ExecutionControls
        {
            get { return this._executionControls; }
            set { this._executionControls = value; }
        }

        // Check to see if ExecutionControls property is set
        internal bool IsSetExecutionControls()
        {
            return this._executionControls != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumAutomaticAttempts. 
        /// <para>
        /// The maximum number of failed attempts for auto-remediation. If you do not select a
        /// number, the default is 5.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify MaximumAutomaticAttempts as 5 with RetryAttemptSeconds
        /// as 50 seconds, Config will put a RemediationException on your behalf for the failing
        /// resource after the 5th failed attempt within 50 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int MaximumAutomaticAttempts
        {
            get { return this._maximumAutomaticAttempts.GetValueOrDefault(); }
            set { this._maximumAutomaticAttempts = value; }
        }

        // Check to see if MaximumAutomaticAttempts property is set
        internal bool IsSetMaximumAutomaticAttempts()
        {
            return this._maximumAutomaticAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An object of the RemediationParameterValue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public Dictionary<string, RemediationParameterValue> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of a resource. 
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property RetryAttemptSeconds. 
        /// <para>
        /// Maximum time in seconds that Config runs auto-remediation. If you do not select a
        /// number, the default is 60 seconds. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify RetryAttemptSeconds as 50 seconds and MaximumAutomaticAttempts
        /// as 5, Config will run auto-remediations 5 times within 50 seconds before throwing
        /// an exception.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2678000)]
        public long RetryAttemptSeconds
        {
            get { return this._retryAttemptSeconds.GetValueOrDefault(); }
            set { this._retryAttemptSeconds = value; }
        }

        // Check to see if RetryAttemptSeconds property is set
        internal bool IsSetRetryAttemptSeconds()
        {
            return this._retryAttemptSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// Target ID is the name of the SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of the target. Target executes remediation. For example, SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RemediationTargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// Version of the target. For example, version of the SSM document.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you make backward incompatible changes to the SSM document, you must call PutRemediationConfiguration
        /// API again to ensure the remediations can run.
        /// </para>
        ///  </note>
        /// </summary>
        public string TargetVersion
        {
            get { return this._targetVersion; }
            set { this._targetVersion = value; }
        }

        // Check to see if TargetVersion property is set
        internal bool IsSetTargetVersion()
        {
            return this._targetVersion != null;
        }

    }
}