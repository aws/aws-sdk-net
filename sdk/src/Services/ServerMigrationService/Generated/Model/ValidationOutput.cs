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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Contains validation output.
    /// </summary>
    public partial class ValidationOutput
    {
        private AppValidationOutput _appValidationOutput;
        private DateTime? _latestValidationTime;
        private string _name;
        private ServerValidationOutput _serverValidationOutput;
        private ValidationStatus _status;
        private string _statusMessage;
        private string _validationId;

        /// <summary>
        /// Gets and sets the property AppValidationOutput. 
        /// <para>
        /// The output from validating an application.
        /// </para>
        /// </summary>
        public AppValidationOutput AppValidationOutput
        {
            get { return this._appValidationOutput; }
            set { this._appValidationOutput = value; }
        }

        // Check to see if AppValidationOutput property is set
        internal bool IsSetAppValidationOutput()
        {
            return this._appValidationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property LatestValidationTime. 
        /// <para>
        /// The latest time that the validation was performed.
        /// </para>
        /// </summary>
        public DateTime LatestValidationTime
        {
            get { return this._latestValidationTime.GetValueOrDefault(); }
            set { this._latestValidationTime = value; }
        }

        // Check to see if LatestValidationTime property is set
        internal bool IsSetLatestValidationTime()
        {
            return this._latestValidationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the validation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ServerValidationOutput. 
        /// <para>
        /// The output from validation an instance.
        /// </para>
        /// </summary>
        public ServerValidationOutput ServerValidationOutput
        {
            get { return this._serverValidationOutput; }
            set { this._serverValidationOutput = value; }
        }

        // Check to see if ServerValidationOutput property is set
        internal bool IsSetServerValidationOutput()
        {
            return this._serverValidationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the validation.
        /// </para>
        /// </summary>
        public ValidationStatus Status
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
        /// The status message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2500)]
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

        /// <summary>
        /// Gets and sets the property ValidationId. 
        /// <para>
        /// The ID of the validation.
        /// </para>
        /// </summary>
        public string ValidationId
        {
            get { return this._validationId; }
            set { this._validationId = value; }
        }

        // Check to see if ValidationId property is set
        internal bool IsSetValidationId()
        {
            return this._validationId != null;
        }

    }
}