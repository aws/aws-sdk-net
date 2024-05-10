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
    /// The configuration that specifies a minimum amount of time since last access for an
    /// exported file to be eligible for release from an Amazon FSx for Lustre file system.
    /// Only files that were last accessed before this point-in-time can be released. For
    /// example, if you specify a last accessed time criteria of 9 days, only files that were
    /// last accessed 9.00001 or more days ago can be released.
    /// 
    ///  
    /// <para>
    /// Only file data that has been exported to S3 can be released. Files that have not yet
    /// been exported to S3, such as new or changed files that have not been exported, are
    /// not eligible for release. When files are released, their metadata stays on the file
    /// system, so they can still be accessed later. Users and applications can access a released
    /// file by reading the file again, which restores data from Amazon S3 to the FSx for
    /// Lustre file system.
    /// </para>
    ///  <note> 
    /// <para>
    /// If a file meets the last accessed time criteria, its file or directory path must also
    /// be specified with the <c>Paths</c> parameter of the operation in order for the file
    /// to be released.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ReleaseConfiguration
    {
        private DurationSinceLastAccess _durationSinceLastAccess;

        /// <summary>
        /// Gets and sets the property DurationSinceLastAccess. 
        /// <para>
        /// Defines the point-in-time since an exported file was last accessed, in order for that
        /// file to be eligible for release. Only files that were last accessed before this point-in-time
        /// are eligible to be released from the file system.
        /// </para>
        /// </summary>
        public DurationSinceLastAccess DurationSinceLastAccess
        {
            get { return this._durationSinceLastAccess; }
            set { this._durationSinceLastAccess = value; }
        }

        // Check to see if DurationSinceLastAccess property is set
        internal bool IsSetDurationSinceLastAccess()
        {
            return this._durationSinceLastAccess != null;
        }

    }
}