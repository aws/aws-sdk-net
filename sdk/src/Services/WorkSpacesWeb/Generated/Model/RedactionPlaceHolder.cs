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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The redaction placeholder that will replace the redacted text in session.
    /// </summary>
    public partial class RedactionPlaceHolder
    {
        private string _redactionPlaceHolderText;
        private RedactionPlaceHolderType _redactionPlaceHolderType;

        /// <summary>
        /// Gets and sets the property RedactionPlaceHolderText. 
        /// <para>
        /// The redaction placeholder text that will replace the redacted text in session for
        /// the custom text redaction placeholder type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=20)]
        public string RedactionPlaceHolderText
        {
            get { return this._redactionPlaceHolderText; }
            set { this._redactionPlaceHolderText = value; }
        }

        // Check to see if RedactionPlaceHolderText property is set
        internal bool IsSetRedactionPlaceHolderText()
        {
            return this._redactionPlaceHolderText != null;
        }

        /// <summary>
        /// Gets and sets the property RedactionPlaceHolderType. 
        /// <para>
        /// The redaction placeholder type that will replace the redacted text in session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedactionPlaceHolderType RedactionPlaceHolderType
        {
            get { return this._redactionPlaceHolderType; }
            set { this._redactionPlaceHolderType = value; }
        }

        // Check to see if RedactionPlaceHolderType property is set
        internal bool IsSetRedactionPlaceHolderType()
        {
            return this._redactionPlaceHolderType != null;
        }

    }
}