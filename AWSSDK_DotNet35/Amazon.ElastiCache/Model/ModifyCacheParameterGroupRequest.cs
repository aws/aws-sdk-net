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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCacheParameterGroup operation.
    /// <para>The <i>ModifyCacheParameterGroup</i> operation modifies the parameters of a cache parameter group. You can modify up to 20 parameters
    /// in a single request by submitting a list parameter name and value pairs.</para>
    /// </summary>
    public partial class ModifyCacheParameterGroupRequest : AmazonElastiCacheRequest
    {
        private string cacheParameterGroupName;
        private List<ParameterNameValue> parameterNameValues = new List<ParameterNameValue>();


        /// <summary>
        /// The name of the cache parameter group to modify.
        ///  
        /// </summary>
        public string CacheParameterGroupName
        {
            get { return this.cacheParameterGroupName; }
            set { this.cacheParameterGroupName = value; }
        }

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this.cacheParameterGroupName != null;
        }

        /// <summary>
        /// An array of parameter names and values for the parameter update. You must supply at least one parameter name and value; subsequent arguments
        /// are optional. A maximum of 20 parameters may be modified per request.
        ///  
        /// </summary>
        public List<ParameterNameValue> ParameterNameValues
        {
            get { return this.parameterNameValues; }
            set { this.parameterNameValues = value; }
        }

        // Check to see if ParameterNameValues property is set
        internal bool IsSetParameterNameValues()
        {
            return this.parameterNameValues.Count > 0;
        }

    }
}
    
