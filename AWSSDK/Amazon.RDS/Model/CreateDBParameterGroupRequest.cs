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
    /// <para> Creates a new DB Parameter Group. </para> <para> A DB Parameter Group is initially created with the default parameters for the
    /// database engine used by the DB Instance. To provide custom values for any of the parameters, you must modify the group after creating it
    /// using <i>ModifyDBParameterGroup</i> . Once you've created a DB Parameter Group, you need to associate it with your DB Instance using
    /// <i>ModifyDBInstance</i> . When you associate a new DB Parameter Group with a running DB Instance, you need to reboot the DB Instance for the
    /// new DB Parameter Group and associated settings to take effect. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBParameterGroup"/>
    public class CreateDBParameterGroupRequest : AmazonWebServiceRequest
    {
        private string dBParameterGroupName;
        private string dBParameterGroupFamily;
        private string description;

        /// <summary>
        /// The name of the DB Parameter Group. Constraints: <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be a
        /// letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul> <note>This value is stored as a lower-case
        /// string.</note>
        ///  
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this.dBParameterGroupName; }
            set { this.dBParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="dBParameterGroupName">The value to set for the DBParameterGroupName property </param>
        /// <returns>this instance</returns>
        public CreateDBParameterGroupRequest WithDBParameterGroupName(string dBParameterGroupName)
        {
            this.dBParameterGroupName = dBParameterGroupName;
            return this;
        }
            

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this.dBParameterGroupName != null;
        }

        /// <summary>
        /// The DB Parameter Group Family name. A DB Parameter Group can be associated with one and only one DB Parameter Group Family, and can be
        /// applied only to a DB Instance running a database engine and engine version compatible with that DB Parameter Group Family.
        ///  
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this.dBParameterGroupFamily; }
            set { this.dBParameterGroupFamily = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupFamily property
        /// </summary>
        /// <param name="dBParameterGroupFamily">The value to set for the DBParameterGroupFamily property </param>
        /// <returns>this instance</returns>
        public CreateDBParameterGroupRequest WithDBParameterGroupFamily(string dBParameterGroupFamily)
        {
            this.dBParameterGroupFamily = dBParameterGroupFamily;
            return this;
        }
            

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this.dBParameterGroupFamily != null;
        }

        /// <summary>
        /// The description for the DB Parameter Group.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public CreateDBParameterGroupRequest WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
    
