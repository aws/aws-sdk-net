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
    /// Container for the parameters to the ResetCacheParameterGroup operation.
    /// Modifies the parameters of a cache parameter group to the engine or system default
    /// value. You can reset specific parameters by submitting a list of parameter names.
    /// To reset the entire cache parameter group, specify the <code>ResetAllParameters</code>
    /// and <code>CacheParameterGroupName</code> parameters.
    /// </summary>
    public partial class ResetCacheParameterGroupRequest : AmazonElastiCacheRequest
    {
        private string _cacheParameterGroupName;
        private List<ParameterNameValue> _parameterNameValues = new List<ParameterNameValue>();
        private bool? _resetAllParameters;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResetCacheParameterGroupRequest() { }

        /// <summary>
        /// Instantiates ResetCacheParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheParameterGroupName">The name of the cache parameter group to reset.</param>
        /// <param name="parameterNameValues">An array of parameter names to reset to their default values. If <code>ResetAllParameters</code> is <code>true</code>, do not use <code>ParameterNameValues</code>. If <code>ResetAllParameters</code> is <code>false</code>, you must specify the name of at least one parameter to reset.</param>
        public ResetCacheParameterGroupRequest(string cacheParameterGroupName, List<ParameterNameValue> parameterNameValues)
        {
            _cacheParameterGroupName = cacheParameterGroupName;
            _parameterNameValues = parameterNameValues;
        }

        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to reset.
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
        /// An array of parameter names to reset to their default values. If <code>ResetAllParameters</code>
        /// is <code>true</code>, do not use <code>ParameterNameValues</code>. If <code>ResetAllParameters</code>
        /// is <code>false</code>, you must specify the name of at least one parameter to reset.
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

        /// <summary>
        /// Gets and sets the property ResetAllParameters. 
        /// <para>
        /// If <code>true</code>, all parameters in the cache parameter group are reset to their
        /// default values. If <code>false</code>, only the parameters listed by <code>ParameterNameValues</code>
        /// are reset to their default values.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool ResetAllParameters
        {
            get { return this._resetAllParameters.GetValueOrDefault(); }
            set { this._resetAllParameters = value; }
        }

        // Check to see if ResetAllParameters property is set
        internal bool IsSetResetAllParameters()
        {
            return this._resetAllParameters.HasValue; 
        }

    }
}