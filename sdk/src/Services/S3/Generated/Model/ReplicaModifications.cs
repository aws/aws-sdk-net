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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// A filter that you can specify for selection for modifications on replicas. Amazon
    /// S3 doesn't replicate replica modifications by default. In the latest version of replication
    /// configuration (when <c>Filter</c> is specified), you can specify this element and
    /// set the status to <c>Enabled</c> to replicate modifications on replicas. 
    /// 
    ///  <note> 
    /// <para>
    ///  If you don't specify the <c>Filter</c> element, Amazon S3 assumes that the replication
    /// configuration is the earlier version, V1. In the earlier version, this element is
    /// not allowed.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ReplicaModifications
    {
        private ReplicaModificationsStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether Amazon S3 replicates modifications on replicas.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicaModificationsStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}