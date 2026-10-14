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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// The updated delivery parameters for the text channel. Absent members preserve the
    /// current value, and the empty sentinel on a member clears it.
    /// </summary>
    public partial class UpdateTextParameters
    {
        private Dictionary<string, string> _destinationCountryParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _inlineTemplateBody;

        /// <summary>
        /// Gets and sets the property DestinationCountryParameters. 
        /// <para>
        /// The updated map of country-specific parameters that control one-time passcode delivery.
        /// An empty map clears the previously stored value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> DestinationCountryParameters
        {
            get { return this._destinationCountryParameters; }
            set { this._destinationCountryParameters = value; }
        }

        // Check to see if DestinationCountryParameters property is set
        internal bool IsSetDestinationCountryParameters()
        {
            return this._destinationCountryParameters != null && (this._destinationCountryParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InlineTemplateBody. 
        /// <para>
        /// The updated freeform SMS or RCS template body. An empty string clears the previously
        /// stored value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=6000)]
        public string InlineTemplateBody
        {
            get { return this._inlineTemplateBody; }
            set { this._inlineTemplateBody = value; }
        }

        // Check to see if InlineTemplateBody property is set
        internal bool IsSetInlineTemplateBody()
        {
            return this._inlineTemplateBody != null;
        }

    }
}