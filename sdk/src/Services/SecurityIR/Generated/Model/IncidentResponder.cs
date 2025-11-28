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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class IncidentResponder
    {
        private List<string> _communicationPreferences = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _email;
        private string _jobTitle;
        private string _name;

        /// <summary>
        /// Gets and sets the property CommunicationPreferences.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CommunicationPreferences
        {
            get { return this._communicationPreferences; }
            set { this._communicationPreferences = value; }
        }

        // Check to see if CommunicationPreferences property is set
        internal bool IsSetCommunicationPreferences()
        {
            return this._communicationPreferences != null && (this._communicationPreferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Email.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=6, Max=254)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property JobTitle.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=50)]
        public string JobTitle
        {
            get { return this._jobTitle; }
            set { this._jobTitle = value; }
        }

        // Check to see if JobTitle property is set
        internal bool IsSetJobTitle()
        {
            return this._jobTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=3, Max=50)]
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

    }
}