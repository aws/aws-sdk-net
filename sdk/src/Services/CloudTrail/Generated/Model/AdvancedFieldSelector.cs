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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A single selector statement in an advanced event selector.
    /// </summary>
    public partial class AdvancedFieldSelector
    {
        private List<string> _endsWith = new List<string>();
        private List<string> _equals = new List<string>();
        private string _field;
        private List<string> _notEndsWith = new List<string>();
        private List<string> _notEquals = new List<string>();
        private List<string> _notStartsWith = new List<string>();
        private List<string> _startsWith = new List<string>();

        /// <summary>
        /// Gets and sets the property EndsWith. 
        /// <para>
        /// An operator that includes events that match the last few characters of the event record
        /// field specified as the value of <code>Field</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> EndsWith
        {
            get { return this._endsWith; }
            set { this._endsWith = value; }
        }

        // Check to see if EndsWith property is set
        internal bool IsSetEndsWith()
        {
            return this._endsWith != null && this._endsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        ///  An operator that includes events that match the exact value of the event record field
        /// specified as the value of <code>Field</code>. This is the only valid operator that
        /// you can use with the <code>readOnly</code>, <code>eventCategory</code>, and <code>resources.type</code>
        /// fields.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null && this._equals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        ///  A field in a CloudTrail event record on which to filter events to be logged. For
        /// event data stores for Config configuration items, Audit Manager evidence, or non-Amazon
        /// Web Services events, the field is used only for selecting events as filtering is not
        /// supported. 
        /// </para>
        ///  
        /// <para>
        ///  For CloudTrail event records, supported fields include <code>readOnly</code>, <code>eventCategory</code>,
        /// <code>eventSource</code> (for management events), <code>eventName</code>, <code>resources.type</code>,
        /// and <code>resources.ARN</code>. 
        /// </para>
        ///  
        /// <para>
        ///  For event data stores for Config configuration items, Audit Manager evidence, or
        /// non-Amazon Web Services events, the only supported field is <code>eventCategory</code>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>readOnly</code> </b> - Optional. Can be set to <code>Equals</code> a value
        /// of <code>true</code> or <code>false</code>. If you do not add this field, CloudTrail
        /// logs both <code>read</code> and <code>write</code> events. A value of <code>true</code>
        /// logs only <code>read</code> events. A value of <code>false</code> logs only <code>write</code>
        /// events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>eventSource</code> </b> - For filtering management events only. This can
        /// be set only to <code>NotEquals</code> <code>kms.amazonaws.com</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>eventName</code> </b> - Can use any operator. You can use it to ﬁlter in
        /// or ﬁlter out any data event logged to CloudTrail, such as <code>PutBucket</code> or
        /// <code>GetSnapshotBlock</code>. You can have multiple values for this ﬁeld, separated
        /// by commas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>eventCategory</code> </b> - This is required and must be set to <code>Equals</code>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For CloudTrail event records, the value must be <code>Management</code> or <code>Data</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For Config configuration items, the value must be <code>ConfigurationItem</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For Audit Manager evidence, the value must be <code>Evidence</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For non-Amazon Web Services events, the value must be <code>ActivityAuditLog</code>.
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <code>resources.type</code> </b> - This ﬁeld is required for CloudTrail data
        /// events. <code>resources.type</code> can only use the <code>Equals</code> operator,
        /// and the value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS::CloudTrail::Channel</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::S3::Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::Lambda::Function</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::DynamoDB::Table</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::S3Outposts::Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::ManagedBlockchain::Node</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::S3ObjectLambda::AccessPoint</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::EC2::Snapshot</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::S3::AccessPoint</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::DynamoDB::Stream</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::Glue::Table</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::FinSpace::Environment</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::SageMaker::ExperimentTrialComponent</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::SageMaker::FeatureGroup</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  You can have only one <code>resources.type</code> ﬁeld per selector. To log data
        /// events on more than one resource type, add another selector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>resources.ARN</code> </b> - You can use any operator with <code>resources.ARN</code>,
        /// but if you use <code>Equals</code> or <code>NotEquals</code>, the value must exactly
        /// match the ARN of a valid resource of the type you've speciﬁed in the template as the
        /// value of resources.type. For example, if resources.type equals <code>AWS::S3::Object</code>,
        /// the ARN must be in one of the following formats. To log all data events for all objects
        /// in a specific S3 bucket, use the <code>StartsWith</code> operator, and include only
        /// the bucket ARN as the matching value.
        /// </para>
        ///  
        /// <para>
        /// The trailing slash is intentional; do not exclude it. Replace the text between less
        /// than and greater than symbols (&lt;&gt;) with resource-specific information. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;/</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;/&lt;object_path&gt;/</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::S3::AccessPoint</code>, and the
        /// operator is set to <code>Equals</code> or <code>NotEquals</code>, the ARN must be
        /// in one of the following formats. To log events on all objects in an S3 access point,
        /// we recommend that you use only the access point ARN, don’t include the object path,
        /// and use the <code>StartsWith</code> or <code>NotStartsWith</code> operators.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:s3:&lt;region&gt;:&lt;account_ID&gt;:accesspoint/&lt;access_point_name&gt;</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:s3:&lt;region&gt;:&lt;account_ID&gt;:accesspoint/&lt;access_point_name&gt;/object/&lt;object_path&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <code>AWS::Lambda::Function</code>, and the operator is
        /// set to <code>Equals</code> or <code>NotEquals</code>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:lambda:&lt;region&gt;:&lt;account_ID&gt;:function:&lt;function_name&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <code>AWS::DynamoDB::Table</code>, and the operator is
        /// set to <code>Equals</code> or <code>NotEquals</code>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:dynamodb:&lt;region&gt;:&lt;account_ID&gt;:table/&lt;table_name&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <code>AWS::CloudTrail::Channel</code>, and the operator
        /// is set to <code>Equals</code> or <code>NotEquals</code>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:cloudtrail:&lt;region&gt;:&lt;account_ID&gt;:channel/&lt;channel_UUID&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::S3Outposts::Object</code>, and
        /// the operator is set to <code>Equals</code> or <code>NotEquals</code>, the ARN must
        /// be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:s3-outposts:&lt;region&gt;:&lt;account_ID&gt;:&lt;object_path&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::ManagedBlockchain::Node</code>,
        /// and the operator is set to <code>Equals</code> or <code>NotEquals</code>, the ARN
        /// must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:managedblockchain:&lt;region&gt;:&lt;account_ID&gt;:nodes/&lt;node_ID&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::S3ObjectLambda::AccessPoint</code>,
        /// and the operator is set to <code>Equals</code> or <code>NotEquals</code>, the ARN
        /// must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:s3-object-lambda:&lt;region&gt;:&lt;account_ID&gt;:accesspoint/&lt;access_point_name&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::EC2::Snapshot</code>, and the operator
        /// is set to <code>Equals</code> or <code>NotEquals</code>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:ec2:&lt;region&gt;::snapshot/&lt;snapshot_ID&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::DynamoDB::Stream</code>, and the
        /// operator is set to <code>Equals</code> or <code>NotEquals</code>, the ARN must be
        /// in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:dynamodb:&lt;region&gt;:&lt;account_ID&gt;:table/&lt;table_name&gt;/stream/&lt;date_time&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::Glue::Table</code>, and the operator
        /// is set to <code>Equals</code> or <code>NotEquals</code>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:glue:&lt;region&gt;:&lt;account_ID&gt;:table/&lt;database_name&gt;/&lt;table_name&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::FinSpace::Environment</code>, and
        /// the operator is set to <code>Equals</code> or <code>NotEquals</code>, the ARN must
        /// be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:finspace:&lt;region&gt;:&lt;account_ID&gt;:environment/&lt;environment_ID&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::SageMaker::ExperimentTrialComponent</code>,
        /// and the operator is set to <code>Equals</code> or <code>NotEquals</code>, the ARN
        /// must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:sagemaker:&lt;region&gt;:&lt;account_ID&gt;:experiment-trial-component/&lt;experiment_trial_component_name&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>resources.type</code> equals <code>AWS::SageMaker::FeatureGroup</code>,
        /// and the operator is set to <code>Equals</code> or <code>NotEquals</code>, the ARN
        /// must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:&lt;partition&gt;:sagemaker:&lt;region&gt;:&lt;account_ID&gt;:feature-group/&lt;feature_group_name&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property NotEndsWith. 
        /// <para>
        ///  An operator that excludes events that match the last few characters of the event
        /// record field specified as the value of <code>Field</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotEndsWith
        {
            get { return this._notEndsWith; }
            set { this._notEndsWith = value; }
        }

        // Check to see if NotEndsWith property is set
        internal bool IsSetNotEndsWith()
        {
            return this._notEndsWith != null && this._notEndsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        ///  An operator that excludes events that match the exact value of the event record field
        /// specified as the value of <code>Field</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotEquals
        {
            get { return this._notEquals; }
            set { this._notEquals = value; }
        }

        // Check to see if NotEquals property is set
        internal bool IsSetNotEquals()
        {
            return this._notEquals != null && this._notEquals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotStartsWith. 
        /// <para>
        ///  An operator that excludes events that match the first few characters of the event
        /// record field specified as the value of <code>Field</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotStartsWith
        {
            get { return this._notStartsWith; }
            set { this._notStartsWith = value; }
        }

        // Check to see if NotStartsWith property is set
        internal bool IsSetNotStartsWith()
        {
            return this._notStartsWith != null && this._notStartsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartsWith. 
        /// <para>
        /// An operator that includes events that match the first few characters of the event
        /// record field specified as the value of <code>Field</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> StartsWith
        {
            get { return this._startsWith; }
            set { this._startsWith = value; }
        }

        // Check to see if StartsWith property is set
        internal bool IsSetStartsWith()
        {
            return this._startsWith != null && this._startsWith.Count > 0; 
        }

    }
}