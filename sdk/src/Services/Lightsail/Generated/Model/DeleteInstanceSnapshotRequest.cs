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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInstanceSnapshot operation.
    /// Deletes a specific snapshot of a virtual private server (or <i>instance</i>).
    /// 
    ///  
    /// <para>
    /// The <code>delete instance snapshot</code> operation supports tag-based access control
    /// via resource tags applied to the resource identified by <code>instance snapshot name</code>.
    /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class DeleteInstanceSnapshotRequest : AmazonLightsailRequest
    {
        private string _instanceSnapshotName;

        /// <summary>
        /// Gets and sets the property InstanceSnapshotName. 
        /// <para>
        /// The name of the snapshot to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceSnapshotName
        {
            get { return this._instanceSnapshotName; }
            set { this._instanceSnapshotName = value; }
        }

        // Check to see if InstanceSnapshotName property is set
        internal bool IsSetInstanceSnapshotName()
        {
            return this._instanceSnapshotName != null;
        }

    }
}