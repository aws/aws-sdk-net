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
    /// Container for the parameters to the UpdateSMBFileShareVisibility operation.
    /// Controls whether the shares on an S3 File Gateway are visible in a net view or browse
    /// list. The operation is only supported for S3 File Gateways.
    /// </summary>
    public partial class UpdateSMBFileShareVisibilityRequest : AmazonStorageGatewayRequest
    {
        private bool? _fileSharesVisible;
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property FileSharesVisible. 
        /// <para>
        /// The shares on this gateway appear when listing shares.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? FileSharesVisible
        {
            get { return this._fileSharesVisible; }
            set { this._fileSharesVisible = value; }
        }

        // Check to see if FileSharesVisible property is set
        internal bool IsSetFileSharesVisible()
        {
            return this._fileSharesVisible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

    }
}