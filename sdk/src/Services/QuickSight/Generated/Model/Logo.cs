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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The logo configuration.
    /// </summary>
    public partial class Logo
    {
        private string _altText;
        private LogoSet _logoSet;

        /// <summary>
        /// Gets and sets the property AltText. 
        /// <para>
        /// The alt text for the logo.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AltText
        {
            get { return this._altText; }
            set { this._altText = value; }
        }

        // Check to see if AltText property is set
        internal bool IsSetAltText()
        {
            return this._altText != null;
        }

        /// <summary>
        /// Gets and sets the property LogoSet. 
        /// <para>
        /// A set of configured logos.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogoSet LogoSet
        {
            get { return this._logoSet; }
            set { this._logoSet = value; }
        }

        // Check to see if LogoSet property is set
        internal bool IsSetLogoSet()
        {
            return this._logoSet != null;
        }

    }
}