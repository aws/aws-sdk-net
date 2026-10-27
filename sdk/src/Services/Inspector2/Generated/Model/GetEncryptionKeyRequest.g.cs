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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the GetEncryptionKey operation. Gets an encryption
    /// key.
    /// </summary>
    public partial class GetEncryptionKeyRequest : AmazonInspector2Request
    {
        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type the key encrypts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// The scan type the key encrypts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScanType ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;
    }
}
