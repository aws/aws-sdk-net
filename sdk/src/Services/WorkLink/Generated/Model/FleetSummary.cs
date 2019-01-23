/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// The summary of the fleet.
    /// </summary>
    public partial class FleetSummary
    {
        private string _companyCode;
        private DateTime? _createdTime;
        private string _displayName;
        private string _fleetArn;
        private string _fleetName;
        private FleetStatus _fleetStatus;
        private DateTime? _lastUpdatedTime;

        /// <summary>
        /// Gets and sets the property CompanyCode. 
        /// <para>
        /// The identifier used by users to sign into the Amazon WorkLink app.
        /// </para>
        /// </summary>
        public string CompanyCode
        {
            get { return this._companyCode; }
            set { this._companyCode = value; }
        }

        // Check to see if CompanyCode property is set
        internal bool IsSetCompanyCode()
        {
            return this._companyCode != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time when the fleet was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name to display.
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
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The ARN of the fleet.
        /// </para>
        /// </summary>
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet.
        /// </para>
        /// </summary>
        public string FleetName
        {
            get { return this._fleetName; }
            set { this._fleetName = value; }
        }

        // Check to see if FleetName property is set
        internal bool IsSetFleetName()
        {
            return this._fleetName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetStatus. 
        /// <para>
        /// The status of the fleet.
        /// </para>
        /// </summary>
        public FleetStatus FleetStatus
        {
            get { return this._fleetStatus; }
            set { this._fleetStatus = value; }
        }

        // Check to see if FleetStatus property is set
        internal bool IsSetFleetStatus()
        {
            return this._fleetStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the fleet was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

    }
}