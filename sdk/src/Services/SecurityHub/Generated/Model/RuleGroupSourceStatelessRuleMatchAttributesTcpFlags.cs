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
    /// A set of TCP flags and masks to inspect for.
    /// </summary>
    public partial class RuleGroupSourceStatelessRuleMatchAttributesTcpFlags
    {
        private List<string> _flags = new List<string>();
        private List<string> _masks = new List<string>();

        /// <summary>
        /// Gets and sets the property Flags. 
        /// <para>
        /// Defines the flags from the <code>Masks</code> setting that must be set in order for
        /// the packet to match. Flags that are listed must be set. Flags that are not listed
        /// must not be set.
        /// </para>
        /// </summary>
        public List<string> Flags
        {
            get { return this._flags; }
            set { this._flags = value; }
        }

        // Check to see if Flags property is set
        internal bool IsSetFlags()
        {
            return this._flags != null && this._flags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Masks. 
        /// <para>
        /// The set of flags to consider in the inspection. If not specified, then all flags are
        /// inspected.
        /// </para>
        /// </summary>
        public List<string> Masks
        {
            get { return this._masks; }
            set { this._masks = value; }
        }

        // Check to see if Masks property is set
        internal bool IsSetMasks()
        {
            return this._masks != null && this._masks.Count > 0; 
        }

    }
}