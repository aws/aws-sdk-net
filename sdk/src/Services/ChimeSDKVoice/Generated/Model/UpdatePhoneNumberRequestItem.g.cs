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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The phone number ID, product type, or calling name fields to update, used with the
    /// <a>BatchUpdatePhoneNumber</a> and <a>UpdatePhoneNumber</a> actions.
    /// </summary>
    public partial class UpdatePhoneNumberRequestItem
    {
        /// <summary>
        /// Gets and sets the property CallingName. 
        /// <para>
        /// The outbound calling name to update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CallingName { get; set; }

        /// <summary>
        /// Checks to see if the CallingName property is set.
        /// </summary>
        internal bool IsSetCallingName() => this.CallingName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The phone number ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string PhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberId property is set.
        /// </summary>
        internal bool IsSetPhoneNumberId() => this.PhoneNumberId != null;

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The product type to update.
        /// </para>
        /// </summary>
        public PhoneNumberProductType ProductType { get; set; }

        /// <summary>
        /// Checks to see if the ProductType property is set.
        /// </summary>
        internal bool IsSetProductType() => this.ProductType != null;
    }
}
