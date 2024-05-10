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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
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
namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// Describes a workload.
    /// </summary>
    public partial class WorkloadData
    {
        private string _description;
        private string _displayName;
        private string _documentationUrl;
        private string _iconUrl;
        private WorkloadStatus _status;
        private string _statusMessage;
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a workload.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of a workload.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentationUrl. 
        /// <para>
        /// The URL of a workload document.
        /// </para>
        /// </summary>
        public string DocumentationUrl
        {
            get { return this._documentationUrl; }
            set { this._documentationUrl = value; }
        }

        // Check to see if DocumentationUrl property is set
        internal bool IsSetDocumentationUrl()
        {
            return this._documentationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property IconUrl. 
        /// <para>
        /// The URL of a workload icon.
        /// </para>
        /// </summary>
        public string IconUrl
        {
            get { return this._iconUrl; }
            set { this._iconUrl = value; }
        }

        // Check to see if IconUrl property is set
        internal bool IsSetIconUrl()
        {
            return this._iconUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a workload.
        /// </para>
        /// </summary>
        public WorkloadStatus Status
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
        /// The message about a workload's status.
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

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string WorkloadName
        {
            get { return this._workloadName; }
            set { this._workloadName = value; }
        }

        // Check to see if WorkloadName property is set
        internal bool IsSetWorkloadName()
        {
            return this._workloadName != null;
        }

    }
}