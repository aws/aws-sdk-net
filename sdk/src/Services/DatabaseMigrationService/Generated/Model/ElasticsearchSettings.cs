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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines an OpenSearch endpoint.
    /// </summary>
    public partial class ElasticsearchSettings
    {
        private string _endpointUri;
        private int? _errorRetryDuration;
        private int? _fullLoadErrorPercentage;
        private string _serviceAccessRoleArn;
        private bool? _useNewMappingType;

        /// <summary>
        /// Gets and sets the property EndpointUri. 
        /// <para>
        /// The endpoint for the OpenSearch cluster. DMS uses HTTPS if a transport protocol (http/https)
        /// is not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The maximum number of seconds for which DMS retries failed API requests to the OpenSearch
        /// cluster.
        /// </para>
        /// </summary>
        public int? ErrorRetryDuration
        {
            get { return this._errorRetryDuration; }
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
        ///  
        /// <para>
        /// To avoid early failure, this counter is only effective after 1000 records are transferred.
        /// OpenSearch also has the concept of error monitoring during the last 10 minutes of
        /// an Observation Window. If transfer of all records fail in the last 10 minutes, the
        /// full load operation stops. 
        /// </para>
        /// </summary>
        public int? FullLoadErrorPercentage
        {
            get { return this._fullLoadErrorPercentage; }
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
        /// The Amazon Resource Name (ARN) used by the service to access the IAM role. The role
        /// must allow the <c>iam:PassRole</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UseNewMappingType. 
        /// <para>
        /// Set this option to <c>true</c> for DMS to migrate documentation using the documentation
        /// type <c>_doc</c>. OpenSearch and an Elasticsearch cluster only support the _doc documentation
        /// type in versions 7. x and later. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? UseNewMappingType
        {
            get { return this._useNewMappingType; }
            set { this._useNewMappingType = value; }
        }

        // Check to see if UseNewMappingType property is set
        internal bool IsSetUseNewMappingType()
        {
            return this._useNewMappingType.HasValue; 
        }

    }
}