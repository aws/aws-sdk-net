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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Indicates the type of data that is being exported. Only one <c>ExportPreferences</c>
    /// can be enabled for a <a href="https://docs.aws.amazon.com/application-discovery/latest/APIReference/API_StartExportTask.html">StartExportTask</a>
    /// action.
    /// </summary>
    public partial class ExportPreferences
    {
        /// <summary>
        /// Gets and sets the property Ec2RecommendationsPreferences. 
        /// <para>
        ///  If enabled, exported data includes EC2 instance type matches for on-premises servers
        /// discovered through Amazon Web Services Application Discovery Service. 
        /// </para>
        /// </summary>
        public Ec2RecommendationsExportPreferences Ec2RecommendationsPreferences { get; set; }

        /// <summary>
        /// Checks to see if the Ec2RecommendationsPreferences property is set.
        /// </summary>
        internal bool IsSetEc2RecommendationsPreferences() => this.Ec2RecommendationsPreferences != null;
    }
}
