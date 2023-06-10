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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Summary includes the name and status of the conformance pack.
    /// </summary>
    public partial class ConformancePackComplianceSummary
    {
        private ConformancePackComplianceType _conformancePackComplianceStatus;
        private string _conformancePackName;

        /// <summary>
        /// Gets and sets the property ConformancePackComplianceStatus. 
        /// <para>
        /// The status of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConformancePackComplianceType ConformancePackComplianceStatus
        {
            get { return this._conformancePackComplianceStatus; }
            set { this._conformancePackComplianceStatus = value; }
        }

        // Check to see if ConformancePackComplianceStatus property is set
        internal bool IsSetConformancePackComplianceStatus()
        {
            return this._conformancePackComplianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// The name of the conformance pack name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConformancePackName
        {
            get { return this._conformancePackName; }
            set { this._conformancePackName = value; }
        }

        // Check to see if ConformancePackName property is set
        internal bool IsSetConformancePackName()
        {
            return this._conformancePackName != null;
        }

    }
}