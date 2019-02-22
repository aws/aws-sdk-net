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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds one or more tags to the resource, such as a workgroup. A tag is a label that
    /// you assign to an AWS Athena resource (a workgroup). Each tag consists of a key and
    /// an optional value, both of which you define. Tags enable you to categorize resources
    /// (workgroups) in Athena, for example, by purpose, owner, or environment. Use a consistent
    /// set of tag keys to make it easier to search and filter workgroups in your account.
    /// For best practices, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">AWS
    /// Tagging Strategies</a>. The key length is from 1 (minimum) to 128 (maximum) Unicode
    /// characters in UTF-8. The tag value length is from 0 (minimum) to 256 (maximum) Unicode
    /// characters in UTF-8. You can use letters and numbers representable in UTF-8, and the
    /// following characters: + - = . _ : / @. Tag keys and values are case-sensitive. Tag
    /// keys must be unique per resource. If you specify more than one, separate them by commas.
    /// </summary>
    public partial class TagResourceRequest : AmazonAthenaRequest
    {
        private string _resourceARN;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// Requests that one or more tags are added to the resource (such as a workgroup) for
        /// the specified ARN.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags, separated by commas, to be added to the resource, such as a workgroup.
        /// </para>
        /// </summary>
        public List<Tag> Tags
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