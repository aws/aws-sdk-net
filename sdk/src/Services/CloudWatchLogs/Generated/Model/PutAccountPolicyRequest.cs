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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountPolicy operation.
    /// Creates an account-level data protection policy, subscription filter policy, field
    /// index policy, transformer policy, or metric extraction policy that applies to all
    /// log groups or a subset of log groups in the account.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must be signed on with the correct permissions depending
    /// on the type of policy that you are creating.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create a data protection policy, you must have the <c>logs:PutDataProtectionPolicy</c>
    /// and <c>logs:PutAccountPolicy</c> permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a subscription filter policy, you must have the <c>logs:PutSubscriptionFilter</c>
    /// and <c>logs:PutAccountPolicy</c> permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a transformer policy, you must have the <c>logs:PutTransformer</c> and <c>logs:PutAccountPolicy</c>
    /// permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a field index policy, you must have the <c>logs:PutIndexPolicy</c> and <c>logs:PutAccountPolicy</c>
    /// permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a metric extraction policy, you must have the <c>logs:PutMetricExtractionPolicy</c>
    /// and <c>logs:PutAccountPolicy</c> permissions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Data protection policy</b> 
    /// </para>
    ///  
    /// <para>
    /// A data protection policy can help safeguard sensitive data that's ingested by your
    /// log groups by auditing and masking the sensitive log data. Each account can have only
    /// one account-level data protection policy.
    /// </para>
    ///  <important> 
    /// <para>
    /// Sensitive data is detected and masked when it is ingested into a log group. When you
    /// set a data protection policy, log events ingested into the log groups before that
    /// time are not masked.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you use <c>PutAccountPolicy</c> to create a data protection policy for your whole
    /// account, it applies to both existing log groups and all log groups that are created
    /// later in this account. The account-level policy is applied to existing log groups
    /// with eventual consistency. It might take up to 5 minutes before sensitive data in
    /// existing log groups begins to be masked.
    /// </para>
    ///  
    /// <para>
    /// By default, when a user views a log event that includes masked data, the sensitive
    /// data is replaced by asterisks. A user who has the <c>logs:Unmask</c> permission can
    /// use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
    /// operation with the <c>unmask</c> parameter set to <c>true</c> to view the unmasked
    /// log events. Users with the <c>logs:Unmask</c> can also view unmasked data in the CloudWatch
    /// Logs console by running a CloudWatch Logs Insights query with the <c>unmask</c> query
    /// command.
    /// </para>
    ///  
    /// <para>
    /// For more information, including a list of types of data that can be audited and masked,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
    /// sensitive log data with masking</a>.
    /// </para>
    ///  
    /// <para>
    /// To use the <c>PutAccountPolicy</c> operation for a data protection policy, you must
    /// be signed on with the <c>logs:PutDataProtectionPolicy</c> and <c>logs:PutAccountPolicy</c>
    /// permissions.
    /// </para>
    ///  
    /// <para>
    /// The <c>PutAccountPolicy</c> operation applies to all log groups in the account. You
    /// can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html">PutDataProtectionPolicy</a>
    /// to create a data protection policy that applies to just one log group. If a log group
    /// has its own data protection policy and the account also has an account-level data
    /// protection policy, then the two policies are cumulative. Any sensitive term specified
    /// in either policy is masked.
    /// </para>
    ///  
    /// <para>
    ///  <b>Subscription filter policy</b> 
    /// </para>
    ///  
    /// <para>
    /// A subscription filter policy sets up a real-time feed of log events from CloudWatch
    /// Logs to other Amazon Web Services services. Account-level subscription filter policies
    /// apply to both existing log groups and log groups that are created later in this account.
    /// Supported destinations are Kinesis Data Streams, Firehose, and Lambda. When log events
    /// are sent to the receiving service, they are Base64 encoded and compressed with the
    /// GZIP format.
    /// </para>
    ///  
    /// <para>
    /// The following destinations are supported for subscription filters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An Kinesis Data Streams data stream in the same account as the subscription policy,
    /// for same-account delivery.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An Firehose data stream in the same account as the subscription policy, for same-account
    /// delivery.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A Lambda function in the same account as the subscription policy, for same-account
    /// delivery.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A logical destination in a different account created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestination.html">PutDestination</a>,
    /// for cross-account delivery. Kinesis Data Streams and Firehose are supported as logical
    /// destinations.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each account can have one account-level subscription filter policy per Region. If
    /// you are updating an existing filter, you must specify the correct name in <c>PolicyName</c>.
    /// To perform a <c>PutAccountPolicy</c> subscription filter operation for any destination
    /// except a Lambda function, you must also have the <c>iam:PassRole</c> permission.
    /// </para>
    ///  
    /// <para>
    ///  <b>Transformer policy</b> 
    /// </para>
    ///  
    /// <para>
    /// Creates or updates a <i>log transformer policy</i> for your account. You use log transformers
    /// to transform log events into a different format, making them easier for you to process
    /// and analyze. You can also transform logs from different sources into standardized
    /// formats that contain relevant, source-specific information. After you have created
    /// a transformer, CloudWatch Logs performs this transformation at the time of log ingestion.
    /// You can then refer to the transformed versions of the logs during operations such
    /// as querying with CloudWatch Logs Insights or creating metric filters or subscription
    /// filters.
    /// </para>
    ///  
    /// <para>
    /// You can also use a transformer to copy metadata from metadata keys into the log events
    /// themselves. This metadata can include log group name, log stream name, account ID
    /// and Region.
    /// </para>
    ///  
    /// <para>
    /// A transformer for a log group is a series of processors, where each processor applies
    /// one type of transformation to the log events ingested into this log group. For more
    /// information about the available processors to use in a transformer, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-Processors">
    /// Processors that you can use</a>.
    /// </para>
    ///  
    /// <para>
    /// Having log events in standardized format enables visibility across your applications
    /// for your log analysis, reporting, and alarming needs. CloudWatch Logs provides transformation
    /// for common log types with out-of-the-box transformation templates for major Amazon
    /// Web Services log sources such as VPC flow logs, Lambda, and Amazon RDS. You can use
    /// pre-built transformation templates or create custom transformation policies.
    /// </para>
    ///  
    /// <para>
    /// You can create transformers only for the log groups in the Standard log class.
    /// </para>
    ///  
    /// <para>
    /// You can have one account-level transformer policy that applies to all log groups in
    /// the account. Or you can create as many as 20 account-level transformer policies that
    /// are each scoped to a subset of log groups with the <c>selectionCriteria</c> parameter.
    /// If you have multiple account-level transformer policies with selection criteria, no
    /// two of them can use the same or overlapping log group name prefixes. For example,
    /// if you have one policy filtered to log groups that start with <c>my-log</c>, you can't
    /// have another field index policy filtered to <c>my-logpprod</c> or <c>my-logging</c>.
    /// </para>
    ///  
    /// <para>
    /// CloudWatch Logs provides default field indexes for all log groups in the Standard
    /// log class. Default field indexes are automatically available for the following fields:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>@aws.region</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>@aws.account</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>@source.log</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>traceId</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Default field indexes are in addition to any custom field indexes you define within
    /// your policy. Default field indexes are not counted towards your field index quota.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can also set up a transformer at the log-group level. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutTransformer.html">PutTransformer</a>.
    /// If there is both a log-group level transformer created with <c>PutTransformer</c>
    /// and an account-level transformer that could apply to the same log group, the log group
    /// uses only the log-group level transformer. It ignores the account-level transformer.
    /// </para>
    ///  
    /// <para>
    ///  <b>Field index policy</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use field index policies to create indexes on fields found in log events in
    /// the log group. Creating field indexes can help lower the scan volume for CloudWatch
    /// Logs Insights queries that reference those fields, because these queries attempt to
    /// skip the processing of log events that are known to not match the indexed field. Good
    /// fields to index are fields that you often need to query for and fields or values that
    /// match only a small fraction of the total log events. Common examples of indexes include
    /// request ID, session ID, user IDs, or instance IDs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
    /// field indexes to improve query performance and reduce costs</a> 
    /// </para>
    ///  
    /// <para>
    /// To find the fields that are in your log group events, use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogGroupFields.html">GetLogGroupFields</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For example, suppose you have created a field index for <c>requestId</c>. Then, any
    /// CloudWatch Logs Insights query on that log group that includes <c>requestId = <i>value</i>
    /// </c> or <c>requestId in [<i>value</i>, <i>value</i>, ...]</c> will attempt to process
    /// only the log events where the indexed field matches the specified value.
    /// </para>
    ///  
    /// <para>
    /// Matches of log events to the names of indexed fields are case-sensitive. For example,
    /// an indexed field of <c>RequestId</c> won't match a log event containing <c>requestId</c>.
    /// </para>
    ///  
    /// <para>
    /// You can have one account-level field index policy that applies to all log groups in
    /// the account. Or you can create as many as 20 account-level field index policies that
    /// are each scoped to a subset of log groups with the <c>selectionCriteria</c> parameter.
    /// If you have multiple account-level index policies with selection criteria, no two
    /// of them can use the same or overlapping log group name prefixes. For example, if you
    /// have one policy filtered to log groups that start with <c>my-log</c>, you can't have
    /// another field index policy filtered to <c>my-logpprod</c> or <c>my-logging</c>.
    /// </para>
    ///  
    /// <para>
    /// If you create an account-level field index policy in a monitoring account in cross-account
    /// observability, the policy is applied only to the monitoring account and not to any
    /// source accounts.
    /// </para>
    ///  
    /// <para>
    /// If you want to create a field index policy for a single log group, you can use <a
    /// href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>
    /// instead of <c>PutAccountPolicy</c>. If you do so, that log group will use only that
    /// log-group level policy, and will ignore the account-level policy that you create with
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Metric extraction policy</b> 
    /// </para>
    ///  
    /// <para>
    /// A metric extraction policy controls whether CloudWatch Metrics can be created through
    /// the Embedded Metrics Format (EMF) for log groups in your account. By default, EMF
    /// metric creation is enabled for all log groups. You can use metric extraction policies
    /// to disable EMF metric creation for your entire account or specific log groups.
    /// </para>
    ///  
    /// <para>
    /// When a policy disables EMF metric creation for a log group, log events in the EMF
    /// format are still ingested, but no CloudWatch Metrics are created from them.
    /// </para>
    ///  <important> 
    /// <para>
    /// Creating a policy disables metrics for AWS features that use EMF to create metrics,
    /// such as CloudWatch Container Insights and CloudWatch Application Signals. To prevent
    /// turning off those features by accident, we recommend that you exclude the underlying
    /// log-groups through a selection-criteria such as <c>LogGroupNamePrefix NOT IN ["/aws/containerinsights",
    /// "/aws/ecs/containerinsights", "/aws/application-signals/data"]</c>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Each account can have either one account-level metric extraction policy that applies
    /// to all log groups, or up to 5 policies that are each scoped to a subset of log groups
    /// with the <c>selectionCriteria</c> parameter. The selection criteria supports filtering
    /// by <c>LogGroupName</c> and <c>LogGroupNamePrefix</c> using the operators <c>IN</c>
    /// and <c>NOT IN</c>. You can specify up to 50 values in each <c>IN</c> or <c>NOT IN</c>
    /// list.
    /// </para>
    ///  
    /// <para>
    /// The selection criteria can be specified in these formats:
    /// </para>
    ///  
    /// <para>
    ///  <c>LogGroupName IN ["log-group-1", "log-group-2"]</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>LogGroupNamePrefix NOT IN ["/aws/prefix1", "/aws/prefix2"]</c> 
    /// </para>
    ///  
    /// <para>
    /// If you have multiple account-level metric extraction policies with selection criteria,
    /// no two of them can have overlapping criteria. For example, if you have one policy
    /// with selection criteria <c>LogGroupNamePrefix IN ["my-log"]</c>, you can't have another
    /// metric extraction policy with selection criteria <c>LogGroupNamePrefix IN ["/my-log-prod"]</c>
    /// or <c>LogGroupNamePrefix IN ["/my-logging"]</c>, as the set of log groups matching
    /// these prefixes would be a subset of the log groups matching the first policy's prefix,
    /// creating an overlap.
    /// </para>
    ///  
    /// <para>
    /// When using <c>NOT IN</c>, only one policy with this operator is allowed per account.
    /// </para>
    ///  
    /// <para>
    /// When combining policies with <c>IN</c> and <c>NOT IN</c> operators, the overlap check
    /// ensures that policies don't have conflicting effects. Two policies with <c>IN</c>
    /// and <c>NOT IN</c> operators do not overlap if and only if every value in the <c>IN
    /// </c>policy is completely contained within some value in the <c>NOT IN</c> policy.
    /// For example:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you have a <c>NOT IN</c> policy for prefix <c>"/aws/lambda"</c>, you can create
    /// an <c>IN</c> policy for the exact log group name <c>"/aws/lambda/function1"</c> because
    /// the set of log groups matching <c>"/aws/lambda/function1"</c> is a subset of the log
    /// groups matching <c>"/aws/lambda"</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you have a <c>NOT IN</c> policy for prefix <c>"/aws/lambda"</c>, you cannot create
    /// an <c>IN</c> policy for prefix <c>"/aws"</c> because the set of log groups matching
    /// <c>"/aws"</c> is not a subset of the log groups matching <c>"/aws/lambda"</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutAccountPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _policyDocument;
        private string _policyName;
        private PolicyType _policyType;
        private Scope _scope;
        private string _selectionCriteria;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// Specify the policy, in JSON.
        /// </para>
        ///  
        /// <para>
        ///  <b>Data protection policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A data protection policy must include two JSON blocks:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The first block must include both a <c>DataIdentifer</c> array and an <c>Operation</c>
        /// property with an <c>Audit</c> action. The <c>DataIdentifer</c> array lists the types
        /// of sensitive data that you want to mask. For more information about the available
        /// options, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data-types.html">Types
        /// of data that you can mask</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>Operation</c> property with an <c>Audit</c> action is required to find the
        /// sensitive data terms. This <c>Audit</c> action must contain a <c>FindingsDestination</c>
        /// object. You can optionally use that <c>FindingsDestination</c> object to list one
        /// or more destinations to send audit findings to. If you specify destinations such as
        /// log groups, Firehose streams, and S3 buckets, they must already exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The second block must include both a <c>DataIdentifer</c> array and an <c>Operation</c>
        /// property with an <c>Deidentify</c> action. The <c>DataIdentifer</c> array must exactly
        /// match the <c>DataIdentifer</c> array in the first block of the policy.
        /// </para>
        ///  
        /// <para>
        /// The <c>Operation</c> property with the <c>Deidentify</c> action is what actually masks
        /// the data, and it must contain the <c> "MaskConfig": {}</c> object. The <c> "MaskConfig":
        /// {}</c> object must be empty.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an example data protection policy, see the <b>Examples</b> section on this page.
        /// </para>
        ///  <important> 
        /// <para>
        /// The contents of the two <c>DataIdentifer</c> arrays must match exactly.
        /// </para>
        ///  </important> 
        /// <para>
        /// In addition to the two JSON blocks, the <c>policyDocument</c> can also include <c>Name</c>,
        /// <c>Description</c>, and <c>Version</c> fields. The <c>Name</c> is different than the
        /// operation's <c>policyName</c> parameter, and is used as a dimension when CloudWatch
        /// Logs reports audit findings metrics to CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// The JSON specified in <c>policyDocument</c> can be up to 30,720 characters long.
        /// </para>
        ///  
        /// <para>
        ///  <b>Subscription filter policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A subscription filter policy can include the following attributes in a JSON block:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>DestinationArn</b> The ARN of the destination to deliver log events to. Supported
        /// destinations are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Kinesis Data Streams data stream in the same account as the subscription policy,
        /// for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Firehose data stream in the same account as the subscription policy, for same-account
        /// delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Lambda function in the same account as the subscription policy, for same-account
        /// delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A logical destination in a different account created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestination.html">PutDestination</a>,
        /// for cross-account delivery. Kinesis Data Streams and Firehose are supported as logical
        /// destinations.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>RoleArn</b> The ARN of an IAM role that grants CloudWatch Logs permissions to
        /// deliver ingested log events to the destination stream. You don't need to provide the
        /// ARN when you are working with a logical destination for cross-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FilterPattern</b> A filter pattern for subscribing to a filtered stream of log
        /// events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Distribution</b> The method used to distribute log data to the destination. By
        /// default, log data is grouped by log stream, but the grouping can be set to <c>Random</c>
        /// for a more even distribution. This property is only applicable when the destination
        /// is an Kinesis Data Streams data stream.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Transformer policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A transformer policy must include one JSON block with the array of processors and
        /// their configurations. For more information about available processors, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-Processors">
        /// Processors that you can use</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Field index policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A field index filter policy can include the following attribute in a JSON block:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Fields</b> The array of field indexes to create.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// It must contain at least one field index.
        /// </para>
        ///  
        /// <para>
        /// The following is an example of an index policy document that creates two indexes,
        /// <c>RequestId</c> and <c>TransactionId</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>"policyDocument": "{ \"Fields\": [ \"RequestId\", \"TransactionId\" ] }"</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// A name for the policy. This must be unique within the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy that you're creating or updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Currently the only valid value for this parameter is <c>ALL</c>, which specifies that
        /// the data protection policy applies to all log groups in the account. If you omit this
        /// parameter, the default of <c>ALL</c> is used.
        /// </para>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property SelectionCriteria. 
        /// <para>
        /// Use this parameter to apply the new policy to a subset of log groups in the account.
        /// </para>
        ///  
        /// <para>
        /// Specifying <c>selectionCriteria</c> is valid only when you specify <c>SUBSCRIPTION_FILTER_POLICY</c>,
        /// <c>FIELD_INDEX_POLICY</c> or <c>TRANSFORMER_POLICY</c>for <c>policyType</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>policyType</c> is <c>SUBSCRIPTION_FILTER_POLICY</c>, the only supported <c>selectionCriteria</c>
        /// filter is <c>LogGroupName NOT IN []</c> 
        /// </para>
        ///  
        /// <para>
        /// If <c>policyType</c> is <c>FIELD_INDEX_POLICY</c> or <c>TRANSFORMER_POLICY</c>, the
        /// only supported <c>selectionCriteria</c> filter is <c>LogGroupNamePrefix</c> 
        /// </para>
        ///  
        /// <para>
        /// The <c>selectionCriteria</c> string can be up to 25KB in length. The length is determined
        /// by using its UTF-8 bytes.
        /// </para>
        ///  
        /// <para>
        /// Using the <c>selectionCriteria</c> parameter with <c>SUBSCRIPTION_FILTER_POLICY</c>
        /// is useful to help prevent infinite loops. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Subscriptions-recursion-prevention.html">Log
        /// recursion prevention</a>.
        /// </para>
        /// </summary>
        public string SelectionCriteria
        {
            get { return this._selectionCriteria; }
            set { this._selectionCriteria = value; }
        }

        // Check to see if SelectionCriteria property is set
        internal bool IsSetSelectionCriteria()
        {
            return this._selectionCriteria != null;
        }

    }
}