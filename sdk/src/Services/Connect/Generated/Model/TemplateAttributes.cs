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
    /// Information about the template attributes.
    /// </summary>
    public partial class TemplateAttributes
    {
        private Dictionary<string, string> _customAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _customerProfileAttributes;

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// An object that specifies the custom attributes values to use for variables in the
        /// message template. This object contains different categories of key-value pairs. Each
        /// key defines a variable or placeholder in the message template. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomAttributes
        {
            get { return this._customAttributes; }
            set { this._customAttributes = value; }
        }

        // Check to see if CustomAttributes property is set
        internal bool IsSetCustomAttributes()
        {
            return this._customAttributes != null && (this._customAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomerProfileAttributes. 
        /// <para>
        /// An object that specifies the customer profile attributes values to use for variables
        /// in the message template. This object contains different categories of key-value pairs.
        /// Each key defines a variable or placeholder in the message template. 
        /// </para>
        /// </summary>
        public string CustomerProfileAttributes
        {
            get { return this._customerProfileAttributes; }
            set { this._customerProfileAttributes = value; }
        }

        // Check to see if CustomerProfileAttributes property is set
        internal bool IsSetCustomerProfileAttributes()
        {
            return this._customerProfileAttributes != null;
        }

    }
}