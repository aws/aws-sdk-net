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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the GetRestoreJobMetadata operation.
    /// </summary>
    public partial class GetRestoreJobMetadataResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _restoreJobId;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// This contains the metadata of the specified backup job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestoreJobId. 
        /// <para>
        /// This is a unique identifier of a restore job within Backup.
        /// </para>
        /// </summary>
        public string RestoreJobId
        {
            get { return this._restoreJobId; }
            set { this._restoreJobId = value; }
        }

        // Check to see if RestoreJobId property is set
        internal bool IsSetRestoreJobId()
        {
            return this._restoreJobId != null;
        }

    }
}