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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchStartRecommendations operation.
    /// Starts the analysis of up to 20 source databases to recommend target engines for each
    /// source database. This is a batch version of <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartRecommendations.html">StartRecommendations</a>.
    /// 
    ///  
    /// <para>
    /// The result of analysis of each source database is reported individually in the response.
    /// Because the batch request can result in a combination of successful and unsuccessful
    /// actions, you should check for batch errors even when the call returns an HTTP status
    /// code of <code>200</code>.
    /// </para>
    /// </summary>
    public partial class BatchStartRecommendationsRequest : AmazonDatabaseMigrationServiceRequest
    {
        private List<StartRecommendationsRequestEntry> _data = new List<StartRecommendationsRequestEntry>();

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// Provides information about source databases to analyze. After this analysis, Fleet
        /// Advisor recommends target engines for each source database.
        /// </para>
        /// </summary>
        public List<StartRecommendationsRequestEntry> Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null && this._data.Count > 0; 
        }

    }
}