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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The environment deployment details.
    /// </summary>
    public partial class EnvironmentDeploymentDetails
    {
        private Dictionary<string, List<EnvironmentError>> _environmentFailureReasons = AWSConfigs.InitializeCollections ? new Dictionary<string, List<EnvironmentError>>() : null;
        private OverallDeploymentStatus _overallDeploymentStatus;

        /// <summary>
        /// Gets and sets the property EnvironmentFailureReasons. 
        /// <para>
        /// Environment failure reasons.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<EnvironmentError>> EnvironmentFailureReasons
        {
            get { return this._environmentFailureReasons; }
            set { this._environmentFailureReasons = value; }
        }

        // Check to see if EnvironmentFailureReasons property is set
        internal bool IsSetEnvironmentFailureReasons()
        {
            return this._environmentFailureReasons != null && (this._environmentFailureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverallDeploymentStatus. 
        /// <para>
        /// The overall deployment status of the environment.
        /// </para>
        /// </summary>
        public OverallDeploymentStatus OverallDeploymentStatus
        {
            get { return this._overallDeploymentStatus; }
            set { this._overallDeploymentStatus = value; }
        }

        // Check to see if OverallDeploymentStatus property is set
        internal bool IsSetOverallDeploymentStatus()
        {
            return this._overallDeploymentStatus != null;
        }

    }
}