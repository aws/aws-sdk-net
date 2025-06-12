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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdatePhoneNumber operation.
    /// Updates phone number product types or calling names. You can update one attribute
    /// at a time for each <c>UpdatePhoneNumberRequestItem</c>. For example, you can update
    /// the product type or the calling name.
    /// 
    ///  
    /// <para>
    /// For toll-free numbers, you cannot use the Amazon Chime Business Calling product type.
    /// For numbers outside the U.S., you must use the Amazon Chime SIP Media Application
    /// Dial-In product type.
    /// </para>
    ///  
    /// <para>
    /// Updates to outbound calling names can take up to 72 hours to complete. Pending updates
    /// to outbound calling names must be complete before you can request another update.
    /// </para>
    /// </summary>
    public partial class BatchUpdatePhoneNumberRequest : AmazonChimeRequest
    {
        private List<UpdatePhoneNumberRequestItem> _updatePhoneNumberRequestItems = AWSConfigs.InitializeCollections ? new List<UpdatePhoneNumberRequestItem>() : null;

        /// <summary>
        /// Gets and sets the property UpdatePhoneNumberRequestItems. 
        /// <para>
        /// The request containing the phone number IDs and product types or calling names to
        /// update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._updatePhoneNumberRequestItems != null && (this._updatePhoneNumberRequestItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}