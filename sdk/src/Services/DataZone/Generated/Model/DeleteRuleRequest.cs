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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRule operation.
    /// Deletes a rule in Amazon DataZone. A rule is a formal agreement that enforces specific
    /// requirements across user workflows (e.g., publishing assets to the catalog, requesting
    /// subscriptions, creating projects) within the Amazon DataZone data portal. These rules
    /// help maintain consistency, ensure compliance, and uphold governance standards in data
    /// management processes. For instance, a metadata enforcement rule can specify the required
    /// information for creating a subscription request or publishing a data asset to the
    /// catalog, ensuring alignment with organizational standards.
    /// </summary>
    public partial class DeleteRuleRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain that where the rule is to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the rule that is to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}