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
    /// Container for the parameters to the ResetCacheParameterGroup operation.
    /// <para>The <i>ResetCacheParameterGroup</i> operation modifies the parameters of a cache parameter group to the engine or system default
    /// value. You can reset specific parameters by submitting a list of parameter names. To reset the entire cache parameter group, specify the
    /// <i>ResetAllParameters</i> and <i>CacheParameterGroupName</i> parameters.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ResetCacheParameterGroup"/>
    public class ResetCacheParameterGroupRequest : AmazonWebServiceRequest
    {
        private string cacheParameterGroupName;
        private bool? resetAllParameters;
        private List<ParameterNameValue> parameterNameValues = new List<ParameterNameValue>();

        /// <summary>
        /// The name of the cache parameter group to reset.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResetCacheParameterGroupRequest WithCacheParameterGroupName(string cacheParameterGroupName)
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
        /// If <i>true</i>, all parameters in the cache parameter group will be reset to default values. If <i>false</i>, no such action occurs. Valid
        /// values: <c>true</c> | <c>false</c>
        ///  
        /// </summary>
        public bool ResetAllParameters
        {
            get { return this.resetAllParameters ?? default(bool); }
            set { this.resetAllParameters = value; }
        }

        /// <summary>
        /// Sets the ResetAllParameters property
        /// </summary>
        /// <param name="resetAllParameters">The value to set for the ResetAllParameters property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResetCacheParameterGroupRequest WithResetAllParameters(bool resetAllParameters)
        {
            this.resetAllParameters = resetAllParameters;
            return this;
        }
            

        // Check to see if ResetAllParameters property is set
        internal bool IsSetResetAllParameters()
        {
            return this.resetAllParameters.HasValue;
        }

        /// <summary>
        /// An array of parameter names to be reset. If you are not resetting the entire cache parameter group, you must specify at least one parameter
        /// name.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResetCacheParameterGroupRequest WithParameterNameValues(params ParameterNameValue[] parameterNameValues)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResetCacheParameterGroupRequest WithParameterNameValues(IEnumerable<ParameterNameValue> parameterNameValues)
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
    
