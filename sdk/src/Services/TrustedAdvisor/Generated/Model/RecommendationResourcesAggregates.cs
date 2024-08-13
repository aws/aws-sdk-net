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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
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
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Aggregation of Recommendation Resources
    /// </summary>
    public partial class RecommendationResourcesAggregates
    {
        private long? _errorCount;
        private long? _okCount;
        private long? _warningCount;

        /// <summary>
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The number of AWS resources that were flagged to have errors according to the Trusted
        /// Advisor check
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ErrorCount
        {
            get { return this._errorCount; }
            set { this._errorCount = value; }
        }

        // Check to see if ErrorCount property is set
        internal bool IsSetErrorCount()
        {
            return this._errorCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OkCount. 
        /// <para>
        /// The number of AWS resources that were flagged to be OK according to the Trusted Advisor
        /// check
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? OkCount
        {
            get { return this._okCount; }
            set { this._okCount = value; }
        }

        // Check to see if OkCount property is set
        internal bool IsSetOkCount()
        {
            return this._okCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarningCount. 
        /// <para>
        /// The number of AWS resources that were flagged to have warning according to the Trusted
        /// Advisor check 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? WarningCount
        {
            get { return this._warningCount; }
            set { this._warningCount = value; }
        }

        // Check to see if WarningCount property is set
        internal bool IsSetWarningCount()
        {
            return this._warningCount.HasValue; 
        }

    }
}