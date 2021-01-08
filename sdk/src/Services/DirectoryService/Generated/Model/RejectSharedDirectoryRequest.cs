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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the RejectSharedDirectory operation.
    /// Rejects a directory sharing request that was sent from the directory owner account.
    /// </summary>
    public partial class RejectSharedDirectoryRequest : AmazonDirectoryServiceRequest
    {
        private string _sharedDirectoryId;

        /// <summary>
        /// Gets and sets the property SharedDirectoryId. 
        /// <para>
        /// Identifier of the shared directory in the directory consumer account. This identifier
        /// is different for each directory owner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SharedDirectoryId
        {
            get { return this._sharedDirectoryId; }
            set { this._sharedDirectoryId = value; }
        }

        // Check to see if SharedDirectoryId property is set
        internal bool IsSetSharedDirectoryId()
        {
            return this._sharedDirectoryId != null;
        }

    }
}