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
    /// This is the response object from the BatchStartRecommendations operation.
    /// </summary>
    public partial class BatchStartRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<BatchStartRecommendationsErrorEntry> _errorEntries = new List<BatchStartRecommendationsErrorEntry>();

        /// <summary>
        /// Gets and sets the property ErrorEntries. 
        /// <para>
        /// A list with error details about the analysis of each source database.
        /// </para>
        /// </summary>
        public List<BatchStartRecommendationsErrorEntry> ErrorEntries
        {
            get { return this._errorEntries; }
            set { this._errorEntries = value; }
        }

        // Check to see if ErrorEntries property is set
        internal bool IsSetErrorEntries()
        {
            return this._errorEntries != null && this._errorEntries.Count > 0; 
        }

    }
}