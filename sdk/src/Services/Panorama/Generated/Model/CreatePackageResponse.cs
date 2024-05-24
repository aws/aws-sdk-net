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
    /// This is the response object from the CreatePackage operation.
    /// </summary>
    public partial class CreatePackageResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _packageId;
        private StorageLocation _storageLocation;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The package's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property PackageId. 
        /// <para>
        /// The package's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// The package's storage location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageLocation StorageLocation
        {
            get { return this._storageLocation; }
            set { this._storageLocation = value; }
        }

        // Check to see if StorageLocation property is set
        internal bool IsSetStorageLocation()
        {
            return this._storageLocation != null;
        }

    }
}