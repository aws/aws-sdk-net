/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// This is the response object from the CopyBackupToRegion operation.
    /// </summary>
    public partial class CopyBackupToRegionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DestinationBackup. 
        /// <para>
        /// Information on the backup that will be copied to the destination region, including
        /// CreateTimestamp, SourceBackup, SourceCluster, and Source Region. CreateTimestamp of
        /// the destination backup will be the same as that of the source backup.
        /// </para>
        ///  
        /// <para>
        /// You will need to use the <c>sourceBackupID</c> returned in this operation to use the
        /// <a>DescribeBackups</a> operation on the backup that will be copied to the destination
        /// region.
        /// </para>
        /// </summary>
        public DestinationBackup DestinationBackup { get; set; }

        /// <summary>
        /// Checks to see if the DestinationBackup property is set.
        /// </summary>
        internal bool IsSetDestinationBackup() => this.DestinationBackup != null;
    }
}
