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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The level of detail included in each aspect of your DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">task
    /// report</a>.
    /// </summary>
    public partial class ReportOverrides
    {
        private ReportOverride _deleted;
        private ReportOverride _skipped;
        private ReportOverride _transferred;
        private ReportOverride _verified;

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Specifies the level of reporting for the files, objects, and directories that DataSync
        /// attempted to delete in your destination location. This only applies if you <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html">configure
        /// your task</a> to delete data in the destination that isn't in the source.
        /// </para>
        /// </summary>
        public ReportOverride Deleted
        {
            get { return this._deleted; }
            set { this._deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeleted()
        {
            return this._deleted != null;
        }

        /// <summary>
        /// Gets and sets the property Skipped. 
        /// <para>
        /// Specifies the level of reporting for the files, objects, and directories that DataSync
        /// attempted to skip during your transfer.
        /// </para>
        /// </summary>
        public ReportOverride Skipped
        {
            get { return this._skipped; }
            set { this._skipped = value; }
        }

        // Check to see if Skipped property is set
        internal bool IsSetSkipped()
        {
            return this._skipped != null;
        }

        /// <summary>
        /// Gets and sets the property Transferred. 
        /// <para>
        /// Specifies the level of reporting for the files, objects, and directories that DataSync
        /// attempted to transfer.
        /// </para>
        /// </summary>
        public ReportOverride Transferred
        {
            get { return this._transferred; }
            set { this._transferred = value; }
        }

        // Check to see if Transferred property is set
        internal bool IsSetTransferred()
        {
            return this._transferred != null;
        }

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        /// Specifies the level of reporting for the files, objects, and directories that DataSync
        /// attempted to verify at the end of your transfer.
        /// </para>
        /// </summary>
        public ReportOverride Verified
        {
            get { return this._verified; }
            set { this._verified = value; }
        }

        // Check to see if Verified property is set
        internal bool IsSetVerified()
        {
            return this._verified != null;
        }

    }
}