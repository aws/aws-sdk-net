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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the PutRegistrationFieldValue operation.
    /// </summary>
    public partial class PutRegistrationFieldValueResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FieldPath. 
        /// <para>
        /// The path to the registration form field. You can use <a>DescribeRegistrationFieldDefinitions</a>
        /// for a list of <b>FieldPaths</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string FieldPath { get; set; }

        /// <summary>
        /// Checks to see if the FieldPath property is set.
        /// </summary>
        internal bool IsSetFieldPath() => this.FieldPath != null;

        /// <summary>
        /// Gets and sets the property RegistrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistrationArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationArn property is set.
        /// </summary>
        internal bool IsSetRegistrationArn() => this.RegistrationArn != null;

        /// <summary>
        /// Gets and sets the property RegistrationAttachmentId. 
        /// <para>
        /// The unique identifier for the registration attachment.
        /// </para>
        /// </summary>
        public string RegistrationAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationAttachmentId property is set.
        /// </summary>
        internal bool IsSetRegistrationAttachmentId() => this.RegistrationAttachmentId != null;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;

        /// <summary>
        /// Gets and sets the property SelectChoices. 
        /// <para>
        /// An array of values for the form field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> SelectChoices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SelectChoices property is set.
        /// </summary>
        internal bool IsSetSelectChoices() => this.SelectChoices != null && (this.SelectChoices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TextValue. 
        /// <para>
        /// The text data for a free form field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TextValue { get; set; }

        /// <summary>
        /// Checks to see if the TextValue property is set.
        /// </summary>
        internal bool IsSetTextValue() => this.TextValue != null;

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100000)]
        public long? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;
    }
}
