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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for the JSON token type.
    /// </summary>
    public partial class JsonTokenTypeConfiguration
    {
        private string _groupAttributeField;
        private string _userNameAttributeField;

        /// <summary>
        /// Gets and sets the property GroupAttributeField. 
        /// <para>
        /// The group attribute field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string GroupAttributeField
        {
            get { return this._groupAttributeField; }
            set { this._groupAttributeField = value; }
        }

        // Check to see if GroupAttributeField property is set
        internal bool IsSetGroupAttributeField()
        {
            return this._groupAttributeField != null;
        }

        /// <summary>
        /// Gets and sets the property UserNameAttributeField. 
        /// <para>
        /// The user name attribute field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string UserNameAttributeField
        {
            get { return this._userNameAttributeField; }
            set { this._userNameAttributeField = value; }
        }

        // Check to see if UserNameAttributeField property is set
        internal bool IsSetUserNameAttributeField()
        {
            return this._userNameAttributeField != null;
        }

    }
}