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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetCloudFormationStackRecords operation.
    /// </summary>
    public partial class GetCloudFormationStackRecordsResponse : AmazonWebServiceResponse
    {
        private List<CloudFormationStackRecord> _cloudFormationStackRecords = new List<CloudFormationStackRecord>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property CloudFormationStackRecords. 
        /// <para>
        /// A list of objects describing the CloudFormation stack records.
        /// </para>
        /// </summary>
        public List<CloudFormationStackRecord> CloudFormationStackRecords
        {
            get { return this._cloudFormationStackRecords; }
            set { this._cloudFormationStackRecords = value; }
        }

        // Check to see if CloudFormationStackRecords property is set
        internal bool IsSetCloudFormationStackRecords()
        {
            return this._cloudFormationStackRecords != null && this._cloudFormationStackRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// A token used for advancing to the next page of results of your get relational database
        /// bundles request.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}