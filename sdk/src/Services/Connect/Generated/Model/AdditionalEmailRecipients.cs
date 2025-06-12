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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// List of additional email addresses for an email contact.
    /// </summary>
    public partial class AdditionalEmailRecipients
    {
        private List<EmailRecipient> _ccList = AWSConfigs.InitializeCollections ? new List<EmailRecipient>() : null;
        private List<EmailRecipient> _toList = AWSConfigs.InitializeCollections ? new List<EmailRecipient>() : null;

        /// <summary>
        /// Gets and sets the property CcList. 
        /// <para>
        /// List of additional CC email recipients for an email contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EmailRecipient> CcList
        {
            get { return this._ccList; }
            set { this._ccList = value; }
        }

        // Check to see if CcList property is set
        internal bool IsSetCcList()
        {
            return this._ccList != null && (this._ccList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToList. 
        /// <para>
        /// List of additional TO email recipients for an email contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EmailRecipient> ToList
        {
            get { return this._toList; }
            set { this._toList = value; }
        }

        // Check to see if ToList property is set
        internal bool IsSetToList()
        {
            return this._toList != null && (this._toList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}