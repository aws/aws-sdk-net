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
    /// This is the response object from the CreateSnapshotCopyConfiguration operation.
    /// </summary>
    public partial class CreateSnapshotCopyConfigurationResponse : AmazonWebServiceResponse
    {
        private SnapshotCopyConfiguration _snapshotCopyConfiguration;

        /// <summary>
        /// Gets and sets the property SnapshotCopyConfiguration. 
        /// <para>
        /// The snapshot copy configuration object that is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotCopyConfiguration SnapshotCopyConfiguration
        {
            get { return this._snapshotCopyConfiguration; }
            set { this._snapshotCopyConfiguration = value; }
        }

        // Check to see if SnapshotCopyConfiguration property is set
        internal bool IsSetSnapshotCopyConfiguration()
        {
            return this._snapshotCopyConfiguration != null;
        }

    }
}