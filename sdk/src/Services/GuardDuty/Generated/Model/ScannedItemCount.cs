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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Total number of scanned files.
    /// </summary>
    public partial class ScannedItemCount
    {
        private int? _files;
        private int? _totalGb;
        private int? _volumes;

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// Number of files scanned.
        /// </para>
        /// </summary>
        public int? Files
        {
            get { return this._files; }
            set { this._files = value; }
        }

        // Check to see if Files property is set
        internal bool IsSetFiles()
        {
            return this._files.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalGb. 
        /// <para>
        /// Total GB of files scanned for malware.
        /// </para>
        /// </summary>
        public int? TotalGb
        {
            get { return this._totalGb; }
            set { this._totalGb = value; }
        }

        // Check to see if TotalGb property is set
        internal bool IsSetTotalGb()
        {
            return this._totalGb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// Total number of scanned volumes.
        /// </para>
        /// </summary>
        public int? Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes.HasValue; 
        }

    }
}