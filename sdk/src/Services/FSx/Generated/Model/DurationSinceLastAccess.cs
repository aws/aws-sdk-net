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
    /// Defines the minimum amount of time since last access for a file to be eligible for
    /// release. Only files that have been exported to S3 and that were last accessed or modified
    /// before this point-in-time are eligible to be released from the Amazon FSx for Lustre
    /// file system.
    /// </summary>
    public partial class DurationSinceLastAccess
    {
        private Unit _unit;
        private long? _value;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of time used by the <c>Value</c> parameter to determine if a file can be
        /// released, based on when it was last accessed. <c>DAYS</c> is the only supported value.
        /// This is a required parameter.
        /// </para>
        /// </summary>
        public Unit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// An integer that represents the minimum amount of time (in days) since a file was last
        /// accessed in the file system. Only exported files with a <c>MAX(atime, ctime, mtime)</c>
        /// timestamp that is more than this amount of time in the past (relative to the task
        /// create time) will be released. The default of <c>Value</c> is <c>0</c>. This is a
        /// required parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// If an exported file meets the last accessed time criteria, its file or directory path
        /// must also be specified in the <c>Paths</c> parameter of the operation in order for
        /// the file to be released.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}