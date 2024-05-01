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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
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
namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// A structure that can contain a value in multiple encoding formats.
    /// </summary>
    public partial class ValueHolder
    {
        private MemoryStream _ionBinary;
        private string _ionText;

        /// <summary>
        /// Gets and sets the property IonBinary. 
        /// <para>
        /// An Amazon Ion binary value contained in a <c>ValueHolder</c> structure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public MemoryStream IonBinary
        {
            get { return this._ionBinary; }
            set { this._ionBinary = value; }
        }

        // Check to see if IonBinary property is set
        internal bool IsSetIonBinary()
        {
            return this._ionBinary != null;
        }

        /// <summary>
        /// Gets and sets the property IonText. 
        /// <para>
        /// An Amazon Ion plaintext value contained in a <c>ValueHolder</c> structure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1048576)]
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