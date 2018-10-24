/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// A smart home appliance that can connect to a central system. Any domestic device can
    /// be a smart appliance.
    /// </summary>
    public partial class SmartHomeAppliance
    {
        private string _description;
        private string _friendlyName;
        private string _manufacturerName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the smart home appliance.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FriendlyName. 
        /// <para>
        /// The friendly name of the smart home appliance.
        /// </para>
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }

        // Check to see if FriendlyName property is set
        internal bool IsSetFriendlyName()
        {
            return this._friendlyName != null;
        }

        /// <summary>
        /// Gets and sets the property ManufacturerName. 
        /// <para>
        /// The name of the manufacturer of the smart home appliance.
        /// </para>
        /// </summary>
        public string ManufacturerName
        {
            get { return this._manufacturerName; }
            set { this._manufacturerName = value; }
        }

        // Check to see if ManufacturerName property is set
        internal bool IsSetManufacturerName()
        {
            return this._manufacturerName != null;
        }

    }
}