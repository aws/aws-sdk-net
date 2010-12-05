/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBEngineVersions operation.
    /// 
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBEngineVersions"/>
    public class DescribeDBEngineVersionsRequest : AmazonWebServiceRequest
    {
        private string engine;
        private string engineVersion;
        private string dBParameterGroupFamily;
        private int? maxRecords;
        private string marker;
        private bool? defaultOnly;
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">The value to set for the Engine property </param>
        /// <returns>this instance</returns>
        public DescribeDBEngineVersionsRequest WithEngine(string engine)
        {
            this.engine = engine;
            return this;
        }
            
        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;         
        }
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        /// <summary>
        /// Sets the EngineVersion property
        /// </summary>
        /// <param name="engineVersion">The value to set for the EngineVersion property </param>
        /// <returns>this instance</returns>
        public DescribeDBEngineVersionsRequest WithEngineVersion(string engineVersion)
        {
            this.engineVersion = engineVersion;
            return this;
        }
            
        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;      
        }
        public string DBParameterGroupFamily
        {
            get { return this.dBParameterGroupFamily; }
            set { this.dBParameterGroupFamily = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupFamily property
        /// </summary>
        /// <param name="dBParameterGroupFamily">The value to set for the DBParameterGroupFamily property </param>
        /// <returns>this instance</returns>
        public DescribeDBEngineVersionsRequest WithDBParameterGroupFamily(string dBParameterGroupFamily)
        {
            this.dBParameterGroupFamily = dBParameterGroupFamily;
            return this;
        }
            
        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this.dBParameterGroupFamily != null;         
        }
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeDBEngineVersionsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            
        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;        
        }
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
        public DescribeDBEngineVersionsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            
        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;         
        }
        public bool DefaultOnly
        {
            get { return this.defaultOnly ?? default(bool); }
            set { this.defaultOnly = value; }
        }

        /// <summary>
        /// Sets the DefaultOnly property
        /// </summary>
        /// <param name="defaultOnly">The value to set for the DefaultOnly property </param>
        /// <returns>this instance</returns>
        public DescribeDBEngineVersionsRequest WithDefaultOnly(bool defaultOnly)
        {
            this.defaultOnly = defaultOnly;
            return this;
        }
            
        // Check to see if DefaultOnly property is set
        internal bool IsSetDefaultOnly()
        {
            return this.defaultOnly.HasValue;       
        }
    }
}
    
