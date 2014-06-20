/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Reports the configuration of a bootstrap action in a job flow.
    /// </summary>
    public partial class BootstrapActionDetail
    {
        private BootstrapActionConfig _bootstrapActionConfig;


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


        /// <summary>
        /// Sets the BootstrapActionConfig property
        /// </summary>
        /// <param name="bootstrapActionConfig">The value to set for the BootstrapActionConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BootstrapActionDetail WithBootstrapActionConfig(BootstrapActionConfig bootstrapActionConfig)
        {
            this._bootstrapActionConfig = bootstrapActionConfig;
            return this;
        }

        // Check to see if BootstrapActionConfig property is set
        internal bool IsSetBootstrapActionConfig()
        {
            return this._bootstrapActionConfig != null;
        }

    }
}