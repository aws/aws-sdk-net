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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for an Amazon S3 data repository linked to an Amazon FSx for Lustre
    /// file system with a data repository association. The configuration consists of an <c>AutoImportPolicy</c>
    /// that defines which file events on the data repository are automatically imported to
    /// the file system and an <c>AutoExportPolicy</c> that defines which file events on the
    /// file system are automatically exported to the data repository. File events are when
    /// files or directories are added, changed, or deleted on the file system or the data
    /// repository.
    /// 
    ///  <note> 
    /// <para>
    /// Data repository associations on Amazon File Cache don't use <c>S3DataRepositoryConfiguration</c>
    /// because they don't support automatic import or automatic export.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class S3DataRepositoryConfiguration
    {
        private AutoExportPolicy _autoExportPolicy;
        private AutoImportPolicy _autoImportPolicy;

        /// <summary>
        /// Gets and sets the property AutoExportPolicy. 
        /// <para>
        /// Specifies the type of updated objects (new, changed, deleted) that will be automatically
        /// exported from your file system to the linked S3 bucket.
        /// </para>
        /// </summary>
        public AutoExportPolicy AutoExportPolicy
        {
            get { return this._autoExportPolicy; }
            set { this._autoExportPolicy = value; }
        }

        // Check to see if AutoExportPolicy property is set
        internal bool IsSetAutoExportPolicy()
        {
            return this._autoExportPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AutoImportPolicy. 
        /// <para>
        /// Specifies the type of updated objects (new, changed, deleted) that will be automatically
        /// imported from the linked S3 bucket to your file system.
        /// </para>
        /// </summary>
        public AutoImportPolicy AutoImportPolicy
        {
            get { return this._autoImportPolicy; }
            set { this._autoImportPolicy = value; }
        }

        // Check to see if AutoImportPolicy property is set
        internal bool IsSetAutoImportPolicy()
        {
            return this._autoImportPolicy != null;
        }

    }
}