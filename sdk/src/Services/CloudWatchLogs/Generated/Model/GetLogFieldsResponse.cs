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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the GetLogFields operation.
    /// </summary>
    public partial class GetLogFieldsResponse : AmazonWebServiceResponse
    {
        private List<LogFieldsListItem> _logFields = AWSConfigs.InitializeCollections ? new List<LogFieldsListItem>() : null;

        /// <summary>
        /// Gets and sets the property LogFields. 
        /// <para>
        /// The list of log fields for the specified data source, including field names and their
        /// data types.
        /// </para>
        /// </summary>
        public List<LogFieldsListItem> LogFields
        {
            get { return this._logFields; }
            set { this._logFields = value; }
        }

        // Check to see if LogFields property is set
        internal bool IsSetLogFields()
        {
            return this._logFields != null && (this._logFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}