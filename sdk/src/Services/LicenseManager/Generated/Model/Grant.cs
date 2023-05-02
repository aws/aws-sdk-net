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
    /// Describes a grant.
    /// </summary>
    public partial class Grant
    {
        private string _grantArn;
        private List<string> _grantedOperations = new List<string>();
        private string _granteePrincipalArn;
        private string _grantName;
        private GrantStatus _grantStatus;
        private string _homeRegion;
        private string _licenseArn;
        private Options _options;
        private string _parentArn;
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
        /// Gets and sets the property GrantedOperations. 
        /// <para>
        /// Granted operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=7)]
        public List<string> GrantedOperations
        {
            get { return this._grantedOperations; }
            set { this._grantedOperations = value; }
        }

        // Check to see if GrantedOperations property is set
        internal bool IsSetGrantedOperations()
        {
            return this._grantedOperations != null && this._grantedOperations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GranteePrincipalArn. 
        /// <para>
        /// The grantee principal ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string GranteePrincipalArn
        {
            get { return this._granteePrincipalArn; }
            set { this._granteePrincipalArn = value; }
        }

        // Check to see if GranteePrincipalArn property is set
        internal bool IsSetGranteePrincipalArn()
        {
            return this._granteePrincipalArn != null;
        }

        /// <summary>
        /// Gets and sets the property GrantName. 
        /// <para>
        /// Grant name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property GrantStatus. 
        /// <para>
        /// Grant status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GrantStatus GrantStatus
        {
            get { return this._grantStatus; }
            set { this._grantStatus = value; }
        }

        // Check to see if GrantStatus property is set
        internal bool IsSetGrantStatus()
        {
            return this._grantStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// Home Region of the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// License ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string LicenseArn
        {
            get { return this._licenseArn; }
            set { this._licenseArn = value; }
        }

        // Check to see if LicenseArn property is set
        internal bool IsSetLicenseArn()
        {
            return this._licenseArn != null;
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
        /// Gets and sets the property ParentArn. 
        /// <para>
        /// Parent ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string ParentArn
        {
            get { return this._parentArn; }
            set { this._parentArn = value; }
        }

        // Check to see if ParentArn property is set
        internal bool IsSetParentArn()
        {
            return this._parentArn != null;
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Grant version.
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