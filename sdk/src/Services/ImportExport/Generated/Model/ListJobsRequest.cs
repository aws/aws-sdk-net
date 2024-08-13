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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
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
namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobs operation.
    /// This operation returns the jobs associated with the requester. AWS Import/Export lists
    /// the jobs in reverse chronological order based on the date of creation. For example
    /// if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation
    /// would return Test2 followed by Test1.
    /// </summary>
    public partial class ListJobsRequest : AmazonImportExportRequest
    {
        private string _apiVersion;
        private string _marker;
        private int? _maxJobs;

        /// <summary>
        /// Gets and sets the property APIVersion.
        /// </summary>
        public string APIVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }

        // Check to see if APIVersion property is set
        internal bool IsSetAPIVersion()
        {
            return this._apiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Marker.
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

        /// <summary>
        /// Gets and sets the property MaxJobs.
        /// </summary>
        public int? MaxJobs
        {
            get { return this._maxJobs; }
            set { this._maxJobs = value; }
        }

        // Check to see if MaxJobs property is set
        internal bool IsSetMaxJobs()
        {
            return this._maxJobs.HasValue; 
        }

    }
}