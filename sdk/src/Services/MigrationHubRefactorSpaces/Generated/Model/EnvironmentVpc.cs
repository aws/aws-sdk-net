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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
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
namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Provides summary information for the <c>EnvironmentVpc</c> resource as a response
    /// to <c>ListEnvironmentVpc</c>.
    /// </summary>
    public partial class EnvironmentVpc
    {
        private string _accountId;
        private List<string> _cidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdTime;
        private string _environmentId;
        private DateTime? _lastUpdatedTime;
        private string _vpcId;
        private string _vpcName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the virtual private cloud (VPC) owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CidrBlocks. 
        /// <para>
        /// The list of Amazon Virtual Private Cloud (Amazon VPC) CIDR blocks. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> CidrBlocks
        {
            get { return this._cidrBlocks; }
            set { this._cidrBlocks = value; }
        }

        // Check to see if CidrBlocks property is set
        internal bool IsSetCidrBlocks()
        {
            return this._cidrBlocks != null && (this._cidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that indicates when the VPC is first added to the environment. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique identifier of the environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=14, Max=14)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// A timestamp that indicates when the VPC was last updated by the environment. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=21)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcName. 
        /// <para>
        /// The name of the VPC at the time it is added to the environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string VpcName
        {
            get { return this._vpcName; }
            set { this._vpcName = value; }
        }

        // Check to see if VpcName property is set
        internal bool IsSetVpcName()
        {
            return this._vpcName != null;
        }

    }
}