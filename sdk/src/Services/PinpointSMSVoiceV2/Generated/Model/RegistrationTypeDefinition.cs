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
    /// Provides information on the supported registration type.
    /// </summary>
    public partial class RegistrationTypeDefinition
    {
        private RegistrationTypeDisplayHints _displayHints;
        private string _registrationType;
        private List<SupportedAssociation> _supportedAssociations = AWSConfigs.InitializeCollections ? new List<SupportedAssociation>() : null;

        /// <summary>
        /// Gets and sets the property DisplayHints. 
        /// <para>
        /// Provides help information on the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistrationTypeDisplayHints DisplayHints
        {
            get { return this._displayHints; }
            set { this._displayHints = value; }
        }

        // Check to see if DisplayHints property is set
        internal bool IsSetDisplayHints()
        {
            return this._displayHints != null;
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

        /// <summary>
        /// Gets and sets the property SupportedAssociations. 
        /// <para>
        /// The supported association behavior for the registration type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SupportedAssociation> SupportedAssociations
        {
            get { return this._supportedAssociations; }
            set { this._supportedAssociations = value; }
        }

        // Check to see if SupportedAssociations property is set
        internal bool IsSetSupportedAssociations()
        {
            return this._supportedAssociations != null && (this._supportedAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}