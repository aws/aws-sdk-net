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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the configuration and any analyses for the analytics filter of an Amazon
    /// S3 bucket.
    /// </summary>
    public partial class AnalyticsConfiguration
    {
        private AnalyticsFilter _analyticsFilter;
        private string _analyticsId;
        private StorageClassAnalysis _storageClassAnalysis;

        /// <summary>
        /// Gets and sets the property AnalyticsFilter. 
        /// <para>
        /// The filter used to describe a set of objects for analyses. A filter must have exactly
        /// one prefix, one tag, or one conjunction (AnalyticsAndOperator). If no filter is provided,
        /// all objects will be considered in any analysis.
        /// </para>
        /// </summary>
        public AnalyticsFilter AnalyticsFilter
        {
            get { return this._analyticsFilter; }
            set { this._analyticsFilter = value; }
        }

        // Check to see if AnalyticsFilter property is set
        internal bool IsSetAnalyticsFilter()
        {
            return this._analyticsFilter != null;
        }

        /// <summary>
        /// Gets and sets the property AnalyticsId. 
        /// <para>
        /// The ID that identifies the analytics configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnalyticsId
        {
            get { return this._analyticsId; }
            set { this._analyticsId = value; }
        }

        // Check to see if AnalyticsId property is set
        internal bool IsSetAnalyticsId()
        {
            return this._analyticsId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClassAnalysis. 
        /// <para>
        ///  Contains data related to access patterns to be collected and made available to analyze
        /// the tradeoffs between different storage classes. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageClassAnalysis StorageClassAnalysis
        {
            get { return this._storageClassAnalysis; }
            set { this._storageClassAnalysis = value; }
        }

        // Check to see if StorageClassAnalysis property is set
        internal bool IsSetStorageClassAnalysis()
        {
            return this._storageClassAnalysis != null;
        }

    }
}