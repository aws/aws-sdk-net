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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The filter applied to <code>ListProfileObjects</code> response to include profile
    /// objects with the specified index values.
    /// </summary>
    public partial class ObjectFilter
    {
        private string _keyName;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// A searchable identifier of a profile object. The predefined keys you can use to search
        /// for <code>_asset</code> include: <code>_assetId</code>, <code>_assetName</code>, and
        /// <code>_serialNumber</code>. The predefined keys you can use to search for <code>_case</code>
        /// include: <code>_caseId</code>. The predefined keys you can use to search for <code>_order</code>
        /// include: <code>_orderId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// A list of key values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}