/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateDBSecurityGroup operation.
    /// <para> Creates a new DB Security Group. DB Security Groups control access to a DB Instance. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBSecurityGroup"/>
    public class CreateDBSecurityGroupRequest : AmazonWebServiceRequest
    {
        private string dBSecurityGroupName;
        private string dBSecurityGroupDescription;
        private string eC2VpcId;

        /// <summary>
        /// The name for the DB Security Group. This value is stored as a lowercase string. Constraints: Must contain no more than 255 alphanumeric
        /// characters or hyphens. Must not be "Default". Example: <c>mysecuritygroup</c>
        ///  
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this.dBSecurityGroupName; }
            set { this.dBSecurityGroupName = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupName property
        /// </summary>
        /// <param name="dBSecurityGroupName">The value to set for the DBSecurityGroupName property </param>
        /// <returns>this instance</returns>
        public CreateDBSecurityGroupRequest WithDBSecurityGroupName(string dBSecurityGroupName)
        {
            this.dBSecurityGroupName = dBSecurityGroupName;
            return this;
        }
            

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this.dBSecurityGroupName != null;       
        }

        /// <summary>
        /// The description for the DB Security Group.
        ///  
        /// </summary>
        public string DBSecurityGroupDescription
        {
            get { return this.dBSecurityGroupDescription; }
            set { this.dBSecurityGroupDescription = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupDescription property
        /// </summary>
        /// <param name="dBSecurityGroupDescription">The value to set for the DBSecurityGroupDescription property </param>
        /// <returns>this instance</returns>
        public CreateDBSecurityGroupRequest WithDBSecurityGroupDescription(string dBSecurityGroupDescription)
        {
            this.dBSecurityGroupDescription = dBSecurityGroupDescription;
            return this;
        }
            

        // Check to see if DBSecurityGroupDescription property is set
        internal bool IsSetDBSecurityGroupDescription()
        {
            return this.dBSecurityGroupDescription != null;       
        }

        /// <summary>
        /// The Id of VPC. Indicates which VPC this DB Security Group should belong to. Must be specified to create a DB Security Group for a VPC; may
        /// not be specified otherwise.
        ///  
        /// </summary>
        public string EC2VpcId
        {
            get { return this.eC2VpcId; }
            set { this.eC2VpcId = value; }
        }

        /// <summary>
        /// Sets the EC2VpcId property
        /// </summary>
        /// <param name="eC2VpcId">The value to set for the EC2VpcId property </param>
        /// <returns>this instance</returns>
        public CreateDBSecurityGroupRequest WithEC2VpcId(string eC2VpcId)
        {
            this.eC2VpcId = eC2VpcId;
            return this;
        }
            

        // Check to see if EC2VpcId property is set
        internal bool IsSetEC2VpcId()
        {
            return this.eC2VpcId != null;       
        }
    }
}
    
