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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
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
namespace Amazon.ApplicationCostProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the ImportApplicationUsage operation.
    /// Ingests application usage data from Amazon Simple Storage Service (Amazon S3).
    /// 
    ///  
    /// <para>
    /// The data must already exist in the S3 location. As part of the action, AWS Application
    /// Cost Profiler copies the object from your S3 bucket to an S3 bucket owned by Amazon
    /// for processing asynchronously.
    /// </para>
    /// </summary>
    public partial class ImportApplicationUsageRequest : AmazonApplicationCostProfilerRequest
    {
        private SourceS3Location _sources3Location;

        /// <summary>
        /// Gets and sets the property SourceS3Location. 
        /// <para>
        /// Amazon S3 location to import application usage data from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceS3Location SourceS3Location
        {
            get { return this._sources3Location; }
            set { this._sources3Location = value; }
        }

        // Check to see if SourceS3Location property is set
        internal bool IsSetSourceS3Location()
        {
            return this._sources3Location != null;
        }

    }
}