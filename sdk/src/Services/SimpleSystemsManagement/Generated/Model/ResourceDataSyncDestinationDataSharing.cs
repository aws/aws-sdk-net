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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Synchronize Amazon Web Services Systems Manager Inventory data from multiple Amazon
    /// Web Services accounts defined in Organizations to a centralized Amazon S3 bucket.
    /// Data is synchronized to individual key prefixes in the central bucket. Each key prefix
    /// represents a different Amazon Web Services account ID.
    /// </summary>
    public partial class ResourceDataSyncDestinationDataSharing
    {
        private string _destinationDataSharingType;

        /// <summary>
        /// Gets and sets the property DestinationDataSharingType. 
        /// <para>
        /// The sharing data type. Only <c>Organization</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DestinationDataSharingType
        {
            get { return this._destinationDataSharingType; }
            set { this._destinationDataSharingType = value; }
        }

        // Check to see if DestinationDataSharingType property is set
        internal bool IsSetDestinationDataSharingType()
        {
            return this._destinationDataSharingType != null;
        }

    }
}