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
    /// This is the response object from the DescribeRegistrationAttachments operation.
    /// </summary>
    public partial class DescribeRegistrationAttachmentsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RegistrationAttachmentsInformation> _registrationAttachments = AWSConfigs.InitializeCollections ? new List<RegistrationAttachmentsInformation>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. You don't need to supply
        /// a value for this field in the initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationAttachments. 
        /// <para>
        /// An array of <b>RegistrationAttachments</b> objects that contain the details for the
        /// requested registration attachments. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RegistrationAttachmentsInformation> RegistrationAttachments
        {
            get { return this._registrationAttachments; }
            set { this._registrationAttachments = value; }
        }

        // Check to see if RegistrationAttachments property is set
        internal bool IsSetRegistrationAttachments()
        {
            return this._registrationAttachments != null && (this._registrationAttachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}