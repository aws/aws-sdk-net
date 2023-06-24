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
    /// The date configuration of the filter.
    /// </summary>
    public partial class AnchorDateConfiguration
    {
        private AnchorOption _anchorOption;
        private string _parameterName;

        /// <summary>
        /// Gets and sets the property AnchorOption. 
        /// <para>
        /// The options for the date configuration. Choose one of the options below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NOW</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnchorOption AnchorOption
        {
            get { return this._anchorOption; }
            set { this._anchorOption = value; }
        }

        // Check to see if AnchorOption property is set
        internal bool IsSetAnchorOption()
        {
            return this._anchorOption != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter that is used for the anchor date configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

    }
}