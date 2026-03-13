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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
        private List<NetworkMigrationFailedResourceDetails> _failedResources = AWSConfigs.InitializeCollections ? new List<NetworkMigrationFailedResourceDetails>() : null;
        private string _segmentid;
        private string _stackLogicalID;
        private string _stackPhysicalID;
        private NetworkMigrationDeployedStackStatus _status;
        private string _targetAccount;

        /// <summary>
        /// Gets and sets the property FailedResources. 
        /// <para>
        /// A list of resources that failed to deploy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<NetworkMigrationFailedResourceDetails> FailedResources
        {
            get { return this._failedResources; }
            set { this._failedResources = value; }
        }

        // Check to see if FailedResources property is set
        internal bool IsSetFailedResources()
        {
            return this._failedResources != null && (this._failedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The ID of the segment that this stack was deployed for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SegmentID
        {
            get { return this._segmentid; }
            set { this._segmentid = value; }
        }

        // Check to see if SegmentID property is set
        internal bool IsSetSegmentID()
        {
            return this._segmentid != null;
        }

        /// <summary>
        /// Gets and sets the property StackLogicalID. 
        /// <para>
        /// The logical ID of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StackLogicalID
        {
            get { return this._stackLogicalID; }
            set { this._stackLogicalID = value; }
        }

        // Check to see if StackLogicalID property is set
        internal bool IsSetStackLogicalID()
        {
            return this._stackLogicalID != null;
        }

        /// <summary>
        /// Gets and sets the property StackPhysicalID. 
        /// <para>
        /// The physical ID of the CloudFormation stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=86, Max=128)]
        public string StackPhysicalID
        {
            get { return this._stackPhysicalID; }
            set { this._stackPhysicalID = value; }
        }

        // Check to see if StackPhysicalID property is set
        internal bool IsSetStackPhysicalID()
        {
            return this._stackPhysicalID != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the deployed stack.
        /// </para>
        /// </summary>
        public NetworkMigrationDeployedStackStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccount. 
        /// <para>
        /// The target AWS account where the stack was deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string TargetAccount
        {
            get { return this._targetAccount; }
            set { this._targetAccount = value; }
        }

        // Check to see if TargetAccount property is set
        internal bool IsSetTargetAccount()
        {
            return this._targetAccount != null;
        }

    }
}