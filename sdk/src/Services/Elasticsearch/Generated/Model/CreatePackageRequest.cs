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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePackage operation.
    /// Create a package for use with Amazon ES domains.
    /// </summary>
    public partial class CreatePackageRequest : AmazonElasticsearchRequest
    {
        private string _packageDescription;
        private string _packageName;
        private PackageSource _packageSource;
        private PackageType _packageType;

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
        /// Gets and sets the property PackageName. 
        /// <para>
        /// Unique identifier for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
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
        /// The customer S3 location <c>PackageSource</c> for importing the package.
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
        /// Type of package. Currently supports only TXT-DICTIONARY.
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

    }
}