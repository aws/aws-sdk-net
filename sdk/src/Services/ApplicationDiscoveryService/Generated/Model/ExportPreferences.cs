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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Indicates the type of data that is being exported. Only one <c>ExportPreferences</c>
    /// can be enabled for a <a href="https://docs.aws.amazon.com/application-discovery/latest/APIReference/API_StartExportTask.html">StartExportTask</a>
    /// action.
    /// </summary>
    public partial class ExportPreferences
    {
        private Ec2RecommendationsExportPreferences _ec2RecommendationsPreferences;

        /// <summary>
        /// Gets and sets the property Ec2RecommendationsPreferences. 
        /// <para>
        ///  If enabled, exported data includes EC2 instance type matches for on-premises servers
        /// discovered through Amazon Web Services Application Discovery Service. 
        /// </para>
        /// </summary>
        public Ec2RecommendationsExportPreferences Ec2RecommendationsPreferences
        {
            get { return this._ec2RecommendationsPreferences; }
            set { this._ec2RecommendationsPreferences = value; }
        }

        // Check to see if Ec2RecommendationsPreferences property is set
        internal bool IsSetEc2RecommendationsPreferences()
        {
            return this._ec2RecommendationsPreferences != null;
        }

    }
}