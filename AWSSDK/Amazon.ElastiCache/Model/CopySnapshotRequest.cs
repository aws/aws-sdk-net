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
    /// Container for the parameters to the CopySnapshot operation.
    /// <para>The <i>CopySnapshot</i> operation makes a copy of an existing snapshot.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CopySnapshot"/>
    public class CopySnapshotRequest : AmazonWebServiceRequest
    {
        private string sourceSnapshotName;
        private string targetSnapshotName;

        /// <summary>
        /// The name of an existing snapshot from which to copy.
        ///  
        /// </summary>
        public string SourceSnapshotName
        {
            get { return this.sourceSnapshotName; }
            set { this.sourceSnapshotName = value; }
        }

        /// <summary>
        /// Sets the SourceSnapshotName property
        /// </summary>
        /// <param name="sourceSnapshotName">The value to set for the SourceSnapshotName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopySnapshotRequest WithSourceSnapshotName(string sourceSnapshotName)
        {
            this.sourceSnapshotName = sourceSnapshotName;
            return this;
        }
            

        // Check to see if SourceSnapshotName property is set
        internal bool IsSetSourceSnapshotName()
        {
            return this.sourceSnapshotName != null;
        }

        /// <summary>
        /// A name for the copied snapshot.
        ///  
        /// </summary>
        public string TargetSnapshotName
        {
            get { return this.targetSnapshotName; }
            set { this.targetSnapshotName = value; }
        }

        /// <summary>
        /// Sets the TargetSnapshotName property
        /// </summary>
        /// <param name="targetSnapshotName">The value to set for the TargetSnapshotName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopySnapshotRequest WithTargetSnapshotName(string targetSnapshotName)
        {
            this.targetSnapshotName = targetSnapshotName;
            return this;
        }
            

        // Check to see if TargetSnapshotName property is set
        internal bool IsSetTargetSnapshotName()
        {
            return this.targetSnapshotName != null;
        }
    }
}
    
