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
    /// Container for the parameters to the DeleteDBSnapshot operation.
    /// <para> This API is used to delete a DBSnapshot. The DBSnapshot must be
    /// in the "available" state to be deleted. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSnapshot"/>
    public class DeleteDBSnapshotRequest : AmazonWebServiceRequest
    {
        private string dBSnapshotIdentifier;

        /// <summary>
        /// The DBSnapshot identifier.
        ///  
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this.dBSnapshotIdentifier; }
            set { this.dBSnapshotIdentifier = value; }
        }

        /// <summary>
        /// Sets the DBSnapshotIdentifier property
        /// </summary>
        /// <param name="dBSnapshotIdentifier">The value to set for the DBSnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        public DeleteDBSnapshotRequest WithDBSnapshotIdentifier(string dBSnapshotIdentifier)
        {
            this.dBSnapshotIdentifier = dBSnapshotIdentifier;
            return this;
        }
            
        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this.dBSnapshotIdentifier != null;       
        }
    }
}
    
