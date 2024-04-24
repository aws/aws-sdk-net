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
    /// Information about notes for a contact evaluation.
    /// </summary>
    public partial class EvaluationNote
    {
        private string _value;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The note for an item (section or question) in a contact evaluation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Even though a note in an evaluation can have up to 3072 chars, there is also a limit
        /// on the total number of chars for all the notes in the evaluation combined. Assuming
        /// there are N questions in the evaluation being submitted, then the max char limit for
        /// all notes combined is N x 1024.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}