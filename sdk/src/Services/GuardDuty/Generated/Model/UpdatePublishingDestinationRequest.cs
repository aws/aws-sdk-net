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
    /// Container for the parameters to the UpdatePublishingDestination operation.
    /// Updates information about the publishing destination specified by the <c>destinationId</c>.
    /// </summary>
    public partial class UpdatePublishingDestinationRequest : AmazonGuardDutyRequest
    {
        private string _destinationId;
        private DestinationProperties _destinationProperties;
        private string _detectorId;

        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the publishing destination to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationId
        {
            get { return this._destinationId; }
            set { this._destinationId = value; }
        }

        // Check to see if DestinationId property is set
        internal bool IsSetDestinationId()
        {
            return this._destinationId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationProperties. 
        /// <para>
        /// A <c>DestinationProperties</c> object that includes the <c>DestinationArn</c> and
        /// <c>KmsKeyArn</c> of the publishing destination.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector associated with the publishing destinations to update.
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