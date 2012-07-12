/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeOptionGroupOptions operation.
    /// <para> Describes all available options. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeOptionGroupOptions"/>
    public class DescribeOptionGroupOptionsRequest : AmazonWebServiceRequest
    {
        private string engineName;
        private string majorEngineVersion;
        private int? maxRecords;
        private string marker;

        /// <summary>
        /// A required parameter. Options available for the given Engine name will be described.
        ///  
        /// </summary>
        public string EngineName
        {
            get { return this.engineName; }
            set { this.engineName = value; }
        }

        /// <summary>
        /// Sets the EngineName property
        /// </summary>
        /// <param name="engineName">The value to set for the EngineName property </param>
        /// <returns>this instance</returns>
        public DescribeOptionGroupOptionsRequest WithEngineName(string engineName)
        {
            this.engineName = engineName;
            return this;
        }
            

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this.engineName != null;       
        }

        /// <summary>
        /// If specified, filters the results to include only options for the specified major engine version.
        ///  
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this.majorEngineVersion; }
            set { this.majorEngineVersion = value; }
        }

        /// <summary>
        /// Sets the MajorEngineVersion property
        /// </summary>
        /// <param name="majorEngineVersion">The value to set for the MajorEngineVersion property </param>
        /// <returns>this instance</returns>
        public DescribeOptionGroupOptionsRequest WithMajorEngineVersion(string majorEngineVersion)
        {
            this.majorEngineVersion = majorEngineVersion;
            return this;
        }
            

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this.majorEngineVersion != null;       
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
        public DescribeOptionGroupOptionsRequest WithMaxRecords(int maxRecords)
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
        public DescribeOptionGroupOptionsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }
    }
}
    
