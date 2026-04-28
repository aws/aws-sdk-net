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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
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
namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Specifies a rule that controls how data is imported from S3 into the file system.
    /// </summary>
    public partial class ImportDataRule
    {
        private string _prefix;
        private long? _sizeLessThan;
        private ImportTrigger _trigger;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The S3 key prefix that scopes this import rule. Only objects with keys beginning with
        /// this prefix are subject to the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property SizeLessThan. 
        /// <para>
        /// The upper size limit in bytes for this import rule. Only objects with a size strictly
        /// less than this value will have data imported into the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=52673613135872)]
        public long? SizeLessThan
        {
            get { return this._sizeLessThan; }
            set { this._sizeLessThan = value; }
        }

        // Check to see if SizeLessThan property is set
        internal bool IsSetSizeLessThan()
        {
            return this._sizeLessThan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Trigger. 
        /// <para>
        /// The event that triggers data import. Valid values are <c>ON_DIRECTORY_FIRST_ACCESS</c>
        /// (import when a directory is first accessed) and <c>ON_FILE_ACCESS</c> (import when
        /// a file is accessed).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportTrigger Trigger
        {
            get { return this._trigger; }
            set { this._trigger = value; }
        }

        // Check to see if Trigger property is set
        internal bool IsSetTrigger()
        {
            return this._trigger != null;
        }

    }
}