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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEnvironments operation.
    /// Returns descriptions for existing environments.
    /// </summary>
    public partial class DescribeEnvironmentsRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private List<string> _environmentIds = new List<string>();
        private List<string> _environmentNames = new List<string>();
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
        /// </summary>
        public List<string> EnvironmentIds
        {
            get { return this._environmentIds; }
            set { this._environmentIds = value; }
        }

        // Check to see if EnvironmentIds property is set
        internal bool IsSetEnvironmentIds()
        {
            return this._environmentIds != null && this._environmentIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentNames. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include
        /// only those that have the specified names.
        /// </para>
        /// </summary>
        public List<string> EnvironmentNames
        {
            get { return this._environmentNames; }
            set { this._environmentNames = value; }
        }

        // Check to see if EnvironmentNames property is set
        internal bool IsSetEnvironmentNames()
        {
            return this._environmentNames != null && this._environmentNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludedDeletedBackTo. 
        /// <para>
        ///  If specified when <code>IncludeDeleted</code> is set to <code>true</code>, then environments
        /// deleted after this date are displayed. 
        /// </para>
        /// </summary>
        public DateTime IncludedDeletedBackTo
        {
            get { return this._includedDeletedBackTo.GetValueOrDefault(); }
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
        ///  <code>true</code>: Environments that have been deleted after <code>IncludedDeletedBackTo</code>
        /// are displayed.
        /// </para>
        ///  
        /// <para>
        ///  <code>false</code>: Do not include deleted environments.
        /// </para>
        /// </summary>
        public bool IncludeDeleted
        {
            get { return this._includeDeleted.GetValueOrDefault(); }
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
        /// If no <code>MaxRecords</code> is specified, all available environments are retrieved
        /// in a single response.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
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
        /// If no <code>NextToken</code> is specified, the first page is retrieved.
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