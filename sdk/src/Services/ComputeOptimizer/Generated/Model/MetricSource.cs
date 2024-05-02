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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// The list of metric sources required to generate recommendations for commercial software
    /// licenses.
    /// </summary>
    public partial class MetricSource
    {
        private MetricSourceProvider _provider;
        private string _providerArn;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        ///  The name of the metric source provider. 
        /// </para>
        /// </summary>
        public MetricSourceProvider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderArn. 
        /// <para>
        ///  The ARN of the metric source provider. 
        /// </para>
        /// </summary>
        public string ProviderArn
        {
            get { return this._providerArn; }
            set { this._providerArn = value; }
        }

        // Check to see if ProviderArn property is set
        internal bool IsSetProviderArn()
        {
            return this._providerArn != null;
        }

    }
}