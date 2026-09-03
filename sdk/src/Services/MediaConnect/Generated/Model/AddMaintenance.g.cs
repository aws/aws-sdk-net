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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Create a maintenance setting for a flow.
    /// </summary>
    public partial class AddMaintenance
    {
        /// <summary>
        /// Gets and sets the property MaintenanceDay. 
        /// <para>
        ///  A day of a week when the maintenance will happen. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MaintenanceDay MaintenanceDay { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceDay property is set.
        /// </summary>
        internal bool IsSetMaintenanceDay() => this.MaintenanceDay != null;

        /// <summary>
        /// Gets and sets the property MaintenanceStartHour. 
        /// <para>
        ///  UTC time when the maintenance will happen. 
        /// </para>
        ///  
        /// <para>
        /// Use 24-hour HH:MM format. 
        /// </para>
        ///  
        /// <para>
        /// Minutes must be 00. 
        /// </para>
        ///  
        /// <para>
        /// Example: 13:00. 
        /// </para>
        ///  
        /// <para>
        /// The default value is 02:00.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MaintenanceStartHour { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceStartHour property is set.
        /// </summary>
        internal bool IsSetMaintenanceStartHour() => this.MaintenanceStartHour != null;
    }
}
