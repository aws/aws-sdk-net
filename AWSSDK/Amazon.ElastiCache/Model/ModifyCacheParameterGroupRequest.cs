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
    /// <para> Modifies the parameters of a CacheParameterGroup. To modify more than one parameter, submit a list of ParameterName and
    /// ParameterValue parameters. A maximum of 20 parameters can be modified in a single request. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheParameterGroup"/>
    public class ModifyCacheParameterGroupRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the CacheParameterGroupName property
        /// </summary>
        /// <param name="cacheParameterGroupName">The value to set for the CacheParameterGroupName property </param>
        /// <returns>this instance</returns>
        public ModifyCacheParameterGroupRequest WithCacheParameterGroupName(string cacheParameterGroupName)
        {
            this.cacheParameterGroupName = cacheParameterGroupName;
            return this;
        }
            

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this.cacheParameterGroupName != null;
        }

        /// <summary>
        /// An array of parameter names and values for the parameter update. At least one parameter name and value must be supplied; subsequent
        /// arguments are optional. A maximum of 20 parameters may be modified in a single request.
        ///  
        /// </summary>
        public List<ParameterNameValue> ParameterNameValues
        {
            get { return this.parameterNameValues; }
            set { this.parameterNameValues = value; }
        }
        /// <summary>
        /// Adds elements to the ParameterNameValues collection
        /// </summary>
        /// <param name="parameterNameValues">The values to add to the ParameterNameValues collection </param>
        /// <returns>this instance</returns>
        public ModifyCacheParameterGroupRequest WithParameterNameValues(params ParameterNameValue[] parameterNameValues)
        {
            foreach (ParameterNameValue element in parameterNameValues)
            {
                this.parameterNameValues.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ParameterNameValues collection
        /// </summary>
        /// <param name="parameterNameValues">The values to add to the ParameterNameValues collection </param>
        /// <returns>this instance</returns>
        public ModifyCacheParameterGroupRequest WithParameterNameValues(IEnumerable<ParameterNameValue> parameterNameValues)
        {
            foreach (ParameterNameValue element in parameterNameValues)
            {
                this.parameterNameValues.Add(element);
            }

            return this;
        }

        // Check to see if ParameterNameValues property is set
        internal bool IsSetParameterNameValues()
        {
            return this.parameterNameValues.Count > 0;
        }
    }
}
    
