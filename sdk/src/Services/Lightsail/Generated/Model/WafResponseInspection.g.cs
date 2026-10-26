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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the HTTP status codes that your application returns to indicate successful
    /// and failed attempts. The Web Application Firewall (WAF) rule group uses these status
    /// codes to track successful and failed attempts.
    /// </summary>
    public partial class WafResponseInspection
    {
        /// <summary>
        /// Gets and sets the property FailureCodes. 
        /// <para>
        /// The HTTP status codes that indicate a failed attempt (for example, <c>401</c>).
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 10 status codes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each status code must be from <c>0</c> to <c>999</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't contain a status code that is also in <c>successCodes</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> FailureCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the FailureCodes property is set.
        /// </summary>
        internal bool IsSetFailureCodes() => this.FailureCodes != null && (this.FailureCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SuccessCodes. 
        /// <para>
        /// The HTTP status codes that indicate a successful attempt (for example, <c>200</c>).
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 10 status codes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each status code must be from <c>0</c> to <c>999</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't contain a status code that is also in <c>failureCodes</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> SuccessCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the SuccessCodes property is set.
        /// </summary>
        internal bool IsSetSuccessCodes() => this.SuccessCodes != null && (this.SuccessCodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
