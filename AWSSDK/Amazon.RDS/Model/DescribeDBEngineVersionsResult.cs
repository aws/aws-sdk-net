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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> Contains the result of a successful invocation of the DescribeDBEngineVersions action. </para>
    /// </summary>
    public class DescribeDBEngineVersionsResult
    {
        
        private string marker;
        private List<DBEngineVersion> dBEngineVersions = new List<DBEngineVersion>();

        /// <summary>
        /// An optional pagination token provided by a previous request. If this parameter is specified, the response includes only records beyond the
        /// marker, up to the value specified by <c>MaxRecords</c>.
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
        public DescribeDBEngineVersionsResult WithMarker(string marker)
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
        /// A list of <c>DBEngineVersion</c> elements.
        ///  
        /// </summary>
        public List<DBEngineVersion> DBEngineVersions
        {
            get { return this.dBEngineVersions; }
            set { this.dBEngineVersions = value; }
        }
        /// <summary>
        /// Adds elements to the DBEngineVersions collection
        /// </summary>
        /// <param name="dBEngineVersions">The values to add to the DBEngineVersions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBEngineVersionsResult WithDBEngineVersions(params DBEngineVersion[] dBEngineVersions)
        {
            foreach (DBEngineVersion element in dBEngineVersions)
            {
                this.dBEngineVersions.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the DBEngineVersions collection
        /// </summary>
        /// <param name="dBEngineVersions">The values to add to the DBEngineVersions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBEngineVersionsResult WithDBEngineVersions(IEnumerable<DBEngineVersion> dBEngineVersions)
        {
            foreach (DBEngineVersion element in dBEngineVersions)
            {
                this.dBEngineVersions.Add(element);
            }

            return this;
        }

        // Check to see if DBEngineVersions property is set
        internal bool IsSetDBEngineVersions()
        {
            return this.dBEngineVersions.Count > 0;
        }
    }
}
