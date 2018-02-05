/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the AddTagsToStream operation.
    /// Adds or updates tags for the specified Kinesis data stream. Each stream can have up
    /// to 10 tags.
    /// 
    ///  
    /// <para>
    /// If tags have already been assigned to the stream, <code>AddTagsToStream</code> overwrites
    /// any existing tags that correspond to the specified tag keys.
    /// </para>
    ///  
    /// <para>
    ///  <a>AddTagsToStream</a> has a limit of five transactions per second per account.
    /// </para>
    /// </summary>
    public partial class AddTagsToStreamRequest : AmazonKinesisRequest
    {
        private string _streamName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream.
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The set of key-value pairs to use to create the tags.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}