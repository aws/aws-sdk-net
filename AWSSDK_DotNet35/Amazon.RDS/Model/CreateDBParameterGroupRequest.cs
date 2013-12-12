/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateDBParameterGroup operation.
    /// <para> Creates a new DB parameter group. </para> <para> A DB parameter group is initially created with the default parameters for the
    /// database engine used by the DB instance. To provide custom values for any of the parameters, you must modify the group after creating it
    /// using <i>ModifyDBParameterGroup</i> . Once you've created a DB parameter group, you need to associate it with your DB instance using
    /// <i>ModifyDBInstance</i> . When you associate a new DB parameter group with a running DB instance, you need to reboot the DB Instance for the
    /// new DB parameter group and associated settings to take effect. </para>
    /// </summary>
    public partial class CreateDBParameterGroupRequest : AmazonRDSRequest
    {
        private string dBParameterGroupName;
        private string dBParameterGroupFamily;
        private string description;
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The name of the DB parameter group. Constraints: <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be a
        /// letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul> <note>This value is stored as a lower-case
        /// string.</note>
        ///  
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this.dBParameterGroupName; }
            set { this.dBParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this.dBParameterGroupName != null;
        }

        /// <summary>
        /// The DB parameter group family name. A DB parameter group can be associated with one and only one DB parameter group family, and can be
        /// applied only to a DB instance running a database engine and engine version compatible with that DB parameter group family.
        ///  
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this.dBParameterGroupFamily; }
            set { this.dBParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this.dBParameterGroupFamily != null;
        }

        /// <summary>
        /// The description for the DB parameter group.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// A list of tags.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

    }
}
    
