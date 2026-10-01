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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Details about a CloudFormation stack that has been deployed as part of the network
    /// migration.
    /// </summary>
    public partial class NetworkMigrationDeployedStackDetails
    {
        /// <summary>
        /// Gets and sets the property FailedResources. 
        /// <para>
        /// A list of resources that failed to deploy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<NetworkMigrationFailedResourceDetails> FailedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkMigrationFailedResourceDetails>() : null;

        /// <summary>
        /// Checks to see if the FailedResources property is set.
        /// </summary>
        internal bool IsSetFailedResources() => this.FailedResources != null && (this.FailedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The ID of the segment that this stack was deployed for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SegmentID { get; set; }

        /// <summary>
        /// Checks to see if the SegmentID property is set.
        /// </summary>
        internal bool IsSetSegmentID() => this.SegmentID != null;

        /// <summary>
        /// Gets and sets the property StackLogicalID. 
        /// <para>
        /// The logical ID of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StackLogicalID { get; set; }

        /// <summary>
        /// Checks to see if the StackLogicalID property is set.
        /// </summary>
        internal bool IsSetStackLogicalID() => this.StackLogicalID != null;

        /// <summary>
        /// Gets and sets the property StackPhysicalID. 
        /// <para>
        /// The physical ID of the CloudFormation stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 86, Max = 128)]
        public string StackPhysicalID { get; set; }

        /// <summary>
        /// Checks to see if the StackPhysicalID property is set.
        /// </summary>
        internal bool IsSetStackPhysicalID() => this.StackPhysicalID != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the deployed stack.
        /// </para>
        /// </summary>
        public NetworkMigrationDeployedStackStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetAccount. 
        /// <para>
        /// The target AWS account where the stack was deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string TargetAccount { get; set; }

        /// <summary>
        /// Checks to see if the TargetAccount property is set.
        /// </summary>
        internal bool IsSetTargetAccount() => this.TargetAccount != null;
    }
}
