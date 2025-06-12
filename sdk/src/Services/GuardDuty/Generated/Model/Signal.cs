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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the signals involved in the attack sequence.
    /// </summary>
    public partial class Signal
    {
        private List<string> _actorIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _count;
        private DateTime? _createdAt;
        private string _description;
        private List<string> _endpointIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _firstSeenAt;
        private DateTime? _lastSeenAt;
        private string _name;
        private List<string> _resourceUids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _severity;
        private List<Indicator> _signalIndicators = AWSConfigs.InitializeCollections ? new List<Indicator>() : null;
        private SignalType _type;
        private string _uid;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ActorIds. 
        /// <para>
        /// Information about the IDs of the threat actors involved in the signal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
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
        /// The number of times this signal was observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The timestamp when the first finding or activity related to this signal was observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
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
        [AWSProperty(Max=400)]
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
        /// The timestamp when the first finding or activity related to this signal was observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? FirstSeenAt
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
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        /// The timestamp when the last finding or activity related to this signal was observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastSeenAt
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
        /// The name of the signal. For example, when signal type is <c>FINDING</c>, the signal
        /// name is the name of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ResourceUids. 
        /// <para>
        /// Information about the unique identifiers of the resources involved in the signal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
        public List<string> ResourceUids
        {
            get { return this._resourceUids; }
            set { this._resourceUids = value; }
        }

        // Check to see if ResourceUids property is set
        internal bool IsSetResourceUids()
        {
            return this._resourceUids != null && (this._resourceUids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity associated with the signal. For more information about severity, see
        /// <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_findings-severity.html">Findings
        /// severity levels</a> in the <i>Amazon GuardDuty User Guide</i>.
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
        /// Contains information about the indicators associated with the signals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the signal used to identify an attack sequence.
        /// </para>
        ///  
        /// <para>
        /// Signals can be GuardDuty findings or activities observed in data sources that GuardDuty
        /// monitors. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_data-sources.html">Foundational
        /// data sources</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A signal type can be one of the valid values listed in this API. Here are the related
        /// descriptions:
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
        ///  <c>S3_DATA_EVENTS</c> - Activity observed from CloudTrail data events for S3. Activities
        /// associated with this type will show up only when you have enabled GuardDuty S3 Protection
        /// feature in your account. For more information about S3 Protection and steps to enable
        /// it, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/s3-protection.html">S3
        /// Protection</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SignalType Type
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
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier of the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when this signal was last observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
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