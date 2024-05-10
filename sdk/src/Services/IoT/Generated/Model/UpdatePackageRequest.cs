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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePackage operation.
    /// Updates the supported fields for a specific software package.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdatePackage</a>
    /// and <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetIndexingConfiguration</a>
    /// actions.
    /// </para>
    /// </summary>
    public partial class UpdatePackageRequest : AmazonIoTRequest
    {
        private string _clientToken;
        private string _defaultVersionName;
        private string _description;
        private string _packageName;
        private bool? _unsetDefaultVersion;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
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
        /// Gets and sets the property DefaultVersionName. 
        /// <para>
        /// The name of the default package version.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> You cannot name a <c>defaultVersion</c> and set <c>unsetDefaultVersion</c>
        /// equal to <c>true</c> at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DefaultVersionName
        {
            get { return this._defaultVersionName; }
            set { this._defaultVersionName = value; }
        }

        // Check to see if DefaultVersionName property is set
        internal bool IsSetDefaultVersionName()
        {
            return this._defaultVersionName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The package description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The name of the target software package.
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
        /// Gets and sets the property UnsetDefaultVersion. 
        /// <para>
        /// Indicates whether you want to remove the named default package version from the software
        /// package. Set as <c>true</c> to remove the default package version. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> You cannot name a <c>defaultVersion</c> and set <c>unsetDefaultVersion</c>
        /// equal to <c>true</c> at the same time.
        /// </para>
        /// </summary>
        public bool? UnsetDefaultVersion
        {
            get { return this._unsetDefaultVersion; }
            set { this._unsetDefaultVersion = value; }
        }

        // Check to see if UnsetDefaultVersion property is set
        internal bool IsSetUnsetDefaultVersion()
        {
            return this._unsetDefaultVersion.HasValue; 
        }

    }
}