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
    /// Container for the parameters to the DeleteDBSecurityGroup operation.
    /// Deletes a DB security group.
    /// 
    ///  <note> 
    /// <para>
    /// The specified DB security group must not be associated with any DB instances.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDBSecurityGroupRequest : AmazonRDSRequest
    {
        private string _dbSecurityGroupName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDBSecurityGroupRequest() { }

        /// <summary>
        /// Instantiates DeleteDBSecurityGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSecurityGroupName">The name of the DB security group to delete. <note> You can't delete the default DB security group. </note> Constraints: <ul> <li> Must be 1 to 255 letters, numbers, or hyphens. </li> <li> First character must be a letter </li> <li> Can't end with a hyphen or contain two consecutive hyphens </li> <li> Must not be "Default" </li> </ul></param>
        public DeleteDBSecurityGroupRequest(string dbSecurityGroupName)
        {
            _dbSecurityGroupName = dbSecurityGroupName;
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroupName. 
        /// <para>
        /// The name of the DB security group to delete.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't delete the default DB security group.
        /// </para>
        ///  </note> 
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

    }
}