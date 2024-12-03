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
    /// Container for the parameters to the CreatePublishingDestination operation.
    /// Creates a publishing destination where you can export your GuardDuty findings. Before
    /// you start exporting the findings, the destination resource must exist.
    /// </summary>
    public partial class CreatePublishingDestinationRequest : AmazonGuardDutyRequest
    {
        private string _clientToken;
        private DestinationProperties _destinationProperties;
        private DestinationType _destinationType;
        private string _detectorId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationProperties. 
        /// <para>
        /// The properties of the publishing destination, including the ARNs for the destination
        /// and the KMS key used for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationProperties DestinationProperties
        {
            get { return this._destinationProperties; }
            set { this._destinationProperties = value; }
        }

        // Check to see if DestinationProperties property is set
        internal bool IsSetDestinationProperties()
        {
            return this._destinationProperties != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of resource for the publishing destination. Currently only Amazon S3 buckets
        /// are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public DestinationType DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }

        // Check to see if DestinationType property is set
        internal bool IsSetDestinationType()
        {
            return this._destinationType != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the GuardDuty detector associated with the publishing destination.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

    }
}