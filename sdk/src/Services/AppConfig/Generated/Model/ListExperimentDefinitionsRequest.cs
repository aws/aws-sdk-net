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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the ListExperimentDefinitions operation.
    /// Lists the experiment definitions for an account. You can filter results by application,
    /// configuration profile, environment, or status.
    /// </summary>
    public partial class ListExperimentDefinitionsRequest : AmazonAppConfigRequest
    {
        private string _applicationIdentifier;
        private string _configurationProfileIdentifier;
        private string _environmentIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private ExperimentDefinitionStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The application ID or name to filter results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ApplicationIdentifier
        {
            get { return this._applicationIdentifier; }
            set { this._applicationIdentifier = value; }
        }

        // Check to see if ApplicationIdentifier property is set
        internal bool IsSetApplicationIdentifier()
        {
            return this._applicationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationProfileIdentifier. 
        /// <para>
        /// The configuration profile ID or name to filter results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ConfigurationProfileIdentifier
        {
            get { return this._configurationProfileIdentifier; }
            set { this._configurationProfileIdentifier = value; }
        }

        // Check to see if ConfigurationProfileIdentifier property is set
        internal bool IsSetConfigurationProfileIdentifier()
        {
            return this._configurationProfileIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The environment ID or name to filter results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list from a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A filter for the experiment definition status.
        /// </para>
        /// </summary>
        public ExperimentDefinitionStatus Status
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