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
    /// Container for the parameters to the DescribeEnvironments operation.
    /// Returns descriptions for existing environments.
    /// </summary>
    public partial class DescribeEnvironmentsRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private List<string> _environmentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _environmentNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _includedDeletedBackTo;
        private bool? _includeDeleted;
        private int? _maxRecords;
        private string _nextToken;
        private string _versionLabel;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeEnvironmentsRequest() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include
        /// only those that are associated with this application.
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
        /// Gets and sets the property EnvironmentIds. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include
        /// only those that have the specified IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnvironmentIds
        {
            get { return this._environmentIds; }
            set { this._environmentIds = value; }
        }

        // Check to see if EnvironmentIds property is set
        internal bool IsSetEnvironmentIds()
        {
            return this._environmentIds != null && (this._environmentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentNames. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include
        /// only those that have the specified names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnvironmentNames
        {
            get { return this._environmentNames; }
            set { this._environmentNames = value; }
        }

        // Check to see if EnvironmentNames property is set
        internal bool IsSetEnvironmentNames()
        {
            return this._environmentNames != null && (this._environmentNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludedDeletedBackTo. 
        /// <para>
        ///  If specified when <c>IncludeDeleted</c> is set to <c>true</c>, then environments
        /// deleted after this date are displayed. 
        /// </para>
        /// </summary>
        public DateTime? IncludedDeletedBackTo
        {
            get { return this._includedDeletedBackTo; }
            set { this._includedDeletedBackTo = value; }
        }

        // Check to see if IncludedDeletedBackTo property is set
        internal bool IsSetIncludedDeletedBackTo()
        {
            return this._includedDeletedBackTo.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeDeleted. 
        /// <para>
        /// Indicates whether to include deleted environments:
        /// </para>
        ///  
        /// <para>
        ///  <c>true</c>: Environments that have been deleted after <c>IncludedDeletedBackTo</c>
        /// are displayed.
        /// </para>
        ///  
        /// <para>
        ///  <c>false</c>: Do not include deleted environments.
        /// </para>
        /// </summary>
        public bool? IncludeDeleted
        {
            get { return this._includeDeleted; }
            set { this._includeDeleted = value; }
        }

        // Check to see if IncludeDeleted property is set
        internal bool IsSetIncludeDeleted()
        {
            return this._includeDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// For a paginated request. Specify a maximum number of environments to include in each
        /// response.
        /// </para>
        ///  
        /// <para>
        /// If no <c>MaxRecords</c> is specified, all available environments are retrieved in
        /// a single response.
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
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include
        /// only those that are associated with this application version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}