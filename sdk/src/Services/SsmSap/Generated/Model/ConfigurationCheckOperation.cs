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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Represents a configuration check operation that has been executed against an application.
    /// </summary>
    public partial class ConfigurationCheckOperation
    {
        private string _applicationId;
        private string _configurationCheckDescription;
        private ConfigurationCheckType _configurationCheckId;
        private string _configurationCheckName;
        private DateTime? _endTime;
        private string _id;
        private RuleStatusCounts _ruleStatusCounts;
        private DateTime? _startTime;
        private OperationStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application against which the configuration check was performed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
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
        /// Gets and sets the property ConfigurationCheckDescription. 
        /// <para>
        /// A description of the configuration check that was performed.
        /// </para>
        /// </summary>
        public string ConfigurationCheckDescription
        {
            get { return this._configurationCheckDescription; }
            set { this._configurationCheckDescription = value; }
        }

        // Check to see if ConfigurationCheckDescription property is set
        internal bool IsSetConfigurationCheckDescription()
        {
            return this._configurationCheckDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationCheckId. 
        /// <para>
        /// The unique identifier of the configuration check that was performed.
        /// </para>
        /// </summary>
        public ConfigurationCheckType ConfigurationCheckId
        {
            get { return this._configurationCheckId; }
            set { this._configurationCheckId = value; }
        }

        // Check to see if ConfigurationCheckId property is set
        internal bool IsSetConfigurationCheckId()
        {
            return this._configurationCheckId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationCheckName. 
        /// <para>
        /// The name of the configuration check that was performed.
        /// </para>
        /// </summary>
        public string ConfigurationCheckName
        {
            get { return this._configurationCheckName; }
            set { this._configurationCheckName = value; }
        }

        // Check to see if ConfigurationCheckName property is set
        internal bool IsSetConfigurationCheckName()
        {
            return this._configurationCheckName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the configuration check operation completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the configuration check operation.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RuleStatusCounts. 
        /// <para>
        /// A summary of all the rule results, showing counts for each status type.
        /// </para>
        /// </summary>
        public RuleStatusCounts RuleStatusCounts
        {
            get { return this._ruleStatusCounts; }
            set { this._ruleStatusCounts = value; }
        }

        // Check to see if RuleStatusCounts property is set
        internal bool IsSetRuleStatusCounts()
        {
            return this._ruleStatusCounts != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the configuration check operation started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the configuration check operation.
        /// </para>
        /// </summary>
        public OperationStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message providing additional details about the status of the configuration check
        /// operation.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}