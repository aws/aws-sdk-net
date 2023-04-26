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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds one or more tags to an Athena resource. A tag is a label that you assign to a
    /// resource. In Athena, a resource can be a workgroup or data catalog. Each tag consists
    /// of a key and an optional value, both of which you define. For example, you can use
    /// tags to categorize Athena workgroups or data catalogs by purpose, owner, or environment.
    /// Use a consistent set of tag keys to make it easier to search and filter workgroups
    /// or data catalogs in your account. For best practices, see <a href="https://docs.aws.amazon.com/whitepapers/latest/tagging-best-practices/tagging-best-practices.html">Tagging
    /// Best Practices</a>. Tag keys can be from 1 to 128 UTF-8 Unicode characters, and tag
    /// values can be from 0 to 256 UTF-8 Unicode characters. Tags can use letters and numbers
    /// representable in UTF-8, and the following characters: + - = . _ : / @. Tag keys and
    /// values are case-sensitive. Tag keys must be unique per resource. If you specify more
    /// than one tag, separate them by commas.
    /// </summary>
    public partial class TagResourceRequest : AmazonAthenaRequest
    {
        private string _resourceARN;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// Specifies the ARN of the Athena resource (workgroup or data catalog) to which tags
        /// are to be added.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of one or more tags, separated by commas, to be added to an Athena workgroup
        /// or data catalog resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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