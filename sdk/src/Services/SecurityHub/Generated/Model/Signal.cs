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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about the signals involved in an Amazon GuardDuty Extended Threat
    /// Detection attack sequence. An attack sequence is a type of threat detected by GuardDuty.
    /// GuardDuty generates an attack sequence finding when multiple events, or signals, align
    /// to a potentially suspicious activity. When GuardDuty and Security Hub are integrated,
    /// GuardDuty sends attack sequence findings to Security Hub.
    /// 
    ///  
    /// <para>
    /// A signal can be an API activity or a finding that GuardDuty uses to detect an attack
    /// sequence finding.
    /// </para>
    /// </summary>
    public partial class Signal
    {
        private List<string> _actorIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _count;
        private long? _createdAt;
        private List<string> _endpointIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _firstSeenAt;
        private string _id;
        private long? _lastSeenAt;
        private string _name;
        private string _productArn;
        private List<string> _resourceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _severity;
        private List<Indicator> _signalIndicators = AWSConfigs.InitializeCollections ? new List<Indicator>() : null;
        private string _title;
        private string _type;
        private long? _updatedAt;

        /// <summary>
        /// Gets and sets the property ActorIds. 
        /// <para>
        ///  The IDs of the threat actors involved in the signal. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ActorIds
        {
            get { return this._actorIds; }
            set { this._actorIds = value; }
        }

        // Check to see if ActorIds property is set
        internal bool IsSetActorIds()
        {
            return this._actorIds != null && (this._actorIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        ///  The number of times this signal was observed. 
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the first finding or activity related to this signal was observed.
        /// 
        /// </para>
        /// </summary>
        public long? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointIds. 
        /// <para>
        /// Information about the endpoint IDs associated with this signal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EndpointIds
        {
            get { return this._endpointIds; }
            set { this._endpointIds = value; }
        }

        // Check to see if EndpointIds property is set
        internal bool IsSetEndpointIds()
        {
            return this._endpointIds != null && (this._endpointIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FirstSeenAt. 
        /// <para>
        ///  The timestamp when the first finding or activity related to this signal was observed.
        /// 
        /// </para>
        /// </summary>
        public long? FirstSeenAt
        {
            get { return this._firstSeenAt; }
            set { this._firstSeenAt = value; }
        }

        // Check to see if FirstSeenAt property is set
        internal bool IsSetFirstSeenAt()
        {
            return this._firstSeenAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier of the signal. 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        ///  The timestamp when the last finding or activity related to this signal was observed.
        /// 
        /// </para>
        /// </summary>
        public long? LastSeenAt
        {
            get { return this._lastSeenAt; }
            set { this._lastSeenAt = value; }
        }

        // Check to see if LastSeenAt property is set
        internal bool IsSetLastSeenAt()
        {
            return this._lastSeenAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the GuardDuty signal. For example, when signal type is <c>FINDING</c>,
        /// the signal name is the name of the finding. 
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
        /// Gets and sets the property ProductArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the product that generated the signal. 
        /// </para>
        /// </summary>
        public string ProductArn
        {
            get { return this._productArn; }
            set { this._productArn = value; }
        }

        // Check to see if ProductArn property is set
        internal bool IsSetProductArn()
        {
            return this._productArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        ///  The ARN or ID of the Amazon Web Services resource associated with the signal. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && (this._resourceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity associated with the signal. For more information about severity, see
        /// <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_findings-severity.html">Severity
        /// levels for GuardDuty findings</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        /// </summary>
        public double? Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SignalIndicators. 
        /// <para>
        ///  Contains information about the indicators associated with the signals in this attack
        /// sequence finding. The values for <c>SignalIndicators</c> are a subset of the values
        /// for <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_Sequence.html">SequenceIndicators</a>,
        /// but the values for these fields don't always match 1:1. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<Indicator> SignalIndicators
        {
            get { return this._signalIndicators; }
            set { this._signalIndicators = value; }
        }

        // Check to see if SignalIndicators property is set
        internal bool IsSetSignalIndicators()
        {
            return this._signalIndicators != null && (this._signalIndicators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  The description of the GuardDuty finding. 
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the signal used to identify an attack sequence. 
        /// </para>
        ///  
        /// <para>
        /// Signals can be GuardDuty findings or activities observed in data sources that GuardDuty
        /// monitors. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_data-sources.html">GuardDuty
        /// foundational data sources</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A signal type can be one of the following values. Here are the related descriptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FINDING</c> - Individually generated GuardDuty finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLOUD_TRAIL</c> - Activity observed from CloudTrail logs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_DATA_EVENTS</c> - Activity observed from CloudTrail data events for Amazon
        /// Simple Storage Service (S3). Activities associated with this type will show up only
        /// when you have enabled GuardDuty S3 Protection feature in your account. For more information
        /// about S3 Protection and the steps to enable it, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/s3-protection.html">S3
        /// Protection</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when this signal was last observed. 
        /// </para>
        /// </summary>
        public long? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}