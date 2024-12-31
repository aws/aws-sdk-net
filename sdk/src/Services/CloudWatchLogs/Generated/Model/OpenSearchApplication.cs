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
    /// This structure contains information about the OpenSearch Service application used
    /// for this integration. An OpenSearch Service application is the web application created
    /// by the integration with CloudWatch Logs. It hosts the vended logs dashboards.
    /// </summary>
    public partial class OpenSearchApplication
    {
        private string _applicationArn;
        private string _applicationEndpoint;
        private string _applicationId;
        private OpenSearchResourceStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application.
        /// </para>
        /// </summary>
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationEndpoint. 
        /// <para>
        /// The endpoint of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ApplicationEndpoint
        {
            get { return this._applicationEndpoint; }
            set { this._applicationEndpoint = value; }
        }

        // Check to see if ApplicationEndpoint property is set
        internal bool IsSetApplicationEndpoint()
        {
            return this._applicationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This structure contains information about the status of this OpenSearch Service resource.
        /// </para>
        /// </summary>
        public OpenSearchResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}