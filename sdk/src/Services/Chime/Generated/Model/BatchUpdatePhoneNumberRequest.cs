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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdatePhoneNumber operation.
    /// Updates phone number product types. Choose from Amazon Chime Business Calling and
    /// Amazon Chime Voice Connector product types. For toll-free numbers, you can use only
    /// the Amazon Chime Voice Connector product type.
    /// </summary>
    public partial class BatchUpdatePhoneNumberRequest : AmazonChimeRequest
    {
        private List<UpdatePhoneNumberRequestItem> _updatePhoneNumberRequestItems = new List<UpdatePhoneNumberRequestItem>();

        /// <summary>
        /// Gets and sets the property UpdatePhoneNumberRequestItems. 
        /// <para>
        /// The request containing the phone number IDs and product types to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<UpdatePhoneNumberRequestItem> UpdatePhoneNumberRequestItems
        {
            get { return this._updatePhoneNumberRequestItems; }
            set { this._updatePhoneNumberRequestItems = value; }
        }

        // Check to see if UpdatePhoneNumberRequestItems property is set
        internal bool IsSetUpdatePhoneNumberRequestItems()
        {
            return this._updatePhoneNumberRequestItems != null && this._updatePhoneNumberRequestItems.Count > 0; 
        }

    }
}