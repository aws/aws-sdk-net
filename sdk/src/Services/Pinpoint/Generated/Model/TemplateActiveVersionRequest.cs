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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies which version of a message template to use as the active version of the
    /// template.
    /// </summary>
    public partial class TemplateActiveVersionRequest
    {
        private string _version;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the message template to use as the active version of the template.
        /// Valid values are: latest, for the most recent version of the template; or, the unique
        /// identifier for any existing version of the template. If you specify an identifier,
        /// the value must match the identifier for an existing template version. To retrieve
        /// a list of versions and version identifiers for a template, use the <link  linkend="templates-template-name-template-type-versions">Template
        /// Versions</link> resource.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}