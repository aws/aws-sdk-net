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

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the UpdateGeoMatchSet operation.
    /// </summary>
    public partial class UpdateGeoMatchSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The <c>ChangeToken</c> that you used to submit the <c>UpdateGeoMatchSet</c> request.
        /// You can also use this value to query the status of the request. For more information,
        /// see <a>GetChangeTokenStatus</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ChangeToken { get; set; }

        /// <summary>
        /// Checks to see if the ChangeToken property is set.
        /// </summary>
        internal bool IsSetChangeToken() => this.ChangeToken != null;
    }
}
