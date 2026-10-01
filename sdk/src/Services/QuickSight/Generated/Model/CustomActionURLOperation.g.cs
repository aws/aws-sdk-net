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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The URL operation that opens a link to another webpage.
    /// </summary>
    public partial class CustomActionURLOperation
    {
        /// <summary>
        /// Gets and sets the property URLTarget. 
        /// <para>
        /// The target of the <c>CustomActionURLOperation</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW_TAB</c>: Opens the target URL in a new browser tab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_WINDOW</c>: Opens the target URL in a new browser window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAME_TAB</c>: Opens the target URL in the same browser tab.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public URLTargetConfiguration URLTarget { get; set; }

        /// <summary>
        /// Checks to see if the URLTarget property is set.
        /// </summary>
        internal bool IsSetURLTarget() => this.URLTarget != null;

        /// <summary>
        /// Gets and sets the property URLTemplate. 
        /// <para>
        /// THe URL link of the <c>CustomActionURLOperation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string URLTemplate { get; set; }

        /// <summary>
        /// Checks to see if the URLTemplate property is set.
        /// </summary>
        internal bool IsSetURLTemplate() => this.URLTemplate != null;
    }
}
