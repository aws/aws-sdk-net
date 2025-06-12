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
    /// Container for the parameters to the CreateDBSecurityGroup operation.
    /// Creates a new DB security group. DB security groups control access to a DB instance.
    /// 
    ///  
    /// <para>
    /// A DB security group controls access to EC2-Classic DB instances that are not in a
    /// VPC.
    /// </para>
    ///  <note> 
    /// <para>
    /// EC2-Classic was retired on August 15, 2022. If you haven't migrated from EC2-Classic
    /// to a VPC, we recommend that you migrate as soon as possible. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
    /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>, the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
    /// Networking is Retiring – Here’s How to Prepare</a>, and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.Non-VPC2VPC.html">Moving
    /// a DB instance not in a VPC into a VPC</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDBSecurityGroupRequest : AmazonRDSRequest
    {
        private string _dbSecurityGroupDescription;
        private string _dbSecurityGroupName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBSecurityGroupRequest() { }

        /// <summary>
        /// Instantiates CreateDBSecurityGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSecurityGroupName">The name for the DB security group. This value is stored as a lowercase string. Constraints: <ul> <li> Must be 1 to 255 letters, numbers, or hyphens. </li> <li> First character must be a letter </li> <li> Can't end with a hyphen or contain two consecutive hyphens </li> <li> Must not be "Default" </li> </ul> Example: <c>mysecuritygroup</c> </param>
        /// <param name="dbSecurityGroupDescription">The description for the DB security group.</param>
        public CreateDBSecurityGroupRequest(string dbSecurityGroupName, string dbSecurityGroupDescription)
        {
            _dbSecurityGroupName = dbSecurityGroupName;
            _dbSecurityGroupDescription = dbSecurityGroupDescription;
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroupDescription. 
        /// <para>
        /// The description for the DB security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBSecurityGroupDescription
        {
            get { return this._dbSecurityGroupDescription; }
            set { this._dbSecurityGroupDescription = value; }
        }

        // Check to see if DBSecurityGroupDescription property is set
        internal bool IsSetDBSecurityGroupDescription()
        {
            return this._dbSecurityGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroupName. 
        /// <para>
        /// The name for the DB security group. This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not be "Default"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mysecuritygroup</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBSecurityGroupName
        {
            get { return this._dbSecurityGroupName; }
            set { this._dbSecurityGroupName = value; }
        }

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this._dbSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the DB security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}