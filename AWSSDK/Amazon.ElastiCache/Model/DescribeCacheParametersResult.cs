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
    /// <para>Represents the output of a <i>DescribeCacheParameters</i> operation.</para>
    /// </summary>
    public class DescribeCacheParametersResult
    {
        
        private string marker;
        private List<Parameter> parameters = new List<Parameter>();
        private List<CacheNodeTypeSpecificParameter> cacheNodeTypeSpecificParameters = new List<CacheNodeTypeSpecificParameter>();

        /// <summary>
        /// Provides an identifier to allow retrieval of paginated results.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheParametersResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of <a>Parameter</a> instances.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }
        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheParametersResult WithParameters(params Parameter[] parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheParametersResult WithParameters(IEnumerable<Parameter> parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

        /// <summary>
        /// A list of parameters specific to a particular cache node type. Each element in the list contains detailed information about one parameter.
        ///  
        /// </summary>
        public List<CacheNodeTypeSpecificParameter> CacheNodeTypeSpecificParameters
        {
            get { return this.cacheNodeTypeSpecificParameters; }
            set { this.cacheNodeTypeSpecificParameters = value; }
        }
        /// <summary>
        /// Adds elements to the CacheNodeTypeSpecificParameters collection
        /// </summary>
        /// <param name="cacheNodeTypeSpecificParameters">The values to add to the CacheNodeTypeSpecificParameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheParametersResult WithCacheNodeTypeSpecificParameters(params CacheNodeTypeSpecificParameter[] cacheNodeTypeSpecificParameters)
        {
            foreach (CacheNodeTypeSpecificParameter element in cacheNodeTypeSpecificParameters)
            {
                this.cacheNodeTypeSpecificParameters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheNodeTypeSpecificParameters collection
        /// </summary>
        /// <param name="cacheNodeTypeSpecificParameters">The values to add to the CacheNodeTypeSpecificParameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheParametersResult WithCacheNodeTypeSpecificParameters(IEnumerable<CacheNodeTypeSpecificParameter> cacheNodeTypeSpecificParameters)
        {
            foreach (CacheNodeTypeSpecificParameter element in cacheNodeTypeSpecificParameters)
            {
                this.cacheNodeTypeSpecificParameters.Add(element);
            }

            return this;
        }

        // Check to see if CacheNodeTypeSpecificParameters property is set
        internal bool IsSetCacheNodeTypeSpecificParameters()
        {
            return this.cacheNodeTypeSpecificParameters.Count > 0;
        }
    }
}
