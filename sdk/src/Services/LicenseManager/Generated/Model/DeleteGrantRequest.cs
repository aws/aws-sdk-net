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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteGrant operation.
    /// Deletes the specified grant.
    /// </summary>
    public partial class DeleteGrantRequest : AmazonLicenseManagerRequest
    {
        private string _grantArn;
        private string _statusReason;
        private string _version;

        /// <summary>
        /// Gets and sets the property GrantArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string GrantArn
        {
            get { return this._grantArn; }
            set { this._grantArn = value; }
        }

        // Check to see if GrantArn property is set
        internal bool IsSetGrantArn()
        {
            return this._grantArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The Status reason for the delete request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=400)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Current version of the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}