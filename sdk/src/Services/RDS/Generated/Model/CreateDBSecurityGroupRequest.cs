/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBSecurityGroup operation.
    /// Creates a new DB security group. DB security groups control access to a DB instance.
    /// 
    ///  <note> 
    /// <para>
    /// A DB security group controls access to EC2-Classic DB instances that are not in a
    /// VPC.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDBSecurityGroupRequest : AmazonRDSRequest
    {
        private string _dbSecurityGroupDescription;
        private string _dbSecurityGroupName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBSecurityGroupRequest() { }

        /// <summary>
        /// Instantiates CreateDBSecurityGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSecurityGroupName">The name for the DB security group. This value is stored as a lowercase string. Constraints: <ul> <li> Must be 1 to 255 letters, numbers, or hyphens. </li> <li> First character must be a letter </li> <li> Cannot end with a hyphen or contain two consecutive hyphens </li> <li> Must not be "Default" </li> </ul> Example: <code>mysecuritygroup</code> </param>
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
        /// Cannot end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not be "Default"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>mysecuritygroup</code> 
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}