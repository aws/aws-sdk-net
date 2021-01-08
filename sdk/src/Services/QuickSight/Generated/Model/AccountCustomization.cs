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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The Amazon QuickSight customizations associated with your AWS account or a QuickSight
    /// namespace in a specific AWS Region.
    /// </summary>
    public partial class AccountCustomization
    {
        private string _defaultTheme;

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