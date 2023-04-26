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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGrantVersion operation.
    /// Creates a new version of the specified grant. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
    /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
    /// </summary>
    public partial class CreateGrantVersionRequest : AmazonLicenseManagerRequest
    {
        private List<string> _allowedOperations = new List<string>();
        private string _clientToken;
        private string _grantArn;
        private string _grantName;
        private Options _options;
        private string _sourceVersion;
        private GrantStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AllowedOperations. 
        /// <para>
        /// Allowed operations for the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public List<string> AllowedOperations
        {
            get { return this._allowedOperations; }
            set { this._allowedOperations = value; }
        }

        // Check to see if AllowedOperations property is set
        internal bool IsSetAllowedOperations()
        {
            return this._allowedOperations != null && this._allowedOperations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        /// Gets and sets the property GrantName. 
        /// <para>
        /// Grant name.
        /// </para>
        /// </summary>
        public string GrantName
        {
            get { return this._grantName; }
            set { this._grantName = value; }
        }

        // Check to see if GrantName property is set
        internal bool IsSetGrantName()
        {
            return this._grantName != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options specified for the grant.
        /// </para>
        /// </summary>
        public Options Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// Current version of the grant.
        /// </para>
        /// </summary>
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Grant status.
        /// </para>
        /// </summary>
        public GrantStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Grant status reason.
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

    }
}