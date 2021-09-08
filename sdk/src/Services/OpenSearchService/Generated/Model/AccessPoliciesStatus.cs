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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The configured access rules for the domain's document and search endpoints, and the
    /// current status of those rules.
    /// </summary>
    public partial class AccessPoliciesStatus
    {
        private string _options;
        private OptionStatus _status;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The access policy configured for the domain. Access policies can be resource-based,
        /// IP-based, or IAM-based. See <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-access-policies"
        /// target="_blank"> Configuring access policies</a>for more information. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=102400)]
        public string Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access policy for the domain. See <code>OptionStatus</code> for
        /// the status information that's included. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}