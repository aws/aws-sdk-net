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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAnomalyMonitor operation.
    /// Creates a new cost anomaly detection monitor with the requested type and monitor specification.
    /// </summary>
    public partial class CreateAnomalyMonitorRequest : AmazonCostExplorerRequest
    {
        private AnomalyMonitor _anomalyMonitor;

        /// <summary>
        /// Gets and sets the property AnomalyMonitor. 
        /// <para>
        ///  The cost anomaly detection monitor object that you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalyMonitor AnomalyMonitor
        {
            get { return this._anomalyMonitor; }
            set { this._anomalyMonitor = value; }
        }

        // Check to see if AnomalyMonitor property is set
        internal bool IsSetAnomalyMonitor()
        {
            return this._anomalyMonitor != null;
        }

    }
}