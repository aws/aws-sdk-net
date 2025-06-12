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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// This is the response object from the GetTableAutoScalingSettings operation.
    /// </summary>
    public partial class GetTableAutoScalingSettingsResponse : AmazonWebServiceResponse
    {
        private AutoScalingSpecification _autoScalingSpecification;
        private string _keyspaceName;
        private List<ReplicaAutoScalingSpecification> _replicaSpecifications = AWSConfigs.InitializeCollections ? new List<ReplicaAutoScalingSpecification>() : null;
        private string _resourceArn;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property AutoScalingSpecification. 
        /// <para>
        /// The auto scaling settings of the table.
        /// </para>
        /// </summary>
        public AutoScalingSpecification AutoScalingSpecification
        {
            get { return this._autoScalingSpecification; }
            set { this._autoScalingSpecification = value; }
        }

        // Check to see if AutoScalingSpecification property is set
        internal bool IsSetAutoScalingSpecification()
        {
            return this._autoScalingSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaSpecifications. 
        /// <para>
        /// The Amazon Web Services Region specific settings of a multi-Region table. Returns
        /// the settings for all Regions the table is replicated in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0)]
        public List<ReplicaAutoScalingSpecification> ReplicaSpecifications
        {
            get { return this._replicaSpecifications; }
            set { this._replicaSpecifications = value; }
        }

        // Check to see if ReplicaSpecifications property is set
        internal bool IsSetReplicaSpecifications()
        {
            return this._replicaSpecifications != null && (this._replicaSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1000)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}