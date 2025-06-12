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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the CreateVerifiedDestinationNumber operation.
    /// </summary>
    public partial class CreateVerifiedDestinationNumberResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private string _destinationPhoneNumber;
        private VerificationStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _verifiedDestinationNumberArn;
        private string _verifiedDestinationNumberId;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the verified phone number was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber. 
        /// <para>
        /// The verified destination phone number, in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string DestinationPhoneNumber
        {
            get { return this._destinationPhoneNumber; }
            set { this._destinationPhoneNumber = value; }
        }

        // Check to see if DestinationPhoneNumber property is set
        internal bool IsSetDestinationPhoneNumber()
        {
            return this._destinationPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the verified destination phone number.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The phone number hasn't been verified yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VERIFIED</c>: The phone number is verified and can receive messages.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public VerificationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags (key and value pairs) to associate with the destination number.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VerifiedDestinationNumberArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the verified destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedDestinationNumberArn
        {
            get { return this._verifiedDestinationNumberArn; }
            set { this._verifiedDestinationNumberArn = value; }
        }

        // Check to see if VerifiedDestinationNumberArn property is set
        internal bool IsSetVerifiedDestinationNumberArn()
        {
            return this._verifiedDestinationNumberArn != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedDestinationNumberId. 
        /// <para>
        /// The unique identifier for the verified destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedDestinationNumberId
        {
            get { return this._verifiedDestinationNumberId; }
            set { this._verifiedDestinationNumberId = value; }
        }

        // Check to see if VerifiedDestinationNumberId property is set
        internal bool IsSetVerifiedDestinationNumberId()
        {
            return this._verifiedDestinationNumberId != null;
        }

    }
}