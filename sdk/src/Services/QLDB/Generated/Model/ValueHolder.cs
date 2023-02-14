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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// A structure that can contain a value in multiple encoding formats.
    /// </summary>
    public partial class ValueHolder
    {
        private string _ionText;

        /// <summary>
        /// Gets and sets the property IonText. 
        /// <para>
        /// An Amazon Ion plaintext value contained in a <code>ValueHolder</code> structure.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1048576)]
        public string IonText
        {
            get { return this._ionText; }
            set { this._ionText = value; }
        }

        // Check to see if IonText property is set
        internal bool IsSetIonText()
        {
            return this._ionText != null;
        }

    }
}