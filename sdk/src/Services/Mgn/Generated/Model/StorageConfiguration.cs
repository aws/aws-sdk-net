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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Storage configuration for replication.
    /// </summary>
    public partial class StorageConfiguration
    {
        private FsxOntapConfiguration _fsxOntapConfiguration;
        private StorageType _storageType;

        /// <summary>
        /// Gets and sets the property FsxOntapConfiguration. 
        /// <para>
        /// Storage configuration FSx ONTAP configuration.
        /// </para>
        /// </summary>
        public FsxOntapConfiguration FsxOntapConfiguration
        {
            get { return this._fsxOntapConfiguration; }
            set { this._fsxOntapConfiguration = value; }
        }

        // Check to see if FsxOntapConfiguration property is set
        internal bool IsSetFsxOntapConfiguration()
        {
            return this._fsxOntapConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Storage configuration storage type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}