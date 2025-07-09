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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Defines the scope of repositories to be included in code security scans.
    /// </summary>
    public partial class ScopeSettings
    {
        private ProjectSelectionScope _projectSelectionScope;

        /// <summary>
        /// Gets and sets the property ProjectSelectionScope. 
        /// <para>
        /// The scope of projects to be selected for scanning within the integrated repositories.
        /// Setting the value to <c>ALL</c> applies the scope settings to all existing and future
        /// projects imported into Amazon Inspector.
        /// </para>
        /// </summary>
        public ProjectSelectionScope ProjectSelectionScope
        {
            get { return this._projectSelectionScope; }
            set { this._projectSelectionScope = value; }
        }

        // Check to see if ProjectSelectionScope property is set
        internal bool IsSetProjectSelectionScope()
        {
            return this._projectSelectionScope != null;
        }

    }
}