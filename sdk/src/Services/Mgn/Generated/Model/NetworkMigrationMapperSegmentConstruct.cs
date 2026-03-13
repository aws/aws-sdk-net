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
    /// Represents a construct within a mapper segment. A construct is an individual infrastructure
    /// component such as a VPC, subnet, security group, route table, or other network resource
    /// that is part of the network migration.
    /// </summary>
    public partial class NetworkMigrationMapperSegmentConstruct
    {
        private string _constructid;
        private string _constructType;
        private DateTime? _createdAt;
        private string _description;
        private string _logicalid;
        private string _name;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ConstructID. 
        /// <para>
        /// The unique identifier of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ConstructID
        {
            get { return this._constructid; }
            set { this._constructid = value; }
        }

        // Check to see if ConstructID property is set
        internal bool IsSetConstructID()
        {
            return this._constructid != null;
        }

        /// <summary>
        /// Gets and sets the property ConstructType. 
        /// <para>
        /// The type of the construct, such as VPC, subnet, security group, or route table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=24)]
        public string ConstructType
        {
            get { return this._constructType; }
            set { this._constructType = value; }
        }

        // Check to see if ConstructType property is set
        internal bool IsSetConstructType()
        {
            return this._constructType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the construct was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
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
        /// Gets and sets the property LogicalID. 
        /// <para>
        /// The logical identifier for the construct in the infrastructure code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LogicalID
        {
            get { return this._logicalid; }
            set { this._logicalid = value; }
        }

        // Check to see if LogicalID property is set
        internal bool IsSetLogicalID()
        {
            return this._logicalid != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties and configuration of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the construct was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}