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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about a recommended step for an unused access analyzer finding.
    /// </summary>
    public partial class RecommendedStep
    {
        private UnusedPermissionsRecommendedStep _unusedPermissionsRecommendedStep;

        /// <summary>
        /// Gets and sets the property UnusedPermissionsRecommendedStep. 
        /// <para>
        /// A recommended step for an unused permissions finding.
        /// </para>
        /// </summary>
        public UnusedPermissionsRecommendedStep UnusedPermissionsRecommendedStep
        {
            get { return this._unusedPermissionsRecommendedStep; }
            set { this._unusedPermissionsRecommendedStep = value; }
        }

        // Check to see if UnusedPermissionsRecommendedStep property is set
        internal bool IsSetUnusedPermissionsRecommendedStep()
        {
            return this._unusedPermissionsRecommendedStep != null;
        }

    }
}