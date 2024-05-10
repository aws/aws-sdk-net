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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a deferred maintenance window
    /// </summary>
    public partial class DeferredMaintenanceWindow
    {
        private DateTime? _deferMaintenanceEndTime;
        private string _deferMaintenanceIdentifier;
        private DateTime? _deferMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property DeferMaintenanceEndTime. 
        /// <para>
        ///  A timestamp for the end of the time period when we defer maintenance.
        /// </para>
        /// </summary>
        public DateTime? DeferMaintenanceEndTime
        {
            get { return this._deferMaintenanceEndTime; }
            set { this._deferMaintenanceEndTime = value; }
        }

        // Check to see if DeferMaintenanceEndTime property is set
        internal bool IsSetDeferMaintenanceEndTime()
        {
            return this._deferMaintenanceEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenanceIdentifier. 
        /// <para>
        /// A unique identifier for the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DeferMaintenanceIdentifier
        {
            get { return this._deferMaintenanceIdentifier; }
            set { this._deferMaintenanceIdentifier = value; }
        }

        // Check to see if DeferMaintenanceIdentifier property is set
        internal bool IsSetDeferMaintenanceIdentifier()
        {
            return this._deferMaintenanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenanceStartTime. 
        /// <para>
        ///  A timestamp for the beginning of the time period when we defer maintenance.
        /// </para>
        /// </summary>
        public DateTime? DeferMaintenanceStartTime
        {
            get { return this._deferMaintenanceStartTime; }
            set { this._deferMaintenanceStartTime = value; }
        }

        // Check to see if DeferMaintenanceStartTime property is set
        internal bool IsSetDeferMaintenanceStartTime()
        {
            return this._deferMaintenanceStartTime.HasValue; 
        }

    }
}