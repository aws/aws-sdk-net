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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The current status of the service software for an Amazon OpenSearch Service domain.
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">Service
    /// software updates in Amazon OpenSearch Service</a>.
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
        /// The timestamp, in Epoch time, until which you can manually request a service software
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
        ///  True if you're able to cancel your service software version update. False if you
        /// can't cancel your service software update.
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
        /// The current service software version present on the domain.
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
        /// A description of the service software update status.
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
        /// The new service software version, if one is available.
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
        /// True if a service software is never automatically updated. False if a service software
        /// is automatically updated after the automated update date.
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
        /// True if you're able to update your service software version. False if you can't update
        /// your service software version.
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
        /// The status of your service software update.
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