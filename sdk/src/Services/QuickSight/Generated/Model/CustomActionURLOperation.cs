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
    /// The URL operation that opens a link to another webpage.
    /// </summary>
    public partial class CustomActionURLOperation
    {
        private URLTargetConfiguration _urlTarget;
        private string _urlTemplate;

        /// <summary>
        /// Gets and sets the property URLTarget. 
        /// <para>
        /// The target of the <code>CustomActionURLOperation</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NEW_TAB</code>: Opens the target URL in a new browser tab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_WINDOW</code>: Opens the target URL in a new browser window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SAME_TAB</code>: Opens the target URL in the same browser tab.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public URLTargetConfiguration URLTarget
        {
            get { return this._urlTarget; }
            set { this._urlTarget = value; }
        }

        // Check to see if URLTarget property is set
        internal bool IsSetURLTarget()
        {
            return this._urlTarget != null;
        }

        /// <summary>
        /// Gets and sets the property URLTemplate. 
        /// <para>
        /// THe URL link of the <code>CustomActionURLOperation</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string URLTemplate
        {
            get { return this._urlTemplate; }
            set { this._urlTemplate = value; }
        }

        // Check to see if URLTemplate property is set
        internal bool IsSetURLTemplate()
        {
            return this._urlTemplate != null;
        }

    }
}