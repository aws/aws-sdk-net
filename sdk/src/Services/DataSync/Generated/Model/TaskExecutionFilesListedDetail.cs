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
    /// The number of objects that DataSync finds at your locations.
    /// 
    ///  <note> 
    /// <para>
    /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
    /// mode tasks</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TaskExecutionFilesListedDetail
    {
        private long? _atDestinationForDelete;
        private long? _atSource;

        /// <summary>
        /// Gets and sets the property AtDestinationForDelete. 
        /// <para>
        /// The number of objects that DataSync finds at your destination location. This counter
        /// is only applicable if you <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html#task-option-file-object-handling">configure
        /// your task</a> to delete data in the destination that isn't in the source.
        /// </para>
        /// </summary>
        public long? AtDestinationForDelete
        {
            get { return this._atDestinationForDelete; }
            set { this._atDestinationForDelete = value; }
        }

        // Check to see if AtDestinationForDelete property is set
        internal bool IsSetAtDestinationForDelete()
        {
            return this._atDestinationForDelete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AtSource. 
        /// <para>
        /// The number of objects that DataSync finds at your source location.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">manifest</a>,
        /// DataSync lists only what's in your manifest (and not everything at your source location).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With an include <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">filter</a>,
        /// DataSync lists only what matches the filter at your source location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With an exclude filter, DataSync lists everything at your source location before applying
        /// the filter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public long? AtSource
        {
            get { return this._atSource; }
            set { this._atSource = value; }
        }

        // Check to see if AtSource property is set
        internal bool IsSetAtSource()
        {
            return this._atSource.HasValue; 
        }

    }
}