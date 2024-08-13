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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the PutInboundDmarcSettings operation.
    /// Enables or disables a DMARC policy for a given organization.
    /// </summary>
    public partial class PutInboundDmarcSettingsRequest : AmazonWorkMailRequest
    {
        private bool? _enforced;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property Enforced. 
        /// <para>
        /// Enforces or suspends a policy after it's applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enforced
        {
            get { return this._enforced; }
            set { this._enforced = value; }
        }

        // Check to see if Enforced property is set
        internal bool IsSetEnforced()
        {
            return this._enforced.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization that you are applying the DMARC policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}