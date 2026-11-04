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
    /// Container for the parameters to the DescribeEvents operation. Returns list of event
    /// descriptions matching criteria up to the last 6 weeks. <para> This action returns
    /// the most recent 1,000 events from the specified <c>NextToken</c>. </para> <para> This
    /// action only returns information about resources that the calling principle has IAM
    /// permissions to access. For example, consider a case where a user only has permission
    /// to access one of three resources. When the user calls the this action, the response
    /// will only include the one resource that the user has permission to access instead
    /// of all three resources. If the user doesn’t have access to any of the resources an
    /// empty result is returned. </para> <note> <para> The <a href="https://docs.aws.amazon.com/aws-managed-policy/latest/reference/AWSElasticBeanstalkReadOnly.html">AWSElasticBeanstalkReadOnly</a>
    /// managed policy allows operators to view information about resources related to Elastic
    /// Beanstalk. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html">
    /// Managing Elastic Beanstalk user policies</a> in the <i>Elastic Beanstalk Developer
    /// Guide</i>. For detailed instructions to attach a policy to a user or group, see the
    /// section <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#iam-userpolicies-managed">
    /// Controlling access with managed policies</a> in the same topic. </para> </note>
    /// </summary>
    public partial class DescribeEventsRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeEventsRequest() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to include only
        /// those associated with this application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  If specified, Elastic Beanstalk restricts the returned descriptions to those that
        /// occur up to, but not including, the <c>EndTime</c>. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to those associated
        /// with this environment.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to those associated
        /// with this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// Specifies the maximum number of events that can be returned, beginning with the most
        /// recent event.
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
        /// Pagination token. If specified, the events return the next batch of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of a custom platform version. If specified, Elastic Beanstalk restricts the
        /// returned descriptions to those associated with this custom platform version.
        /// </para>
        /// </summary>
        public string PlatformArn { get; set; }

        /// <summary>
        /// Checks to see if the PlatformArn property is set.
        /// </summary>
        internal bool IsSetPlatformArn() => this.PlatformArn != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the described events to include only those
        /// associated with this request ID.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// If specified, limits the events returned from this call to include only those with
        /// the specified severity or higher.
        /// </para>
        /// </summary>
        public EventSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to those that
        /// occur on or after this time.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to those that
        /// are associated with this environment configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to those associated
        /// with this application version.
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
