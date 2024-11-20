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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePackage operation.
    /// Creates a package for use with Amazon OpenSearch Service domains. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
    /// packages for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class CreatePackageRequest : AmazonOpenSearchServiceRequest
    {
        private string _engineVersion;
        private PackageConfiguration _packageConfiguration;
        private string _packageDescription;
        private PackageEncryptionOptions _packageEncryptionOptions;
        private string _packageName;
        private PackageSource _packageSource;
        private PackageType _packageType;
        private PackageVendingOptions _packageVendingOptions;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the Amazon OpenSearch Service engine for which is compatible with the
        /// package. This can only be specified for package type <c>ZIP-PLUGIN</c> 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PackageConfiguration. 
        /// <para>
        ///  The configuration parameters for the package being created.
        /// </para>
        /// </summary>
        public PackageConfiguration PackageConfiguration
        {
            get { return this._packageConfiguration; }
            set { this._packageConfiguration = value; }
        }

        // Check to see if PackageConfiguration property is set
        internal bool IsSetPackageConfiguration()
        {
            return this._packageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PackageDescription. 
        /// <para>
        /// Description of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string PackageDescription
        {
            get { return this._packageDescription; }
            set { this._packageDescription = value; }
        }

        // Check to see if PackageDescription property is set
        internal bool IsSetPackageDescription()
        {
            return this._packageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PackageEncryptionOptions. 
        /// <para>
        /// The encryption parameters for the package being created.
        /// </para>
        /// </summary>
        public PackageEncryptionOptions PackageEncryptionOptions
        {
            get { return this._packageEncryptionOptions; }
            set { this._packageEncryptionOptions = value; }
        }

        // Check to see if PackageEncryptionOptions property is set
        internal bool IsSetPackageEncryptionOptions()
        {
            return this._packageEncryptionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// Unique name for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
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
        /// Gets and sets the property PackageSource. 
        /// <para>
        /// The Amazon S3 location from which to import the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageSource PackageSource
        {
            get { return this._packageSource; }
            set { this._packageSource = value; }
        }

        // Check to see if PackageSource property is set
        internal bool IsSetPackageSource()
        {
            return this._packageSource != null;
        }

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The type of package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageType PackageType
        {
            get { return this._packageType; }
            set { this._packageType = value; }
        }

        // Check to see if PackageType property is set
        internal bool IsSetPackageType()
        {
            return this._packageType != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVendingOptions. 
        /// <para>
        ///  The vending options for the package being created. They determine if the package
        /// can be vended to other users.
        /// </para>
        /// </summary>
        public PackageVendingOptions PackageVendingOptions
        {
            get { return this._packageVendingOptions; }
            set { this._packageVendingOptions = value; }
        }

        // Check to see if PackageVendingOptions property is set
        internal bool IsSetPackageVendingOptions()
        {
            return this._packageVendingOptions != null;
        }

    }
}