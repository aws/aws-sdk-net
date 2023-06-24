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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Describes the data repository association's automatic import policy. The AutoImportPolicy
    /// defines how Amazon FSx keeps your file metadata and directory listings up to date
    /// by importing changes to your Amazon FSx for Lustre file system as you modify objects
    /// in a linked S3 bucket.
    /// 
    ///  
    /// <para>
    /// The <code>AutoImportPolicy</code> is only supported on Amazon FSx for Lustre file
    /// systems with a data repository association.
    /// </para>
    /// </summary>
    public partial class AutoImportPolicy
    {
        private List<string> _events = new List<string>();

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The <code>AutoImportPolicy</code> can have the following event values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NEW</code> - Amazon FSx automatically imports metadata of files added to the
        /// linked S3 bucket that do not currently exist in the FSx file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CHANGED</code> - Amazon FSx automatically updates file metadata and invalidates
        /// existing file content on the file system as files change in the data repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> - Amazon FSx automatically deletes files on the file system
        /// as corresponding files are deleted in the data repository.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can define any combination of event types for your <code>AutoImportPolicy</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=3)]
        public List<string> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

    }
}