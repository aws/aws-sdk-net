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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Represents the health of an Amazon Web Services service.
    /// </summary>
    public partial class ServiceHealth
    {
        /// <summary>
        /// Gets and sets the property AnalyzedResourceCount. 
        /// <para>
        ///  Number of resources that DevOps Guru is monitoring in an analyzed Amazon Web Services
        /// service. 
        /// </para>
        /// </summary>
        public long? AnalyzedResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzedResourceCount property is set.
        /// </summary>
        internal bool IsSetAnalyzedResourceCount() => this.AnalyzedResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Insight. 
        /// <para>
        /// Represents the health of an Amazon Web Services service. This is a <c>ServiceInsightHealth</c>
        /// that contains the number of open proactive and reactive insights for this service.
        /// </para>
        /// </summary>
        public ServiceInsightHealth Insight { get; set; }

        /// <summary>
        /// Checks to see if the Insight property is set.
        /// </summary>
        internal bool IsSetInsight() => this.Insight != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service.
        /// </para>
        /// </summary>
        public ServiceName ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}
