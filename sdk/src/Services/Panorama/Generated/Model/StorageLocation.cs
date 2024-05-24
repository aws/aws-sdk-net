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
    /// A storage location.
    /// </summary>
    public partial class StorageLocation
    {
        private string _binaryPrefixLocation;
        private string _bucket;
        private string _generatedPrefixLocation;
        private string _manifestPrefixLocation;
        private string _repoPrefixLocation;

        /// <summary>
        /// Gets and sets the property BinaryPrefixLocation. 
        /// <para>
        /// The location's binary prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BinaryPrefixLocation
        {
            get { return this._binaryPrefixLocation; }
            set { this._binaryPrefixLocation = value; }
        }

        // Check to see if BinaryPrefixLocation property is set
        internal bool IsSetBinaryPrefixLocation()
        {
            return this._binaryPrefixLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The location's bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedPrefixLocation. 
        /// <para>
        /// The location's generated prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GeneratedPrefixLocation
        {
            get { return this._generatedPrefixLocation; }
            set { this._generatedPrefixLocation = value; }
        }

        // Check to see if GeneratedPrefixLocation property is set
        internal bool IsSetGeneratedPrefixLocation()
        {
            return this._generatedPrefixLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestPrefixLocation. 
        /// <para>
        /// The location's manifest prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManifestPrefixLocation
        {
            get { return this._manifestPrefixLocation; }
            set { this._manifestPrefixLocation = value; }
        }

        // Check to see if ManifestPrefixLocation property is set
        internal bool IsSetManifestPrefixLocation()
        {
            return this._manifestPrefixLocation != null;
        }

        /// <summary>
        /// Gets and sets the property RepoPrefixLocation. 
        /// <para>
        /// The location's repo prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RepoPrefixLocation
        {
            get { return this._repoPrefixLocation; }
            set { this._repoPrefixLocation = value; }
        }

        // Check to see if RepoPrefixLocation property is set
        internal bool IsSetRepoPrefixLocation()
        {
            return this._repoPrefixLocation != null;
        }

    }
}