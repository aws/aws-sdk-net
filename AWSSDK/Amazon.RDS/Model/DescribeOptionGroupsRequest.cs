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
    /// Container for the parameters to the DescribeOptionGroups operation.
    /// <p>
    /// Describes the available option groups.
    /// </p>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeOptionGroups"/>
    public class DescribeOptionGroupsRequest : AmazonWebServiceRequest
    {
        private string optionGroupName;
        private string marker;
        private int? maxRecords;
        private string engineName;
        private string majorEngineVersion;

        /// <summary>
        /// The name of the option group to describe. Cannot be supplied together with EngineName or MajorEngineVersion.
        ///  
        /// </summary>
        public string OptionGroupName
        {
            get { return this.optionGroupName; }
            set { this.optionGroupName = value; }
        }

        /// <summary>
        /// Sets the OptionGroupName property
        /// </summary>
        /// <param name="optionGroupName">The value to set for the OptionGroupName property </param>
        /// <returns>this instance</returns>
        public DescribeOptionGroupsRequest WithOptionGroupName(string optionGroupName)
        {
            this.optionGroupName = optionGroupName;
            return this;
        }
            

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;       
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
        public DescribeOptionGroupsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
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
        public DescribeOptionGroupsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;       
        }

        /// <summary>
        /// Filters the list of option groups to only include groups associated with a specific database engine.
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
        public DescribeOptionGroupsRequest WithEngineName(string engineName)
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
        /// Filters the list of option groups to only include groups associated with a specific database engine version. If specified, then EngineName
        /// must also be specified.
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
        public DescribeOptionGroupsRequest WithMajorEngineVersion(string majorEngineVersion)
        {
            this.majorEngineVersion = majorEngineVersion;
            return this;
        }
            

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this.majorEngineVersion != null;       
        }
    }
}
    
