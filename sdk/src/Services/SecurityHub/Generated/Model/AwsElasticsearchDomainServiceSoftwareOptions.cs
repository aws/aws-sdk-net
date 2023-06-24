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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the state of the domain relative to the latest service software.
    /// </summary>
    public partial class AwsElasticsearchDomainServiceSoftwareOptions
    {
        private string _automatedUpdateDate;
        private bool? _cancellable;
        private string _currentVersion;
        private string _description;
        private string _newVersion;
        private bool? _updateAvailable;
        private string _updateStatus;

        /// <summary>
        /// Gets and sets the property AutomatedUpdateDate. 
        /// <para>
        /// The epoch time when the deployment window closes for required updates. After this
        /// time, Amazon OpenSearch Service schedules the software upgrade automatically.
        /// </para>
        /// </summary>
        public string AutomatedUpdateDate
        {
            get { return this._automatedUpdateDate; }
            set { this._automatedUpdateDate = value; }
        }

        // Check to see if AutomatedUpdateDate property is set
        internal bool IsSetAutomatedUpdateDate()
        {
            return this._automatedUpdateDate != null;
        }

        /// <summary>
        /// Gets and sets the property Cancellable. 
        /// <para>
        /// Whether a request to update the domain can be canceled.
        /// </para>
        /// </summary>
        public bool Cancellable
        {
            get { return this._cancellable.GetValueOrDefault(); }
            set { this._cancellable = value; }
        }

        // Check to see if Cancellable property is set
        internal bool IsSetCancellable()
        {
            return this._cancellable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of the service software that is currently installed on the domain.
        /// </para>
        /// </summary>
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A more detailed description of the service software status.
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
        /// Gets and sets the property NewVersion. 
        /// <para>
        /// The most recent version of the service software.
        /// </para>
        /// </summary>
        public string NewVersion
        {
            get { return this._newVersion; }
            set { this._newVersion = value; }
        }

        // Check to see if NewVersion property is set
        internal bool IsSetNewVersion()
        {
            return this._newVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateAvailable. 
        /// <para>
        /// Whether a service software update is available for the domain.
        /// </para>
        /// </summary>
        public bool UpdateAvailable
        {
            get { return this._updateAvailable.GetValueOrDefault(); }
            set { this._updateAvailable = value; }
        }

        // Check to see if UpdateAvailable property is set
        internal bool IsSetUpdateAvailable()
        {
            return this._updateAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The status of the service software update. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>COMPLETED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ELIGIBLE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_ELIGIBLE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_UPDATE</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

    }
}