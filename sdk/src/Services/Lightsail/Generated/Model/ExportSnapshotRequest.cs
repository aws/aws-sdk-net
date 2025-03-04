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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the ExportSnapshot operation.
    /// Exports an Amazon Lightsail instance or block storage disk snapshot to Amazon Elastic
    /// Compute Cloud (Amazon EC2). This operation results in an export snapshot record that
    /// can be used with the <c>create cloud formation stack</c> operation to create new Amazon
    /// EC2 instances.
    /// 
    ///  
    /// <para>
    /// Exported instance snapshots appear in Amazon EC2 as Amazon Machine Images (AMIs),
    /// and the instance system disk appears as an Amazon Elastic Block Store (Amazon EBS)
    /// volume. Exported disk snapshots appear in Amazon EC2 as Amazon EBS volumes. Snapshots
    /// are exported to the same Amazon Web Services Region in Amazon EC2 as the source Lightsail
    /// snapshot.
    /// </para>
    ///   
    /// <para>
    /// The <c>export snapshot</c> operation supports tag-based access control via resource
    /// tags applied to the resource identified by <c>source snapshot name</c>. For more information,
    /// see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Use the <c>get instance snapshots</c> or <c>get disk snapshots</c> operations to get
    /// a list of snapshots that you can export to Amazon EC2.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ExportSnapshotRequest : AmazonLightsailRequest
    {
        private string _sourceSnapshotName;

        /// <summary>
        /// Gets and sets the property SourceSnapshotName. 
        /// <para>
        /// The name of the instance or disk snapshot to be exported to Amazon EC2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceSnapshotName
        {
            get { return this._sourceSnapshotName; }
            set { this._sourceSnapshotName = value; }
        }

        // Check to see if SourceSnapshotName property is set
        internal bool IsSetSourceSnapshotName()
        {
            return this._sourceSnapshotName != null;
        }

    }
}