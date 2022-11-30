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
    /// The Athena engine version for running queries, or the PySpark engine version for running
    /// sessions.
    /// </summary>
    public partial class EngineVersion
    {
        private string _effectiveEngineVersion;
        private string _selectedEngineVersion;

        /// <summary>
        /// Gets and sets the property EffectiveEngineVersion. 
        /// <para>
        /// Read only. The engine version on which the query runs. If the user requests a valid
        /// engine version other than Auto, the effective engine version is the same as the engine
        /// version that the user requested. If the user requests Auto, the effective engine version
        /// is chosen by Athena. When a request to update the engine version is made by a <code>CreateWorkGroup</code>
        /// or <code>UpdateWorkGroup</code> operation, the <code>EffectiveEngineVersion</code>
        /// field is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EffectiveEngineVersion
        {
            get { return this._effectiveEngineVersion; }
            set { this._effectiveEngineVersion = value; }
        }

        // Check to see if EffectiveEngineVersion property is set
        internal bool IsSetEffectiveEngineVersion()
        {
            return this._effectiveEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedEngineVersion. 
        /// <para>
        /// The engine version requested by the user. Possible values are determined by the output
        /// of <code>ListEngineVersions</code>, including Auto. The default is Auto.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SelectedEngineVersion
        {
            get { return this._selectedEngineVersion; }
            set { this._selectedEngineVersion = value; }
        }

        // Check to see if SelectedEngineVersion property is set
        internal bool IsSetSelectedEngineVersion()
        {
            return this._selectedEngineVersion != null;
        }

    }
}