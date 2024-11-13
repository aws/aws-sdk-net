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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A single selector statement in an advanced event selector.
    /// </summary>
    public partial class AdvancedFieldSelector
    {
        private List<string> _endsWith = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _equals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _field;
        private List<string> _notEndsWith = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notEquals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notStartsWith = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _startsWith = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EndsWith. 
        /// <para>
        /// An operator that includes events that match the last few characters of the event record
        /// field specified as the value of <c>Field</c>.
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
            return this._endsWith != null && (this._endsWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        ///  An operator that includes events that match the exact value of the event record field
        /// specified as the value of <c>Field</c>. This is the only valid operator that you can
        /// use with the <c>readOnly</c>, <c>eventCategory</c>, and <c>resources.type</c> fields.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public new List<string> Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null && (this._equals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        ///  A field in a CloudTrail event record on which to filter events to be logged. For
        /// event data stores for CloudTrail Insights events, Config configuration items, Audit
        /// Manager evidence, or events outside of Amazon Web Services, the field is used only
        /// for selecting events as filtering is not supported.
        /// </para>
        ///  
        /// <para>
        /// For CloudTrail management events, supported fields include <c>eventCategory</c> (required),
        /// <c>eventSource</c>, and <c>readOnly</c>. The following additional fields are available
        /// for event data stores: <c>eventName</c>, <c>eventType</c>, <c>sessionCredentialFromConsole</c>,
        /// and <c>userIdentity.arn</c>.
        /// </para>
        ///  
        /// <para>
        /// For CloudTrail data events, supported fields include <c>eventCategory</c> (required),
        /// <c>resources.type</c> (required), <c>eventName</c>, <c>readOnly</c>, and <c>resources.ARN</c>.
        /// The following additional fields are available for event data stores: <c>eventSource</c>,
        /// <c>eventType</c>, <c>sessionCredentialFromConsole</c>, and <c>userIdentity.arn</c>.
        /// </para>
        ///  
        /// <para>
        /// For CloudTrail network activity events, supported fields include <c>eventCategory</c>
        /// (required), <c>eventSource</c> (required), <c>eventName</c>, <c>errorCode</c>, and
        /// <c>vpcEndpointId</c>.
        /// </para>
        ///  
        /// <para>
        ///  For event data stores for CloudTrail Insights events, Config configuration items,
        /// Audit Manager evidence, or events outside of Amazon Web Services, the only supported
        /// field is <c>eventCategory</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>readOnly</c> </b> - This is an optional field that is only used for management
        /// events and data events. This field can be set to <c>Equals</c> with a value of <c>true</c>
        /// or <c>false</c>. If you do not add this field, CloudTrail logs both <c>read</c> and
        /// <c>write</c> events. A value of <c>true</c> logs only <c>read</c> events. A value
        /// of <c>false</c> logs only <c>write</c> events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>eventSource</c> </b> - This field is only used for management events, data
        /// events (for event data stores only), and network activity events.
        /// </para>
        ///  
        /// <para>
        /// For management events for trails, this is an optional field that can be set to <c>NotEquals</c>
        /// <c>kms.amazonaws.com</c> to exclude KMS management events, or <c>NotEquals</c> <c>rdsdata.amazonaws.com</c>
        /// to exclude RDS management events.
        /// </para>
        ///  
        /// <para>
        /// For management and data events for event data stores, you can use it to include or
        /// exclude any event source and can use any operator.
        /// </para>
        ///  
        /// <para>
        /// For network activity events, this is a required field that only uses the <c>Equals</c>
        /// operator. Set this field to the event source for which you want to log network activity
        /// events. If you want to log network activity events for multiple event sources, you
        /// must create a separate field selector for each event source.
        /// </para>
        ///  
        /// <para>
        /// The following are valid values for network activity events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>cloudtrail.amazonaws.com</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2.amazonaws.com</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kms.amazonaws.com</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secretsmanager.amazonaws.com</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>eventName</c> </b> - This is an optional field that is only used for data
        /// events, management events (for event data stores only), and network activity events.
        /// You can use any operator with <c>eventName</c>. You can use it to ﬁlter in or ﬁlter
        /// out specific events. You can have multiple values for this ﬁeld, separated by commas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>eventCategory</c> </b> - This field is required and must be set to <c>Equals</c>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For CloudTrail management events, the value must be <c>Management</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For CloudTrail data events, the value must be <c>Data</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For CloudTrail network activity events, the value must be <c>NetworkActivity</c>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are used only for event data stores:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For CloudTrail Insights events, the value must be <c>Insight</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For Config configuration items, the value must be <c>ConfigurationItem</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For Audit Manager evidence, the value must be <c>Evidence</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For events outside of Amazon Web Services, the value must be <c>ActivityAuditLog</c>.
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>eventType</c> </b> - This is an optional field available only for event data
        /// stores, which is used to filter management and data events on the event type. For
        /// information about available event types, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-event-reference-record-contents.html#ct-event-type">CloudTrail
        /// record contents</a> in the <i>CloudTrail user guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>errorCode</c> </b> - This ﬁeld is only used to filter CloudTrail network activity
        /// events and is optional. This is the error code to filter on. Currently, the only valid
        /// <c>errorCode</c> is <c>VpceAccessDenied</c>. <c>errorCode</c> can only use the <c>Equals</c>
        /// operator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>sessionCredentialFromConsole</c> </b> - This is an optional field available
        /// only for event data stores, which is used to filter management and data events based
        /// on whether the events originated from an Amazon Web Services Management Console session.
        /// <c>sessionCredentialFromConsole</c> can only use the <c>Equals</c> and <c>NotEquals</c>
        /// operators.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>resources.type</c> </b> - This ﬁeld is required for CloudTrail data events.
        /// <c>resources.type</c> can only use the <c>Equals</c> operator.
        /// </para>
        ///  
        /// <para>
        /// For a list of available resource types for data events, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html#logging-data-events">Data
        /// events</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  You can have only one <c>resources.type</c> ﬁeld per selector. To log events on more
        /// than one resource type, add another selector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>resources.ARN</c> </b> - The <c>resources.ARN</c> is an optional field for
        /// data events. You can use any operator with <c>resources.ARN</c>, but if you use <c>Equals</c>
        /// or <c>NotEquals</c>, the value must exactly match the ARN of a valid resource of the
        /// type you've speciﬁed in the template as the value of resources.type. To log all data
        /// events for all objects in a specific S3 bucket, use the <c>StartsWith</c> operator,
        /// and include only the bucket ARN as the matching value.
        /// </para>
        ///  
        /// <para>
        /// For information about filtering data events on the <c>resources.ARN</c> field, see
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/filtering-data-events.html#filtering-data-events-resourcearn">Filtering
        /// data events by resources.ARN</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't use the <c>resources.ARN</c> field to filter resource types that do not
        /// have ARNs.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <c>userIdentity.arn</c> </b> - This is an optional field available only for event
        /// data stores, which is used to filter management and data events on the userIdentity
        /// ARN. You can use any operator with <c>userIdentity.arn</c>. For more information on
        /// the userIdentity element, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-event-reference-user-identity.html">CloudTrail
        /// userIdentity element</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>vpcEndpointId</c> </b> - This ﬁeld is only used to filter CloudTrail network
        /// activity events and is optional. This field identifies the VPC endpoint that the request
        /// passed through. You can use any operator with <c>vpcEndpointId</c>.
        /// </para>
        ///  </li> </ul>
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
        /// record field specified as the value of <c>Field</c>. 
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
            return this._notEndsWith != null && (this._notEndsWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        ///  An operator that excludes events that match the exact value of the event record field
        /// specified as the value of <c>Field</c>. 
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
            return this._notEquals != null && (this._notEquals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotStartsWith. 
        /// <para>
        ///  An operator that excludes events that match the first few characters of the event
        /// record field specified as the value of <c>Field</c>. 
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
            return this._notStartsWith != null && (this._notStartsWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartsWith. 
        /// <para>
        /// An operator that includes events that match the first few characters of the event
        /// record field specified as the value of <c>Field</c>.
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
            return this._startsWith != null && (this._startsWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}