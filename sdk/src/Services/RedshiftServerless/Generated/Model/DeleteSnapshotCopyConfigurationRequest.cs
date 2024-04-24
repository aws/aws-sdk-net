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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSnapshotCopyConfiguration operation.
    /// Deletes a snapshot copy configuration
    /// </summary>
    public partial class DeleteSnapshotCopyConfigurationRequest : AmazonRedshiftServerlessRequest
    {
        private string _snapshotCopyConfigurationId;

        /// <summary>
        /// Gets and sets the property SnapshotCopyConfigurationId. 
        /// <para>
        /// The ID of the snapshot copy configuration to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotCopyConfigurationId
        {
            get { return this._snapshotCopyConfigurationId; }
            set { this._snapshotCopyConfigurationId = value; }
        }

        // Check to see if SnapshotCopyConfigurationId property is set
        internal bool IsSetSnapshotCopyConfigurationId()
        {
            return this._snapshotCopyConfigurationId != null;
        }

    }
}