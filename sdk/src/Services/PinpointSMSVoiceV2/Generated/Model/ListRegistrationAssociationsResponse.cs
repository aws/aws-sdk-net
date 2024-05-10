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
    /// This is the response object from the ListRegistrationAssociations operation.
    /// </summary>
    public partial class ListRegistrationAssociationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private string _registrationArn;
        private List<RegistrationAssociationMetadata> _registrationAssociations = AWSConfigs.InitializeCollections ? new List<RegistrationAssociationMetadata>() : null;
        private string _registrationId;
        private string _registrationType;

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
        /// Gets and sets the property RegistrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistrationArn
        {
            get { return this._registrationArn; }
            set { this._registrationArn = value; }
        }

        // Check to see if RegistrationArn property is set
        internal bool IsSetRegistrationArn()
        {
            return this._registrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationAssociations. 
        /// <para>
        /// An array of RegistrationAssociationMetadata objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RegistrationAssociationMetadata> RegistrationAssociations
        {
            get { return this._registrationAssociations; }
            set { this._registrationAssociations = value; }
        }

        // Check to see if RegistrationAssociations property is set
        internal bool IsSetRegistrationAssociations()
        {
            return this._registrationAssociations != null && (this._registrationAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistrationId
        {
            get { return this._registrationId; }
            set { this._registrationId = value; }
        }

        // Check to see if RegistrationId property is set
        internal bool IsSetRegistrationId()
        {
            return this._registrationId != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationType. 
        /// <para>
        /// The type of registration form. The list of <b>RegistrationTypes</b> can be found using
        /// the <a>DescribeRegistrationTypeDefinitions</a> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RegistrationType
        {
            get { return this._registrationType; }
            set { this._registrationType = value; }
        }

        // Check to see if RegistrationType property is set
        internal bool IsSetRegistrationType()
        {
            return this._registrationType != null;
        }

    }
}