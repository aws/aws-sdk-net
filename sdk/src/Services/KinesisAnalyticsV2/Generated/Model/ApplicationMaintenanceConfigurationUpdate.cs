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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the updated maintenance configuration for the application.
    /// </summary>
    public partial class ApplicationMaintenanceConfigurationUpdate
    {
        private string _applicationMaintenanceWindowStartTimeUpdate;

        /// <summary>
        /// Gets and sets the property ApplicationMaintenanceWindowStartTimeUpdate. 
        /// <para>
        /// The updated start time for the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
        public string ApplicationMaintenanceWindowStartTimeUpdate
        {
            get { return this._applicationMaintenanceWindowStartTimeUpdate; }
            set { this._applicationMaintenanceWindowStartTimeUpdate = value; }
        }

        // Check to see if ApplicationMaintenanceWindowStartTimeUpdate property is set
        internal bool IsSetApplicationMaintenanceWindowStartTimeUpdate()
        {
            return this._applicationMaintenanceWindowStartTimeUpdate != null;
        }

    }
}