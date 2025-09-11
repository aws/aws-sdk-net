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
    /// The Amazon QuickSight customizations associated with your Amazon Web Services account
    /// or a QuickSight namespace in a specific Amazon Web Services Region.
    /// </summary>
    public partial class AccountCustomization
    {
        private string _defaultEmailCustomizationTemplate;
        private string _defaultTheme;

        /// <summary>
        /// Gets and sets the property DefaultEmailCustomizationTemplate. 
        /// <para>
        /// The default email customization template.
        /// </para>
        /// </summary>
        public string DefaultEmailCustomizationTemplate
        {
            get { return this._defaultEmailCustomizationTemplate; }
            set { this._defaultEmailCustomizationTemplate = value; }
        }

        // Check to see if DefaultEmailCustomizationTemplate property is set
        internal bool IsSetDefaultEmailCustomizationTemplate()
        {
            return this._defaultEmailCustomizationTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTheme. 
        /// <para>
        /// The default theme for this QuickSight subscription.
        /// </para>
        /// </summary>
        public string DefaultTheme
        {
            get { return this._defaultTheme; }
            set { this._defaultTheme = value; }
        }

        // Check to see if DefaultTheme property is set
        internal bool IsSetDefaultTheme()
        {
            return this._defaultTheme != null;
        }

    }
}