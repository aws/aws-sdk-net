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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStudio operation.
    /// Updates an Amazon EMR Studio configuration, including attributes such as name, description,
    /// and subnets.
    /// </summary>
    public partial class UpdateStudioRequest : AmazonElasticMapReduceRequest
    {
        private string _defaultS3Location;
        private string _description;
        private string _encryptionKeyArn;
        private string _name;
        private string _studioId;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DefaultS3Location. 
        /// <para>
        /// The Amazon S3 location to back up Workspaces and notebook files for the Amazon EMR
        /// Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string DefaultS3Location
        {
            get { return this._defaultS3Location; }
            set { this._defaultS3Location = value; }
        }

        // Check to see if DefaultS3Location property is set
        internal bool IsSetDefaultS3Location()
        {
            return this._defaultS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description to assign to the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The KMS key identifier (ARN) used to encrypt Amazon EMR Studio workspace and notebook
        /// files when backed up to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The ID of the Amazon EMR Studio to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs to associate with the Amazon EMR Studio. The list can include
        /// new subnet IDs, but must also include all of the subnet IDs previously associated
        /// with the Studio. The list order does not matter. A Studio can have a maximum of 5
        /// subnets. The subnets must belong to the same VPC as the Studio. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}