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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about the location of application artifacts stored in Amazon S3.
    /// </summary>
    public partial class S3Location
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where the application revision is stored.
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property BundleType. 
        /// <para>
        /// The file type of the application revision. Must be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tar</c>: A tar archive file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tgz</c>: A compressed tar archive file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zip</c>: A zip archive file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YAML</c>: A YAML-formatted file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JSON</c>: A JSON-formatted file.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BundleType BundleType { get; set; }

        /// <summary>
        /// Checks to see if the BundleType property is set.
        /// </summary>
        internal bool IsSetBundleType() => this.BundleType != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The ETag of the Amazon S3 object that represents the bundled artifacts for the application
        /// revision.
        /// </para>
        ///  
        /// <para>
        /// If the ETag is not specified as an input parameter, ETag validation of the object
        /// is skipped.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the Amazon S3 object that represents the bundled artifacts for the application
        /// revision.
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A specific version of the Amazon S3 object that represents the bundled artifacts for
        /// the application revision.
        /// </para>
        ///  
        /// <para>
        /// If the version is not specified, the system uses the most recent version by default.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
