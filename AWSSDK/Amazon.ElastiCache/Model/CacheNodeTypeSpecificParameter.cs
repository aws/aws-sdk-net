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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>A parameter that has a different value for each cache node type it is applied to. For example, in a Redis cache cluster, a
    /// <i>cache.m1.large</i> cache node type would have a larger <i>maxmemory</i> value than a <i>cache.m1.small</i> type.</para>
    /// </summary>
    public class CacheNodeTypeSpecificParameter
    {
        
        private string parameterName;
        private string description;
        private string source;
        private string dataType;
        private string allowedValues;
        private bool? isModifiable;
        private string minimumEngineVersion;
        private List<CacheNodeTypeSpecificValue> cacheNodeTypeSpecificValues = new List<CacheNodeTypeSpecificValue>();

        /// <summary>
        /// The name of the parameter.
        ///  
        /// </summary>
        public string ParameterName
        {
            get { return this.parameterName; }
            set { this.parameterName = value; }
        }

        /// <summary>
        /// Sets the ParameterName property
        /// </summary>
        /// <param name="parameterName">The value to set for the ParameterName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithParameterName(string parameterName)
        {
            this.parameterName = parameterName;
            return this;
        }
            

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this.parameterName != null;
        }

        /// <summary>
        /// A description of the parameter.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The source of the parameter value.
        ///  
        /// </summary>
        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        /// <summary>
        /// Sets the Source property
        /// </summary>
        /// <param name="source">The value to set for the Source property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithSource(string source)
        {
            this.source = source;
            return this;
        }
            

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this.source != null;
        }

        /// <summary>
        /// The valid data type for the parameter.
        ///  
        /// </summary>
        public string DataType
        {
            get { return this.dataType; }
            set { this.dataType = value; }
        }

        /// <summary>
        /// Sets the DataType property
        /// </summary>
        /// <param name="dataType">The value to set for the DataType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithDataType(string dataType)
        {
            this.dataType = dataType;
            return this;
        }
            

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this.dataType != null;
        }

        /// <summary>
        /// The valid range of values for the parameter.
        ///  
        /// </summary>
        public string AllowedValues
        {
            get { return this.allowedValues; }
            set { this.allowedValues = value; }
        }

        /// <summary>
        /// Sets the AllowedValues property
        /// </summary>
        /// <param name="allowedValues">The value to set for the AllowedValues property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithAllowedValues(string allowedValues)
        {
            this.allowedValues = allowedValues;
            return this;
        }
            

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this.allowedValues != null;
        }

        /// <summary>
        /// Indicates whether (<c>true</c>) or not (<c>false</c>) the parameter can be modified. Some parameters have security or operational
        /// implications that prevent them from being changed.
        ///  
        /// </summary>
        public bool IsModifiable
        {
            get { return this.isModifiable ?? default(bool); }
            set { this.isModifiable = value; }
        }

        /// <summary>
        /// Sets the IsModifiable property
        /// </summary>
        /// <param name="isModifiable">The value to set for the IsModifiable property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithIsModifiable(bool isModifiable)
        {
            this.isModifiable = isModifiable;
            return this;
        }
            

        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this.isModifiable.HasValue;
        }

        /// <summary>
        /// The earliest cache engine version to which the parameter can apply.
        ///  
        /// </summary>
        public string MinimumEngineVersion
        {
            get { return this.minimumEngineVersion; }
            set { this.minimumEngineVersion = value; }
        }

        /// <summary>
        /// Sets the MinimumEngineVersion property
        /// </summary>
        /// <param name="minimumEngineVersion">The value to set for the MinimumEngineVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithMinimumEngineVersion(string minimumEngineVersion)
        {
            this.minimumEngineVersion = minimumEngineVersion;
            return this;
        }
            

        // Check to see if MinimumEngineVersion property is set
        internal bool IsSetMinimumEngineVersion()
        {
            return this.minimumEngineVersion != null;
        }

        /// <summary>
        /// A list of cache node types and their corresponding values for this parameter.
        ///  
        /// </summary>
        public List<CacheNodeTypeSpecificValue> CacheNodeTypeSpecificValues
        {
            get { return this.cacheNodeTypeSpecificValues; }
            set { this.cacheNodeTypeSpecificValues = value; }
        }
        /// <summary>
        /// Adds elements to the CacheNodeTypeSpecificValues collection
        /// </summary>
        /// <param name="cacheNodeTypeSpecificValues">The values to add to the CacheNodeTypeSpecificValues collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithCacheNodeTypeSpecificValues(params CacheNodeTypeSpecificValue[] cacheNodeTypeSpecificValues)
        {
            foreach (CacheNodeTypeSpecificValue element in cacheNodeTypeSpecificValues)
            {
                this.cacheNodeTypeSpecificValues.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheNodeTypeSpecificValues collection
        /// </summary>
        /// <param name="cacheNodeTypeSpecificValues">The values to add to the CacheNodeTypeSpecificValues collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNodeTypeSpecificParameter WithCacheNodeTypeSpecificValues(IEnumerable<CacheNodeTypeSpecificValue> cacheNodeTypeSpecificValues)
        {
            foreach (CacheNodeTypeSpecificValue element in cacheNodeTypeSpecificValues)
            {
                this.cacheNodeTypeSpecificValues.Add(element);
            }

            return this;
        }

        // Check to see if CacheNodeTypeSpecificValues property is set
        internal bool IsSetCacheNodeTypeSpecificValues()
        {
            return this.cacheNodeTypeSpecificValues.Count > 0;
        }
    }
}
