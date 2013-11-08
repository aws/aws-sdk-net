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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents the output of a <i>DescribeEngineDefaultParameters</i> operation.</para>
    /// </summary>
    public partial class EngineDefaults : AmazonWebServiceResponse
    {
        
        private string cacheParameterGroupFamily;
        private string marker;
        private List<Parameter> parameters = new List<Parameter>();
        private List<CacheNodeTypeSpecificParameter> cacheNodeTypeSpecificParameters = new List<CacheNodeTypeSpecificParameter>();


        /// <summary>
        /// Specifies the name of the cache parameter group family to which the engine default parameters apply.
        ///  
        /// </summary>
        public string CacheParameterGroupFamily
        {
            get { return this.cacheParameterGroupFamily; }
            set { this.cacheParameterGroupFamily = value; }
        }

        // Check to see if CacheParameterGroupFamily property is set
        internal bool IsSetCacheParameterGroupFamily()
        {
            return this.cacheParameterGroupFamily != null;
        }

        /// <summary>
        /// Provides an identifier to allow retrieval of paginated results.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// Contains a list of engine default parameters.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
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

        // Check to see if CacheNodeTypeSpecificParameters property is set
        internal bool IsSetCacheNodeTypeSpecificParameters()
        {
            return this.cacheNodeTypeSpecificParameters.Count > 0;
        }
    }
}
