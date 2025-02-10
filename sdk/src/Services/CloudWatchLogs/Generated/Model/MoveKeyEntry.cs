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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This object defines one key that will be moved with the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-moveKey">
    /// moveKey</a> processor.
    /// </summary>
    public partial class MoveKeyEntry
    {
        private bool? _overwriteIfExists;
        private string _source;
        private string _target;

        /// <summary>
        /// Gets and sets the property OverwriteIfExists. 
        /// <para>
        /// Specifies whether to overwrite the value if the destination key already exists. If
        /// you omit this, the default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? OverwriteIfExists
        {
            get { return this._overwriteIfExists; }
            set { this._overwriteIfExists = value; }
        }

        // Check to see if OverwriteIfExists property is set
        internal bool IsSetOverwriteIfExists()
        {
            return this._overwriteIfExists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The key to move.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The key to move to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}