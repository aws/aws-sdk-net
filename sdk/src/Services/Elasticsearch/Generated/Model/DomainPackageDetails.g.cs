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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Information on a package that is associated with a domain.
    /// </summary>
    public partial class DomainPackageDetails
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the domain you've associated a package with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainPackageStatus. 
        /// <para>
        /// State of the association. Values are ASSOCIATING/ASSOCIATION_FAILED/ACTIVE/DISSOCIATING/DISSOCIATION_FAILED.
        /// </para>
        /// </summary>
        public DomainPackageStatus DomainPackageStatus { get; set; }

        /// <summary>
        /// Checks to see if the DomainPackageStatus property is set.
        /// </summary>
        internal bool IsSetDomainPackageStatus() => this.DomainPackageStatus != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Additional information if the package is in an error state. Null otherwise.
        /// </para>
        /// </summary>
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// Timestamp of the most-recent update to the association status.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// Internal ID of the package.
        /// </para>
        /// </summary>
        public string PackageID { get; set; }

        /// <summary>
        /// Checks to see if the PackageID property is set.
        /// </summary>
        internal bool IsSetPackageID() => this.PackageID != null;

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// User specified name of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 28)]
        public string PackageName { get; set; }

        /// <summary>
        /// Checks to see if the PackageName property is set.
        /// </summary>
        internal bool IsSetPackageName() => this.PackageName != null;

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// Currently supports only TXT-DICTIONARY.
        /// </para>
        /// </summary>
        public PackageType PackageType { get; set; }

        /// <summary>
        /// Checks to see if the PackageType property is set.
        /// </summary>
        internal bool IsSetPackageType() => this.PackageType != null;

        /// <summary>
        /// Gets and sets the property PackageVersion.
        /// </summary>
        public string PackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the PackageVersion property is set.
        /// </summary>
        internal bool IsSetPackageVersion() => this.PackageVersion != null;

        /// <summary>
        /// Gets and sets the property ReferencePath. 
        /// <para>
        /// The relative path on Amazon ES nodes, which can be used as synonym_path when the package
        /// is synonym file.
        /// </para>
        /// </summary>
        public string ReferencePath { get; set; }

        /// <summary>
        /// Checks to see if the ReferencePath property is set.
        /// </summary>
        internal bool IsSetReferencePath() => this.ReferencePath != null;
    }
}
