/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;


namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for AnalyticsConfiguration
    /// </summary>
    public class AnalyticsConfiguration
    {
        private string analyticsId;
        private AnalyticsFilter analyticsFilter;
        private StorageClassAnalysis storageClassAnalysis;


        /// <summary>
        /// The filter used to describe a set of objects for analyses. 
        /// A filter must have exactly one prefix, one tag, or one conjunction (AnalyticsAndOperator).
        /// If no filter is provided, all objects will be considered in any analysis.
        /// </summary>
        public AnalyticsFilter AnalyticsFilter
        {
            get { return this.analyticsFilter; }
            set { this.analyticsFilter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetAnalyticsFilter()
        {
            return this.analyticsFilter != null;
        }

        /// <summary>
        /// The identifier used to represent an analytics configuration.
        /// </summary>
        [AWSProperty(Required = true)]
        public string AnalyticsId
        {
            get { return this.analyticsId; }
            set { this.analyticsId = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetAnalyticsId()
        {
            return !(string.IsNullOrEmpty(this.analyticsId));
        }

        /// <summary>
        /// If present, it indicates that data related to access patterns will be collected 
        /// and made available to analyze the tradeoffs between different storage classes.
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageClassAnalysis StorageClassAnalysis
        {
            get { return this.storageClassAnalysis; }
            set { this.storageClassAnalysis = value; }
        }

        // Check to see if StorageClassAnalysis property is set
        internal bool IsSetStorageClassAnalysis()
        {
            return this.storageClassAnalysis != null;
        }
    }
}
