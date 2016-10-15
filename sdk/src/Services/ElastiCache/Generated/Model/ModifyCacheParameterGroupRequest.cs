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

/*
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
    /// Modifies the parameters of a cache parameter group. You can modify up to 20 parameters
    /// in a single request by submitting a list parameter name and value pairs.
    /// </summary>
    public partial class ModifyCacheParameterGroupRequest : AmazonElastiCacheRequest
    {
        private string _cacheParameterGroupName;
        private List<ParameterNameValue> _parameterNameValues = new List<ParameterNameValue>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifyCacheParameterGroupRequest() { }

        /// <summary>
        /// Instantiates ModifyCacheParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheParameterGroupName">The name of the cache parameter group to modify.</param>
        /// <param name="parameterNameValues">An array of parameter names and values for the parameter update. You must supply at least one parameter name and value; subsequent arguments are optional. A maximum of 20 parameters may be modified per request.</param>
        public ModifyCacheParameterGroupRequest(string cacheParameterGroupName, List<ParameterNameValue> parameterNameValues)
        {
            _cacheParameterGroupName = cacheParameterGroupName;
            _parameterNameValues = parameterNameValues;
        }

        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to modify.
        /// </para>
        /// </summary>
        public string CacheParameterGroupName
        {
            get { return this._cacheParameterGroupName; }
            set { this._cacheParameterGroupName = value; }
        }

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this._cacheParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterNameValues. 
        /// <para>
        /// An array of parameter names and values for the parameter update. You must supply at
        /// least one parameter name and value; subsequent arguments are optional. A maximum of
        /// 20 parameters may be modified per request.
        /// </para>
        /// </summary>
        public List<ParameterNameValue> ParameterNameValues
        {
            get { return this._parameterNameValues; }
            set { this._parameterNameValues = value; }
        }

        // Check to see if ParameterNameValues property is set
        internal bool IsSetParameterNameValues()
        {
            return this._parameterNameValues != null && this._parameterNameValues.Count > 0; 
        }

    }
}