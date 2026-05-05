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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object that contains configuration settings for the matching process in a rule-based
    /// matching workflow.
    /// </summary>
    public partial class MatchingConfig
    {
        private bool? _enableTransitiveMatching;

        /// <summary>
        /// Gets and sets the property EnableTransitiveMatching. 
        /// <para>
        /// Enables transitive matching for the rule-based matching workflow. When enabled, records
        /// that match through different rules are grouped together into the same match group.
        /// </para>
        /// </summary>
        public bool? EnableTransitiveMatching
        {
            get { return this._enableTransitiveMatching; }
            set { this._enableTransitiveMatching = value; }
        }

        // Check to see if EnableTransitiveMatching property is set
        internal bool IsSetEnableTransitiveMatching()
        {
            return this._enableTransitiveMatching.HasValue; 
        }

    }
}