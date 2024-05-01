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
    /// Container for the parameters to the DeletePackage operation.
    /// Deletes a package.
    /// 
    ///  <note> 
    /// <para>
    /// To delete a package, you need permission to call <c>s3:DeleteObject</c> in addition
    /// to permissions for the AWS Panorama API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeletePackageRequest : AmazonPanoramaRequest
    {
        private bool? _forceDelete;
        private string _packageId;

        /// <summary>
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// Delete the package even if it has artifacts stored in its access point. Deletes the
        /// package's artifacts from Amazon S3.
        /// </para>
        /// </summary>
        public bool? ForceDelete
        {
            get { return this._forceDelete; }
            set { this._forceDelete = value; }
        }

        // Check to see if ForceDelete property is set
        internal bool IsSetForceDelete()
        {
            return this._forceDelete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PackageId. 
        /// <para>
        /// The package's ID.
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

    }
}