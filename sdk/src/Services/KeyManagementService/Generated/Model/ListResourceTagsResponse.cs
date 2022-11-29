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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the ListResourceTags operation.
    /// </summary>
    public partial class ListResourceTagsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<Tag> _tags = new List<Tag>();
        private bool? _truncated;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When <code>Truncated</code> is true, this element is present and contains the value
        /// to use for the <code>Marker</code> parameter in a subsequent request.
        /// </para>
        ///  
        /// <para>
        /// Do not assume or infer any information from this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags. Each tag consists of a tag key and a tag value.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tagging or untagging a KMS key can allow or deny permission to the KMS key. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property Truncated. 
        /// <para>
        /// A flag that indicates whether there are more items in the list. When this value is
        /// true, the list in this response is truncated. To get more items, pass the value of
        /// the <code>NextMarker</code> element in thisresponse to the <code>Marker</code> parameter
        /// in a subsequent request.
        /// </para>
        /// </summary>
        public bool Truncated
        {
            get { return this._truncated.GetValueOrDefault(); }
            set { this._truncated = value; }
        }

        // Check to see if Truncated property is set
        internal bool IsSetTruncated()
        {
            return this._truncated.HasValue; 
        }

    }
}