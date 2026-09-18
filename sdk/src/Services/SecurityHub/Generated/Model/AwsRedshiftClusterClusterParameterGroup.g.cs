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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A cluster parameter group that is associated with an Amazon Redshift cluster.
    /// </summary>
    public partial class AwsRedshiftClusterClusterParameterGroup
    {
        /// <summary>
        /// Gets and sets the property ClusterParameterStatusList. 
        /// <para>
        /// The list of parameter statuses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRedshiftClusterClusterParameterStatus> ClusterParameterStatusList { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRedshiftClusterClusterParameterStatus>() : null;

        /// <summary>
        /// Checks to see if the ClusterParameterStatusList property is set.
        /// </summary>
        internal bool IsSetClusterParameterStatusList() => this.ClusterParameterStatusList != null && (this.ClusterParameterStatusList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of updates to the parameters.
        /// </para>
        /// </summary>
        public string ParameterApplyStatus { get; set; }

        /// <summary>
        /// Checks to see if the ParameterApplyStatus property is set.
        /// </summary>
        internal bool IsSetParameterApplyStatus() => this.ParameterApplyStatus != null;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group.
        /// </para>
        /// </summary>
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupName property is set.
        /// </summary>
        internal bool IsSetParameterGroupName() => this.ParameterGroupName != null;
    }
}
