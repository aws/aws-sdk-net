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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
        private long? _analyzedResourceCount;
        private ServiceInsightHealth _insight;
        private ServiceName _serviceName;

        /// <summary>
        /// Gets and sets the property AnalyzedResourceCount. 
        /// <para>
        ///  Number of resources that DevOps Guru is monitoring in an analyzed Amazon Web Services
        /// service. 
        /// </para>
        /// </summary>
        public long? AnalyzedResourceCount
        {
            get { return this._analyzedResourceCount; }
            set { this._analyzedResourceCount = value; }
        }

        // Check to see if AnalyzedResourceCount property is set
        internal bool IsSetAnalyzedResourceCount()
        {
            return this._analyzedResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Insight. 
        /// <para>
        /// Represents the health of an Amazon Web Services service. This is a <c>ServiceInsightHealth</c>
        /// that contains the number of open proactive and reactive insights for this service.
        /// </para>
        /// </summary>
        public ServiceInsightHealth Insight
        {
            get { return this._insight; }
            set { this._insight = value; }
        }

        // Check to see if Insight property is set
        internal bool IsSetInsight()
        {
            return this._insight != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service.
        /// </para>
        /// </summary>
        public ServiceName ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}