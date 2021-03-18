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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The severity assigned to the finding by the finding provider.
    /// </summary>
    public partial class FindingProviderSeverity
    {
        private SeverityLabel _label;
        private string _original;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The severity label assigned to the finding by the finding provider.
        /// </para>
        /// </summary>
        public SeverityLabel Label
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
        /// Gets and sets the property Original. 
        /// <para>
        /// The finding provider's original value for the severity.
        /// </para>
        /// </summary>
        public string Original
        {
            get { return this._original; }
            set { this._original = value; }
        }

        // Check to see if Original property is set
        internal bool IsSetOriginal()
        {
            return this._original != null;
        }

    }
}