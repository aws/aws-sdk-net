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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBSubnetGroup operation.
    /// Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet
    /// in at least two AZs in the Amazon Web Services Region.
    /// </summary>
    public partial class ModifyDBSubnetGroupRequest : AmazonRDSRequest
    {
        private string _dbSubnetGroupDescription;
        private string _dbSubnetGroupName;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupDescription. 
        /// <para>
        /// The description for the DB subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroupDescription
        {
            get { return this._dbSubnetGroupDescription; }
            set { this._dbSubnetGroupDescription = value; }
        }

        // Check to see if DBSubnetGroupDescription property is set
        internal bool IsSetDBSubnetGroupDescription()
        {
            return this._dbSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The name for the DB subnet group. This value is stored as a lowercase string. You
        /// can't modify the default subnet group.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must match the name of an existing DBSubnetGroup. Must not be default.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>mydbsubnetgroup</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The EC2 subnet IDs for the DB subnet group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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