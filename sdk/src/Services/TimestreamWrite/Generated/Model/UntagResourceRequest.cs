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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes the association of tags from a Timestream resource.
    /// </summary>
    public partial class UntagResourceRequest : AmazonTimestreamWriteRequest
    {
        private string _resourceARN;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        ///  The Timestream resource that the tags will be removed from. This value is an Amazon
        /// Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        ///  A list of tags keys. Existing tags of the resource whose keys are members of this
        /// list will be removed from the Timestream resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}