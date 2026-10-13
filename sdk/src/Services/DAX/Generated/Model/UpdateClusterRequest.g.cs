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

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCluster operation. Modifies the settings
    /// for a DAX cluster. You can use this action to change one or more cluster configuration
    /// parameters by specifying the parameters and the new values.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonDAXRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the DAX cluster to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the changes being made to the cluster.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property NotificationTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the topic.
        /// </para>
        /// </summary>
        public string NotificationTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationTopicArn property is set.
        /// </summary>
        internal bool IsSetNotificationTopicArn() => this.NotificationTopicArn != null;

        /// <summary>
        /// Gets and sets the property NotificationTopicStatus. 
        /// <para>
        /// The current state of the topic. A value of “active” means that notifications will
        /// be sent to the topic. A value of “inactive” means that notifications will not be sent
        /// to the topic.
        /// </para>
        /// </summary>
        public string NotificationTopicStatus { get; set; }

        /// <summary>
        /// Checks to see if the NotificationTopicStatus property is set.
        /// </summary>
        internal bool IsSetNotificationTopicStatus() => this.NotificationTopicStatus != null;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of a parameter group for this cluster.
        /// </para>
        /// </summary>
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupName property is set.
        /// </summary>
        internal bool IsSetParameterGroupName() => this.ParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// A range of time when maintenance of DAX cluster software will be performed. For example:
        /// <c>sun:01:00-sun:09:00</c>. Cluster maintenance normally takes less than 30 minutes,
        /// and is performed automatically within the maintenance window.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of user-specified security group IDs to be assigned to each node in the DAX
        /// cluster. If this parameter is not specified, DAX assigns the default VPC security
        /// group to each node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
