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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Information about the Amazon QuickSight console that you want to embed.
    /// </summary>
    public partial class RegisteredUserQuickSightConsoleEmbeddingConfiguration
    {
        private RegisteredUserConsoleFeatureConfigurations _featureConfigurations;
        private string _initialPath;

        /// <summary>
        /// Gets and sets the property FeatureConfigurations. 
        /// <para>
        /// The embedding configuration of an embedded Amazon QuickSight console.
        /// </para>
        /// </summary>
        public RegisteredUserConsoleFeatureConfigurations FeatureConfigurations
        {
            get { return this._featureConfigurations; }
            set { this._featureConfigurations = value; }
        }

        // Check to see if FeatureConfigurations property is set
        internal bool IsSetFeatureConfigurations()
        {
            return this._featureConfigurations != null;
        }

        /// <summary>
        /// Gets and sets the property InitialPath. 
        /// <para>
        /// The initial URL path for the Amazon QuickSight console. <code>InitialPath</code> is
        /// required.
        /// </para>
        ///  
        /// <para>
        /// The entry point URL is constrained to the following paths:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>/start</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/start/analyses</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/start/dashboards</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/start/favorites</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/dashboards/DashboardId</code>. <i>DashboardId</i> is the actual ID key from
        /// the Amazon QuickSight console URL of the dashboard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/analyses/AnalysisId</code>. <i>AnalysisId</i> is the actual ID key from the
        /// Amazon QuickSight console URL of the analysis.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string InitialPath
        {
            get { return this._initialPath; }
            set { this._initialPath = value; }
        }

        // Check to see if InitialPath property is set
        internal bool IsSetInitialPath()
        {
            return this._initialPath != null;
        }

    }
}