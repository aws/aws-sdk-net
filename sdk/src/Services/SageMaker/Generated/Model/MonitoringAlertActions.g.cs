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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A list of alert actions taken in response to an alert going into <c>InAlert</c> status.
    /// </summary>
    public partial class MonitoringAlertActions
    {
        /// <summary>
        /// Gets and sets the property ModelDashboardIndicator. 
        /// <para>
        /// An alert action taken to light up an icon on the Model Dashboard when an alert goes
        /// into <c>InAlert</c> status.
        /// </para>
        /// </summary>
        public ModelDashboardIndicatorAction ModelDashboardIndicator { get; set; }

        /// <summary>
        /// Checks to see if the ModelDashboardIndicator property is set.
        /// </summary>
        internal bool IsSetModelDashboardIndicator() => this.ModelDashboardIndicator != null;
    }
}
