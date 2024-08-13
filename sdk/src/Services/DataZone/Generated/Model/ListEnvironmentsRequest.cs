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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListEnvironments operation.
    /// Lists Amazon DataZone environments.
    /// </summary>
    public partial class ListEnvironmentsRequest : AmazonDataZoneRequest
    {
        private string _awsAccountId;
        private string _awsAccountRegion;
        private string _domainIdentifier;
        private string _environmentBlueprintIdentifier;
        private string _environmentProfileIdentifier;
        private int? _maxResults;
        private string _name;
        private string _nextToken;
        private string _projectIdentifier;
        private string _provider;
        private EnvironmentStatus _status;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account where you want to list environments.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountRegion. 
        /// <para>
        /// The Amazon Web Services region where you want to list environments.
        /// </para>
        /// </summary>
        public string AwsAccountRegion
        {
            get { return this._awsAccountRegion; }
            set { this._awsAccountRegion = value; }
        }

        // Check to see if AwsAccountRegion property is set
        internal bool IsSetAwsAccountRegion()
        {
            return this._awsAccountRegion != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone blueprint.
        /// </para>
        /// </summary>
        public string EnvironmentBlueprintIdentifier
        {
            get { return this._environmentBlueprintIdentifier; }
            set { this._environmentBlueprintIdentifier = value; }
        }

        // Check to see if EnvironmentBlueprintIdentifier property is set
        internal bool IsSetEnvironmentBlueprintIdentifier()
        {
            return this._environmentBlueprintIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentProfileIdentifier. 
        /// <para>
        /// The identifier of the environment profile.
        /// </para>
        /// </summary>
        public string EnvironmentProfileIdentifier
        {
            get { return this._environmentProfileIdentifier; }
            set { this._environmentProfileIdentifier = value; }
        }

        // Check to see if EnvironmentProfileIdentifier property is set
        internal bool IsSetEnvironmentProfileIdentifier()
        {
            return this._environmentProfileIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of environments to return in a single call to <c>ListEnvironments</c>.
        /// When the number of environments to be listed is greater than the value of <c>MaxResults</c>,
        /// the response contains a <c>NextToken</c> value that you can use in a subsequent call
        /// to <c>ListEnvironments</c> to list the next set of environments.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of environments is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of environments, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>ListEnvironments</c>
        /// to list the next set of environments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectIdentifier
        {
            get { return this._projectIdentifier; }
            set { this._projectIdentifier = value; }
        }

        // Check to see if ProjectIdentifier property is set
        internal bool IsSetProjectIdentifier()
        {
            return this._projectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the environment.
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the environments that you want to list.
        /// </para>
        /// </summary>
        public EnvironmentStatus Status
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