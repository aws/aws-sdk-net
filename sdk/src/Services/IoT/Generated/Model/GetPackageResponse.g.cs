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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetPackage operation.
    /// </summary>
    public partial class GetPackageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the package was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultVersionName. 
        /// <para>
        /// The name of the default package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DefaultVersionName { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersionName property is set.
        /// </summary>
        internal bool IsSetDefaultVersionName() => this.DefaultVersionName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The package description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the package was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PackageArn. 
        /// <para>
        /// The ARN for the package.
        /// </para>
        /// </summary>
        public string PackageArn { get; set; }

        /// <summary>
        /// Checks to see if the PackageArn property is set.
        /// </summary>
        internal bool IsSetPackageArn() => this.PackageArn != null;

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The name of the software package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PackageName { get; set; }

        /// <summary>
        /// Checks to see if the PackageName property is set.
        /// </summary>
        internal bool IsSetPackageName() => this.PackageName != null;
    }
}
