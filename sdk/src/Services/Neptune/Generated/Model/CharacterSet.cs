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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Specifies a character set.
    /// </summary>
    public partial class CharacterSet
    {
        private string _characterSetDescription;
        private string _characterSetName;

        /// <summary>
        /// Gets and sets the property CharacterSetDescription. 
        /// <para>
        /// The description of the character set.
        /// </para>
        /// </summary>
        public string CharacterSetDescription
        {
            get { return this._characterSetDescription; }
            set { this._characterSetDescription = value; }
        }

        // Check to see if CharacterSetDescription property is set
        internal bool IsSetCharacterSetDescription()
        {
            return this._characterSetDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// The name of the character set.
        /// </para>
        /// </summary>
        public string CharacterSetName
        {
            get { return this._characterSetName; }
            set { this._characterSetName = value; }
        }

        // Check to see if CharacterSetName property is set
        internal bool IsSetCharacterSetName()
        {
            return this._characterSetName != null;
        }

    }
}