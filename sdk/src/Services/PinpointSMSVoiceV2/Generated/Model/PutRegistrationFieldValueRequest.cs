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
    /// Container for the parameters to the PutRegistrationFieldValue operation.
    /// Creates or updates a field value for a registration.
    /// </summary>
    public partial class PutRegistrationFieldValueRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _fieldPath;
        private string _registrationAttachmentId;
        private string _registrationId;
        private List<string> _selectChoices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _textValue;

        /// <summary>
        /// Gets and sets the property FieldPath. 
        /// <para>
        /// The path to the registration form field. You can use <a>DescribeRegistrationFieldDefinitions</a>
        /// for a list of <b>FieldPaths</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string FieldPath
        {
            get { return this._fieldPath; }
            set { this._fieldPath = value; }
        }

        // Check to see if FieldPath property is set
        internal bool IsSetFieldPath()
        {
            return this._fieldPath != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationAttachmentId. 
        /// <para>
        /// The unique identifier for the registration attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RegistrationAttachmentId
        {
            get { return this._registrationAttachmentId; }
            set { this._registrationAttachmentId = value; }
        }

        // Check to see if RegistrationAttachmentId property is set
        internal bool IsSetRegistrationAttachmentId()
        {
            return this._registrationAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property SelectChoices. 
        /// <para>
        /// An array of values for the form field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> SelectChoices
        {
            get { return this._selectChoices; }
            set { this._selectChoices = value; }
        }

        // Check to see if SelectChoices property is set
        internal bool IsSetSelectChoices()
        {
            return this._selectChoices != null && (this._selectChoices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TextValue. 
        /// <para>
        /// The text data for a free form field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TextValue
        {
            get { return this._textValue; }
            set { this._textValue = value; }
        }

        // Check to see if TextValue property is set
        internal bool IsSetTextValue()
        {
            return this._textValue != null;
        }

    }
}