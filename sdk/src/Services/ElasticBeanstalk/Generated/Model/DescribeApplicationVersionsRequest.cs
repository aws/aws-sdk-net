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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplicationVersions operation.
    /// Retrieve a list of application versions.
    /// </summary>
    public partial class DescribeApplicationVersionsRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private int? _maxRecords;
        private string _nextToken;
        private List<string> _versionLabels = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeApplicationVersionsRequest() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Specify an application name to show only application versions for that application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// For a paginated request. Specify a maximum number of application versions to include
        /// in each response.
        /// </para>
        ///  
        /// <para>
        /// If no <c>MaxRecords</c> is specified, all available application versions are retrieved
        /// in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For a paginated request. Specify a token from a previous response page to retrieve
        /// the next response page. All other parameter values must be identical to the ones specified
        /// in the initial request.
        /// </para>
        ///  
        /// <para>
        /// If no <c>NextToken</c> is specified, the first page is retrieved.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLabels. 
        /// <para>
        /// Specify a version label to show a specific application version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VersionLabels
        {
            get { return this._versionLabels; }
            set { this._versionLabels = value; }
        }

        // Check to see if VersionLabels property is set
        internal bool IsSetVersionLabels()
        {
            return this._versionLabels != null && (this._versionLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}