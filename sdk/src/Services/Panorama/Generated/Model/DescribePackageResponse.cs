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
    /// This is the response object from the DescribePackage operation.
    /// </summary>
    public partial class DescribePackageResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _packageId;
        private string _packageName;
        private List<string> _readAccessPrincipalArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StorageLocation _storageLocation;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _writeAccessPrincipalArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The package's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the package was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
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

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The package's name.
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
        /// Gets and sets the property ReadAccessPrincipalArns. 
        /// <para>
        /// ARNs of accounts that have read access to the package.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadAccessPrincipalArns
        {
            get { return this._readAccessPrincipalArns; }
            set { this._readAccessPrincipalArns = value; }
        }

        // Check to see if ReadAccessPrincipalArns property is set
        internal bool IsSetReadAccessPrincipalArns()
        {
            return this._readAccessPrincipalArns != null && (this._readAccessPrincipalArns.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The package's tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WriteAccessPrincipalArns. 
        /// <para>
        /// ARNs of accounts that have write access to the package.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WriteAccessPrincipalArns
        {
            get { return this._writeAccessPrincipalArns; }
            set { this._writeAccessPrincipalArns = value; }
        }

        // Check to see if WriteAccessPrincipalArns property is set
        internal bool IsSetWriteAccessPrincipalArns()
        {
            return this._writeAccessPrincipalArns != null && (this._writeAccessPrincipalArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}