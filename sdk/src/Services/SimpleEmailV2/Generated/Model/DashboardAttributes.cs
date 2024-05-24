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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object containing additional settings for your VDM configuration as applicable
    /// to the Dashboard.
    /// </summary>
    public partial class DashboardAttributes
    {
        private FeatureStatus _engagementMetrics;

        /// <summary>
        /// Gets and sets the property EngagementMetrics. 
        /// <para>
        /// Specifies the status of your VDM engagement metrics collection. Can be one of the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – Amazon SES enables engagement metrics for your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Amazon SES disables engagement metrics for your account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FeatureStatus EngagementMetrics
        {
            get { return this._engagementMetrics; }
            set { this._engagementMetrics = value; }
        }

        // Check to see if EngagementMetrics property is set
        internal bool IsSetEngagementMetrics()
        {
            return this._engagementMetrics != null;
        }

    }
}