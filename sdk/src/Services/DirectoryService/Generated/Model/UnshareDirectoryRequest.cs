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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the UnshareDirectory operation.
    /// Stops the directory sharing between the directory owner and consumer accounts.
    /// </summary>
    public partial class UnshareDirectoryRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private UnshareTarget _unshareTarget;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the Managed Microsoft AD directory that you want to stop sharing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property UnshareTarget. 
        /// <para>
        /// Identifier for the directory consumer account with whom the directory has to be unshared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UnshareTarget UnshareTarget
        {
            get { return this._unshareTarget; }
            set { this._unshareTarget = value; }
        }

        // Check to see if UnshareTarget property is set
        internal bool IsSetUnshareTarget()
        {
            return this._unshareTarget != null;
        }

    }
}