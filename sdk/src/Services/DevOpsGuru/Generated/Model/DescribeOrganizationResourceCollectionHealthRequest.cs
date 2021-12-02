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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOrganizationResourceCollectionHealth operation.
    /// Provides an overview of your system's health. If additional member accounts are part
    /// of your organization, you can filter those accounts using the <code>AccountIds</code>
    /// field.
    /// </summary>
    public partial class DescribeOrganizationResourceCollectionHealthRequest : AmazonDevOpsGuruRequest
    {
        private List<string> _accountIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _organizationalUnitIds = new List<string>();
        private OrganizationResourceCollectionType _organizationResourceCollectionType;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The ID of the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If this value is null, it retrieves the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// The ID of the organizational unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> OrganizationalUnitIds
        {
            get { return this._organizationalUnitIds; }
            set { this._organizationalUnitIds = value; }
        }

        // Check to see if OrganizationalUnitIds property is set
        internal bool IsSetOrganizationalUnitIds()
        {
            return this._organizationalUnitIds != null && this._organizationalUnitIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationResourceCollectionType. 
        /// <para>
        ///  An Amazon Web Services resource collection type. This type specifies how analyzed
        /// Amazon Web Services resources are defined. The two types of Amazon Web Services resource
        /// collections supported are Amazon Web Services CloudFormation stacks and Amazon Web
        /// Services resources that contain the same Amazon Web Services tag. DevOps Guru can
        /// be configured to analyze the Amazon Web Services resources that are defined in the
        /// stacks or that are tagged using the same tag <i>key</i>. You can specify up to 500
        /// Amazon Web Services CloudFormation stacks. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationResourceCollectionType OrganizationResourceCollectionType
        {
            get { return this._organizationResourceCollectionType; }
            set { this._organizationResourceCollectionType = value; }
        }

        // Check to see if OrganizationResourceCollectionType property is set
        internal bool IsSetOrganizationResourceCollectionType()
        {
            return this._organizationResourceCollectionType != null;
        }

    }
}