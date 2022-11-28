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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OAM.Model
{
    /// <summary>
    /// A structure that contains information about one link attached to this monitoring account
    /// sink.
    /// </summary>
    public partial class ListAttachedLinksItem
    {
        private string _label;
        private string _linkArn;
        private List<string> _resourceTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label that was assigned to this link at creation, with the variables resolved
        /// to their actual values.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property LinkArn. 
        /// <para>
        /// The ARN of the link.
        /// </para>
        /// </summary>
        public string LinkArn
        {
            get { return this._linkArn; }
            set { this._linkArn = value; }
        }

        // Check to see if LinkArn property is set
        internal bool IsSetLinkArn()
        {
            return this._linkArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The resource types supported by this link.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

    }
}