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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Defines the storage configuration for a runtime environment.
    /// </summary>
    public partial class StorageConfiguration
    {
        private EfsStorageConfiguration _efs;
        private FsxStorageConfiguration _fsx;

        /// <summary>
        /// Gets and sets the property Efs. 
        /// <para>
        /// Defines the storage configuration for an Amazon EFS file system.
        /// </para>
        /// </summary>
        public EfsStorageConfiguration Efs
        {
            get { return this._efs; }
            set { this._efs = value; }
        }

        // Check to see if Efs property is set
        internal bool IsSetEfs()
        {
            return this._efs != null;
        }

        /// <summary>
        /// Gets and sets the property Fsx. 
        /// <para>
        /// Defines the storage configuration for an Amazon FSx file system.
        /// </para>
        /// </summary>
        public FsxStorageConfiguration Fsx
        {
            get { return this._fsx; }
            set { this._fsx = value; }
        }

        // Check to see if Fsx property is set
        internal bool IsSetFsx()
        {
            return this._fsx != null;
        }

    }
}