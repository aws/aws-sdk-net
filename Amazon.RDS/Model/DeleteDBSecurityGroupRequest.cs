/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DeleteDBSecurityGroup operation.
    /// <para> This API deletes a database security group. Database security
    /// group must not be associated with any RDS Instances. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSecurityGroup"/>
    public class DeleteDBSecurityGroupRequest : AmazonWebServiceRequest
    {
        private string dBSecurityGroupName;

        /// <summary>
        /// The name of the database security group to delete.
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
        public DeleteDBSecurityGroupRequest WithDBSecurityGroupName(string dBSecurityGroupName)
        {
            this.dBSecurityGroupName = dBSecurityGroupName;
            return this;
        }
            
        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this.dBSecurityGroupName != null;        
        }
    }
}
    
