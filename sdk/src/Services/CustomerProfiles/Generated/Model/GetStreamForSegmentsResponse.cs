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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetStreamForSegments operation.
    /// </summary>
    public partial class GetStreamForSegmentsResponse : AmazonWebServiceResponse
    {
        private DateTime? _associatedAt;
        private List<AssociatedSegment> _associatedSegments = AWSConfigs.InitializeCollections ? new List<AssociatedSegment>() : null;
        private string _destinationArn;
        private string _destinationRoleArn;
        private DateTime? _disassociatedAt;
        private string _domainName;
        private string _failureReason;
        private EventSubscriptionState _state;

        /// <summary>
        /// Gets and sets the property AssociatedAt. 
        /// <para>
        /// The timestamp of when the stream was associated. 
        /// </para>
        /// </summary>
        public DateTime? AssociatedAt
        {
            get { return this._associatedAt; }
            set { this._associatedAt = value; }
        }

        // Check to see if AssociatedAt property is set
        internal bool IsSetAssociatedAt()
        {
            return this._associatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociatedSegments. 
        /// <para>
        /// A list of segments currently associated with the stream and their subscription status.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedSegment> AssociatedSegments
        {
            get { return this._associatedSegments; }
            set { this._associatedSegments = value; }
        }

        // Check to see if AssociatedSegments property is set
        internal bool IsSetAssociatedSegments()
        {
            return this._associatedSegments != null && (this._associatedSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis data stream receiving segment
        /// membership events. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used for Amazon Kinesis and AWS Key
        /// Management Service (KMS) operations. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string DestinationRoleArn
        {
            get { return this._destinationRoleArn; }
            set { this._destinationRoleArn = value; }
        }

        // Check to see if DestinationRoleArn property is set
        internal bool IsSetDestinationRoleArn()
        {
            return this._destinationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DisassociatedAt. 
        /// <para>
        /// The timestamp of when the stream was disassociated. 
        /// </para>
        /// </summary>
        public DateTime? DisassociatedAt
        {
            get { return this._disassociatedAt; }
            set { this._disassociatedAt = value; }
        }

        // Check to see if DisassociatedAt property is set
        internal bool IsSetDisassociatedAt()
        {
            return this._disassociatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why the stream is in an unhealthy state, if applicable. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The operational state of the destination stream. The following are valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RUNNING</b>: The stream is associated and healthy. Segment membership events are
        /// being published. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UNHEALTHY</b>: The stream is associated but events cannot currently be published.
        /// See <c>FailureReason</c> for details. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>STOPPED</b>: The stream is no longer publishing segment membership events. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EventSubscriptionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}