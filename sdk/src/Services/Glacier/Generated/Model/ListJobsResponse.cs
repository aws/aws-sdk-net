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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains the Amazon S3 Glacier response to your request.
    /// </summary>
    public partial class ListJobsResponse : AmazonWebServiceResponse
    {
        private List<GlacierJobDescription> _jobList = AWSConfigs.InitializeCollections ? new List<GlacierJobDescription>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property JobList. 
        /// <para>
        /// A list of job objects. Each job object contains metadata describing the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlacierJobDescription> JobList
        {
            get { return this._jobList; }
            set { this._jobList = value; }
        }

        // Check to see if JobList property is set
        internal bool IsSetJobList()
        {
            return this._jobList != null && (this._jobList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An opaque string used for pagination that specifies the job at which the listing
        /// of jobs should begin. You get the <c>marker</c> value from a previous List Jobs response.
        /// You only need to include the marker if you are continuing the pagination of the results
        /// started in a previous List Jobs request. 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}