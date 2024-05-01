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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTapeArchive operation.
    /// Deletes the specified virtual tape from the virtual tape shelf (VTS). This operation
    /// is only supported in the tape gateway type.
    /// </summary>
    public partial class DeleteTapeArchiveRequest : AmazonStorageGatewayRequest
    {
        private bool? _bypassGovernanceRetention;
        private string _tapeARN;

        /// <summary>
        /// Gets and sets the property BypassGovernanceRetention. 
        /// <para>
        /// Set to <c>TRUE</c> to delete an archived tape that belongs to a custom pool with tape
        /// retention lock. Only archived tapes with tape retention lock set to <c>governance</c>
        /// can be deleted. Archived tapes with tape retention lock set to <c>compliance</c> can't
        /// be deleted.
        /// </para>
        /// </summary>
        public bool? BypassGovernanceRetention
        {
            get { return this._bypassGovernanceRetention; }
            set { this._bypassGovernanceRetention = value; }
        }

        // Check to see if BypassGovernanceRetention property is set
        internal bool IsSetBypassGovernanceRetention()
        {
            return this._bypassGovernanceRetention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the virtual tape to delete from the virtual tape
        /// shelf (VTS).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string TapeARN
        {
            get { return this._tapeARN; }
            set { this._tapeARN = value; }
        }

        // Check to see if TapeARN property is set
        internal bool IsSetTapeARN()
        {
            return this._tapeARN != null;
        }

    }
}