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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSnapshot operation.
    /// <para>The <i>DeleteSnapshot</i> operation deletes an existing snapshot. When you receive a successful response from this operation,
    /// ElastiCache immediately begins deleting the snapshot; you cannot cancel or revert this operation.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteSnapshot"/>
    public class DeleteSnapshotRequest : AmazonWebServiceRequest
    {
        private string snapshotName;

        /// <summary>
        /// The name of the snapshot to be deleted.
        ///  
        /// </summary>
        public string SnapshotName
        {
            get { return this.snapshotName; }
            set { this.snapshotName = value; }
        }

        /// <summary>
        /// Sets the SnapshotName property
        /// </summary>
        /// <param name="snapshotName">The value to set for the SnapshotName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteSnapshotRequest WithSnapshotName(string snapshotName)
        {
            this.snapshotName = snapshotName;
            return this;
        }
            

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this.snapshotName != null;
        }
    }
}
    
