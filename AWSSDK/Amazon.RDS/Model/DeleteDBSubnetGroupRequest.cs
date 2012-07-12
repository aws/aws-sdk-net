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
    /// Container for the parameters to the DeleteDBSubnetGroup operation.
    /// <para> Deletes a DB subnet group. </para> <para><b>NOTE:</b>The specified database subnet group must not be associated with any DB
    /// instances.</para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSubnetGroup"/>
    public class DeleteDBSubnetGroupRequest : AmazonWebServiceRequest
    {
        private string dBSubnetGroupName;

        /// <summary>
        /// The name of the database subnet group to delete. <note>You cannot delete the default subnet group.</note> Constraints: <ul> <li>Must be 1 to
        /// 255 alphanumeric characters</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens</li> </ul>
        ///  
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this.dBSubnetGroupName; }
            set { this.dBSubnetGroupName = value; }
        }

        /// <summary>
        /// Sets the DBSubnetGroupName property
        /// </summary>
        /// <param name="dBSubnetGroupName">The value to set for the DBSubnetGroupName property </param>
        /// <returns>this instance</returns>
        public DeleteDBSubnetGroupRequest WithDBSubnetGroupName(string dBSubnetGroupName)
        {
            this.dBSubnetGroupName = dBSubnetGroupName;
            return this;
        }
            

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this.dBSubnetGroupName != null;       
        }
    }
}
    
