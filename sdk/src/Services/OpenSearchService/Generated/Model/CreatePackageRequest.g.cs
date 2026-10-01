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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePackage operation. Creates a package for
    /// use with Amazon OpenSearch Service domains. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
    /// packages for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class CreatePackageRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the Amazon OpenSearch Service engine for which is compatible with the
        /// package. This can only be specified for package type <c>ZIP-PLUGIN</c> 
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property PackageConfiguration. 
        /// <para>
        ///  The configuration parameters for the package being created.
        /// </para>
        /// </summary>
        public PackageConfiguration PackageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PackageConfiguration property is set.
        /// </summary>
        internal bool IsSetPackageConfiguration() => this.PackageConfiguration != null;

        /// <summary>
        /// Gets and sets the property PackageDescription. 
        /// <para>
        /// Description of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PackageDescription { get; set; }

        /// <summary>
        /// Checks to see if the PackageDescription property is set.
        /// </summary>
        internal bool IsSetPackageDescription() => this.PackageDescription != null;

        /// <summary>
        /// Gets and sets the property PackageEncryptionOptions. 
        /// <para>
        /// The encryption parameters for the package being created.
        /// </para>
        /// </summary>
        public PackageEncryptionOptions PackageEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the PackageEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetPackageEncryptionOptions() => this.PackageEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// Unique name for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 256)]
        public string PackageName { get; set; }

        /// <summary>
        /// Checks to see if the PackageName property is set.
        /// </summary>
        internal bool IsSetPackageName() => this.PackageName != null;

        /// <summary>
        /// Gets and sets the property PackageSource. 
        /// <para>
        /// The Amazon S3 location from which to import the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PackageSource PackageSource { get; set; }

        /// <summary>
        /// Checks to see if the PackageSource property is set.
        /// </summary>
        internal bool IsSetPackageSource() => this.PackageSource != null;

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The type of package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PackageType PackageType { get; set; }

        /// <summary>
        /// Checks to see if the PackageType property is set.
        /// </summary>
        internal bool IsSetPackageType() => this.PackageType != null;

        /// <summary>
        /// Gets and sets the property PackageVendingOptions. 
        /// <para>
        ///  The vending options for the package being created. They determine if the package
        /// can be vended to other users.
        /// </para>
        /// </summary>
        public PackageVendingOptions PackageVendingOptions { get; set; }

        /// <summary>
        /// Checks to see if the PackageVendingOptions property is set.
        /// </summary>
        internal bool IsSetPackageVendingOptions() => this.PackageVendingOptions != null;
    }
}
