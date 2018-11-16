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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ElasticsearchSettings
    {
        private string _endpointUri;
        private int? _errorRetryDuration;
        private int? _fullLoadErrorPercentage;
        private string _serviceAccessRoleArn;

        /// <summary>
        /// Gets and sets the property EndpointUri. 
        /// <para>
        /// The endpoint for the ElasticSearch cluster.
        /// </para>
        /// </summary>
        public string EndpointUri
        {
            get { return this._endpointUri; }
            set { this._endpointUri = value; }
        }

        // Check to see if EndpointUri property is set
        internal bool IsSetEndpointUri()
        {
            return this._endpointUri != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorRetryDuration. 
        /// <para>
        /// The maximum number of seconds that DMS retries failed API requests to the Elasticsearch
        /// cluster.
        /// </para>
        /// </summary>
        public int ErrorRetryDuration
        {
            get { return this._errorRetryDuration.GetValueOrDefault(); }
            set { this._errorRetryDuration = value; }
        }

        // Check to see if ErrorRetryDuration property is set
        internal bool IsSetErrorRetryDuration()
        {
            return this._errorRetryDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadErrorPercentage. 
        /// <para>
        /// The maximum percentage of records that can fail to be written before a full load operation
        /// stops. 
        /// </para>
        /// </summary>
        public int FullLoadErrorPercentage
        {
            get { return this._fullLoadErrorPercentage.GetValueOrDefault(); }
            set { this._fullLoadErrorPercentage = value; }
        }

        // Check to see if FullLoadErrorPercentage property is set
        internal bool IsSetFullLoadErrorPercentage()
        {
            return this._fullLoadErrorPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) used by service to access the IAM role.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

    }
}