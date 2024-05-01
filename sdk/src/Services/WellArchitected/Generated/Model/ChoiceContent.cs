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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// The choice content.
    /// </summary>
    public partial class ChoiceContent
    {
        private string _displayText;
        private string _url;

        /// <summary>
        /// Gets and sets the property DisplayText. 
        /// <para>
        /// The display text for the choice content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DisplayText
        {
            get { return this._displayText; }
            set { this._displayText = value; }
        }

        // Check to see if DisplayText property is set
        internal bool IsSetDisplayText()
        {
            return this._displayText != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL for the choice content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}