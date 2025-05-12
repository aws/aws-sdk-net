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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Maintenance configuration settings for the SageMaker Partner AI App.
    /// </summary>
    public partial class PartnerAppMaintenanceConfig
    {
        private string _maintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property MaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week in Coordinated Universal Time (UTC) 24-hour standard
        /// time that weekly maintenance updates are scheduled. This value must take the following
        /// format: <c>3-letter-day:24-h-hour:minute</c>. For example: <c>TUE:03:30</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9)]
        public string MaintenanceWindowStart
        {
            get { return this._maintenanceWindowStart; }
            set { this._maintenanceWindowStart = value; }
        }

        // Check to see if MaintenanceWindowStart property is set
        internal bool IsSetMaintenanceWindowStart()
        {
            return this._maintenanceWindowStart != null;
        }

    }
}