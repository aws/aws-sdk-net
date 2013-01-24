/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>Reports the configuration of a bootstrap action in a job flow.</para>
    /// </summary>
    public class BootstrapActionDetail
    {
        
        private BootstrapActionConfig bootstrapActionConfig;

        /// <summary>
        /// A description of the bootstrap action.
        ///  
        /// </summary>
        public BootstrapActionConfig BootstrapActionConfig
        {
            get { return this.bootstrapActionConfig; }
            set { this.bootstrapActionConfig = value; }
        }

        /// <summary>
        /// Sets the BootstrapActionConfig property
        /// </summary>
        /// <param name="bootstrapActionConfig">The value to set for the BootstrapActionConfig property </param>
        /// <returns>this instance</returns>
        public BootstrapActionDetail WithBootstrapActionConfig(BootstrapActionConfig bootstrapActionConfig)
        {
            this.bootstrapActionConfig = bootstrapActionConfig;
            return this;
        }
            

        // Check to see if BootstrapActionConfig property is set
        internal bool IsSetBootstrapActionConfig()
        {
            return this.bootstrapActionConfig != null;
        }
    }
}
