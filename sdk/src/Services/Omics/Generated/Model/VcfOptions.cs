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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Formatting options for a VCF file.
    /// </summary>
    public partial class VcfOptions
    {
        private bool? _ignoreFilterField;
        private bool? _ignoreQualField;

        /// <summary>
        /// Gets and sets the property IgnoreFilterField. 
        /// <para>
        /// The file's ignore filter field setting.
        /// </para>
        /// </summary>
        public bool IgnoreFilterField
        {
            get { return this._ignoreFilterField.GetValueOrDefault(); }
            set { this._ignoreFilterField = value; }
        }

        // Check to see if IgnoreFilterField property is set
        internal bool IsSetIgnoreFilterField()
        {
            return this._ignoreFilterField.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnoreQualField. 
        /// <para>
        /// The file's ignore qual field setting.
        /// </para>
        /// </summary>
        public bool IgnoreQualField
        {
            get { return this._ignoreQualField.GetValueOrDefault(); }
            set { this._ignoreQualField = value; }
        }

        // Check to see if IgnoreQualField property is set
        internal bool IsSetIgnoreQualField()
        {
            return this._ignoreQualField.HasValue; 
        }

    }
}