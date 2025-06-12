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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of a parameter group.
    /// </summary>
    public partial class ClusterParameterGroupStatus
    {
        private List<ClusterParameterStatus> _clusterParameterStatusList = AWSConfigs.InitializeCollections ? new List<ClusterParameterStatus>() : null;
        private string _parameterApplyStatus;
        private string _parameterGroupName;

        /// <summary>
        /// Gets and sets the property ClusterParameterStatusList. 
        /// <para>
        /// The list of parameter statuses.
        /// </para>
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterParameterStatus> ClusterParameterStatusList
        {
            get { return this._clusterParameterStatusList; }
            set { this._clusterParameterStatusList = value; }
        }

        // Check to see if ClusterParameterStatusList property is set
        internal bool IsSetClusterParameterStatusList()
        {
            return this._clusterParameterStatusList != null && (this._clusterParameterStatusList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of parameter updates.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ParameterApplyStatus
        {
            get { return this._parameterApplyStatus; }
            set { this._parameterApplyStatus = value; }
        }

        // Check to see if ParameterApplyStatus property is set
        internal bool IsSetParameterApplyStatus()
        {
            return this._parameterApplyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the cluster parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

    }
}