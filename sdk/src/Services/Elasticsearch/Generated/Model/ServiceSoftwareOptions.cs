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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The current options of an Elasticsearch domain service software options.
    /// </summary>
    public partial class ServiceSoftwareOptions
    {
        private DateTime? _automatedUpdateDate;
        private bool? _cancellable;
        private string _currentVersion;
        private string _description;
        private string _newVersion;
        private bool? _optionalDeployment;
        private bool? _updateAvailable;
        private DeploymentStatus _updateStatus;

        /// <summary>
        /// Gets and sets the property AutomatedUpdateDate. 
        /// <para>
        /// Timestamp, in Epoch time, until which you can manually request a service software
        /// update. After this date, we automatically update your service software.
        /// </para>
        /// </summary>
        public DateTime? AutomatedUpdateDate
        {
            get { return this._automatedUpdateDate; }
            set { this._automatedUpdateDate = value; }
        }

        // Check to see if AutomatedUpdateDate property is set
        internal bool IsSetAutomatedUpdateDate()
        {
            return this._automatedUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Cancellable. 
        /// <para>
        /// <c>True</c> if you are able to cancel your service software version update. <c>False</c>
        /// if you are not able to cancel your service software version. 
        /// </para>
        /// </summary>
        public bool? Cancellable
        {
            get { return this._cancellable; }
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
        /// The current service software version that is present on the domain.
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
        /// The description of the <c>UpdateStatus</c>.
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
        /// The new service software version if one is available.
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
        /// Gets and sets the property OptionalDeployment. 
        /// <para>
        /// <c>True</c> if a service software is never automatically updated. <c>False</c> if
        /// a service software is automatically updated after <c>AutomatedUpdateDate</c>. 
        /// </para>
        /// </summary>
        public bool? OptionalDeployment
        {
            get { return this._optionalDeployment; }
            set { this._optionalDeployment = value; }
        }

        // Check to see if OptionalDeployment property is set
        internal bool IsSetOptionalDeployment()
        {
            return this._optionalDeployment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateAvailable. 
        /// <para>
        /// <c>True</c> if you are able to update you service software version. <c>False</c> if
        /// you are not able to update your service software version. 
        /// </para>
        /// </summary>
        public bool? UpdateAvailable
        {
            get { return this._updateAvailable; }
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
        /// The status of your service software update. This field can take the following values:
        /// <c>ELIGIBLE</c>, <c>PENDING_UPDATE</c>, <c>IN_PROGRESS</c>, <c>COMPLETED</c>, and
        /// <c>NOT_ELIGIBLE</c>.
        /// </para>
        /// </summary>
        public DeploymentStatus UpdateStatus
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