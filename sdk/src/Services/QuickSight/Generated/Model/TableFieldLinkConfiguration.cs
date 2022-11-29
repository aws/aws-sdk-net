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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The link configuration of a table field URL.
    /// </summary>
    public partial class TableFieldLinkConfiguration
    {
        private TableFieldLinkContentConfiguration _content;
        private URLTargetConfiguration _target;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The URL content (text, icon) for the table link configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableFieldLinkContentConfiguration Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The URL target (new tab, new window, same tab) for the table link configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public URLTargetConfiguration Target
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