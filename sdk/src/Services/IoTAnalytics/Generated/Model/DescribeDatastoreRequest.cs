/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDatastore operation.
    /// Retrieves information about a data store.
    /// </summary>
    public partial class DescribeDatastoreRequest : AmazonIoTAnalyticsRequest
    {
        private string _datastoreName;
        private bool? _includeStatistics;

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The name of the data store
        /// </para>
        /// </summary>
        public string DatastoreName
        {
            get { return this._datastoreName; }
            set { this._datastoreName = value; }
        }

        // Check to see if DatastoreName property is set
        internal bool IsSetDatastoreName()
        {
            return this._datastoreName != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeStatistics. 
        /// <para>
        /// If true, include statistics about the data store in the response.
        /// </para>
        /// </summary>
        public bool IncludeStatistics
        {
            get { return this._includeStatistics.GetValueOrDefault(); }
            set { this._includeStatistics = value; }
        }

        // Check to see if IncludeStatistics property is set
        internal bool IsSetIncludeStatistics()
        {
            return this._includeStatistics.HasValue; 
        }

    }
}