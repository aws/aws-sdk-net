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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information about the phrases blocked from chat by your chat control configuration.
    /// </summary>
    public partial class BlockedPhrasesConfiguration
    {
        private List<string> _blockedPhrases = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _systemMessageOverride;

        /// <summary>
        /// Gets and sets the property BlockedPhrases. 
        /// <para>
        /// A list of phrases blocked from a Amazon Q Business web experience chat.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each phrase can contain a maximum of 36 characters. The list can contain a maximum
        /// of 20 phrases.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BlockedPhrases
        {
            get { return this._blockedPhrases; }
            set { this._blockedPhrases = value; }
        }

        // Check to see if BlockedPhrases property is set
        internal bool IsSetBlockedPhrases()
        {
            return this._blockedPhrases != null && (this._blockedPhrases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SystemMessageOverride. 
        /// <para>
        /// The configured custom message displayed to an end user informing them that they've
        /// used a blocked phrase during chat.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=350)]
        public string SystemMessageOverride
        {
            get { return this._systemMessageOverride; }
            set { this._systemMessageOverride = value; }
        }

        // Check to see if SystemMessageOverride property is set
        internal bool IsSetSystemMessageOverride()
        {
            return this._systemMessageOverride != null;
        }

    }
}