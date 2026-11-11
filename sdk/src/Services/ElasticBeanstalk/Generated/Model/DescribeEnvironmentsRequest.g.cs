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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeEnvironments operation. Returns descriptions
    /// for existing environments. <para> This action only returns information about environments
    /// that the calling principle has IAM permissions to access. For example, consider a
    /// case where a user only has permission to access one of three environments. When the
    /// user calls the <i>DescribeEnvironments</i> action, the response will only include
    /// the one environment that the user has permission to access instead of all three environments.
    /// If the user doesn’t have access to any of the environments an empty result is returned.
    /// </para> <note> <para> The <a href="https://docs.aws.amazon.com/aws-managed-policy/latest/reference/AWSElasticBeanstalkReadOnly.html">AWSElasticBeanstalkReadOnly</a>
    /// managed policy allows operators to view information about resources related to Elastic
    /// Beanstalk environments. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html">
    /// Managing Elastic Beanstalk user policies</a> in the <i>Elastic Beanstalk Developer
    /// Guide</i>. For detailed instructions to attach a policy to a user or group, see the
    /// section <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#iam-userpolicies-managed">
    /// Controlling access with managed policies</a> in the same topic. </para> </note>
    /// </summary>
    public partial class DescribeEnvironmentsRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeEnvironmentsRequest() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to include only
        /// those that are associated with this application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIds. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to include only
        /// those that have the specified IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnvironmentIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentIds property is set.
        /// </summary>
        internal bool IsSetEnvironmentIds() => this.EnvironmentIds != null && (this.EnvironmentIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentNames. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to include only
        /// those that have the specified names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnvironmentNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentNames property is set.
        /// </summary>
        internal bool IsSetEnvironmentNames() => this.EnvironmentNames != null && (this.EnvironmentNames.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public bool? IncludeDeleted { get; set; }

        /// <summary>
        /// Checks to see if the IncludeDeleted property is set.
        /// </summary>
        internal bool IsSetIncludeDeleted() => this.IncludeDeleted.HasValue;

        /// <summary>
        /// Gets and sets the property IncludedDeletedBackTo. 
        /// <para>
        ///  If specified when <c>IncludeDeleted</c> is set to <c>true</c>, then environments
        /// deleted after this date are displayed. 
        /// </para>
        /// </summary>
        public DateTime? IncludedDeletedBackTo { get; set; }

        /// <summary>
        /// Checks to see if the IncludedDeletedBackTo property is set.
        /// </summary>
        internal bool IsSetIncludedDeletedBackTo() => this.IncludedDeletedBackTo.HasValue;

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
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

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
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to include only
        /// those that are associated with this application version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
