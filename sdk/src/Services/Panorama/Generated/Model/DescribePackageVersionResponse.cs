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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// This is the response object from the DescribePackageVersion operation.
    /// </summary>
    public partial class DescribePackageVersionResponse : AmazonWebServiceResponse
    {
        private bool? _isLatestPatch;
        private string _ownerAccount;
        private string _packageArn;
        private string _packageId;
        private string _packageName;
        private string _packageVersion;
        private string _patchVersion;
        private DateTime? _registeredTime;
        private PackageVersionStatus _status;
        private string _statusDescription;

        /// <summary>
        /// Gets and sets the property IsLatestPatch. 
        /// <para>
        /// Whether the version is the latest available.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsLatestPatch
        {
            get { return this._isLatestPatch; }
            set { this._isLatestPatch = value; }
        }

        // Check to see if IsLatestPatch property is set
        internal bool IsSetIsLatestPatch()
        {
            return this._isLatestPatch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The account ID of the version's owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PackageArn. 
        /// <para>
        /// The ARN of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PackageArn
        {
            get { return this._packageArn; }
            set { this._packageArn = value; }
        }

        // Check to see if PackageArn property is set
        internal bool IsSetPackageArn()
        {
            return this._packageArn != null;
        }

        /// <summary>
        /// Gets and sets the property PackageId. 
        /// <para>
        /// The version's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PackageId
        {
            get { return this._packageId; }
            set { this._packageId = value; }
        }

        // Check to see if PackageId property is set
        internal bool IsSetPackageId()
        {
            return this._packageId != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The version's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The version's version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PackageVersion
        {
            get { return this._packageVersion; }
            set { this._packageVersion = value; }
        }

        // Check to see if PackageVersion property is set
        internal bool IsSetPackageVersion()
        {
            return this._packageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PatchVersion. 
        /// <para>
        /// The version's patch version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PatchVersion
        {
            get { return this._patchVersion; }
            set { this._patchVersion = value; }
        }

        // Check to see if PatchVersion property is set
        internal bool IsSetPatchVersion()
        {
            return this._patchVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredTime. 
        /// <para>
        /// The version's registered time.
        /// </para>
        /// </summary>
        public DateTime? RegisteredTime
        {
            get { return this._registeredTime; }
            set { this._registeredTime = value; }
        }

        // Check to see if RegisteredTime property is set
        internal bool IsSetRegisteredTime()
        {
            return this._registeredTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The version's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageVersionStatus Status
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
        /// Gets and sets the property StatusDescription. 
        /// <para>
        /// The version's status description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StatusDescription
        {
            get { return this._statusDescription; }
            set { this._statusDescription = value; }
        }

        // Check to see if StatusDescription property is set
        internal bool IsSetStatusDescription()
        {
            return this._statusDescription != null;
        }

    }
}