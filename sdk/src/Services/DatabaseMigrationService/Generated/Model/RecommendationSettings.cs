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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information about the required target engine settings.
    /// </summary>
    public partial class RecommendationSettings
    {
        private string _instanceSizingType;
        private string _workloadType;

        /// <summary>
        /// Gets and sets the property InstanceSizingType. 
        /// <para>
        /// The size of your target instance. Fleet Advisor calculates this value based on your
        /// data collection type, such as total capacity and resource utilization. Valid values
        /// include <code>"total-capacity"</code> and <code>"utilization"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceSizingType
        {
            get { return this._instanceSizingType; }
            set { this._instanceSizingType = value; }
        }

        // Check to see if InstanceSizingType property is set
        internal bool IsSetInstanceSizingType()
        {
            return this._instanceSizingType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadType. 
        /// <para>
        /// The deployment option for your target engine. For production databases, Fleet Advisor
        /// chooses Multi-AZ deployment. For development or test databases, Fleet Advisor chooses
        /// Single-AZ deployment. Valid values include <code>"development"</code> and <code>"production"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkloadType
        {
            get { return this._workloadType; }
            set { this._workloadType = value; }
        }

        // Check to see if WorkloadType property is set
        internal bool IsSetWorkloadType()
        {
            return this._workloadType != null;
        }

    }
}