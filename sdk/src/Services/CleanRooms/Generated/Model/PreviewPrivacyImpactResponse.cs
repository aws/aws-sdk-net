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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// This is the response object from the PreviewPrivacyImpact operation.
    /// </summary>
    public partial class PreviewPrivacyImpactResponse : AmazonWebServiceResponse
    {
        private PrivacyImpact _privacyImpact;

        /// <summary>
        /// Gets and sets the property PrivacyImpact. 
        /// <para>
        /// An estimate of the number of aggregation functions that the member who can query can
        /// run given the epsilon and noise parameters. This does not change the privacy budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyImpact PrivacyImpact
        {
            get { return this._privacyImpact; }
            set { this._privacyImpact = value; }
        }

        // Check to see if PrivacyImpact property is set
        internal bool IsSetPrivacyImpact()
        {
            return this._privacyImpact != null;
        }

    }
}