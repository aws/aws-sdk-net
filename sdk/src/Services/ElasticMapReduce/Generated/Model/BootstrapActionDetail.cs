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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Reports the configuration of a bootstrap action in a cluster (job flow).
    /// </summary>
    public partial class BootstrapActionDetail
    {
        private BootstrapActionConfig _bootstrapActionConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public BootstrapActionDetail() { }

        /// <summary>
        /// Instantiates BootstrapActionDetail with the parameterized properties
        /// </summary>
        /// <param name="bootstrapActionConfig">A description of the bootstrap action.</param>
        public BootstrapActionDetail(BootstrapActionConfig bootstrapActionConfig)
        {
            _bootstrapActionConfig = bootstrapActionConfig;
        }

        /// <summary>
        /// Gets and sets the property BootstrapActionConfig. 
        /// <para>
        /// A description of the bootstrap action.
        /// </para>
        /// </summary>
        public BootstrapActionConfig BootstrapActionConfig
        {
            get { return this._bootstrapActionConfig; }
            set { this._bootstrapActionConfig = value; }
        }

        // Check to see if BootstrapActionConfig property is set
        internal bool IsSetBootstrapActionConfig()
        {
            return this._bootstrapActionConfig != null;
        }

    }
}