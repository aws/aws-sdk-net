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
    /// Container for the parameters to the UpdateRule operation.
    /// Updates a rule. In Amazon DataZone, a rule is a formal agreement that enforces specific
    /// requirements across user workflows (e.g., publishing assets to the catalog, requesting
    /// subscriptions, creating projects) within the Amazon DataZone data portal. These rules
    /// help maintain consistency, ensure compliance, and uphold governance standards in data
    /// management processes. For instance, a metadata enforcement rule can specify the required
    /// information for creating a subscription request or publishing a data asset to the
    /// catalog, ensuring alignment with organizational standards.
    /// </summary>
    public partial class UpdateRuleRequest : AmazonDataZoneRequest
    {
        private string _description;
        private RuleDetail _detail;
        private string _domainIdentifier;
        private string _identifier;
        private bool? _includeChildDomainUnits;
        private string _name;
        private RuleScope _scope;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// The detail of the rule.
        /// </para>
        /// </summary>
        public RuleDetail Detail
        {
            get { return this._detail; }
            set { this._detail = value; }
        }

        // Check to see if Detail property is set
        internal bool IsSetDetail()
        {
            return this._detail != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain in which a rule is to be updated.
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
        /// The ID of the rule that is to be updated
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

        /// <summary>
        /// Gets and sets the property IncludeChildDomainUnits. 
        /// <para>
        /// Specifies whether to update this rule in the child domain units.
        /// </para>
        /// </summary>
        public bool? IncludeChildDomainUnits
        {
            get { return this._includeChildDomainUnits; }
            set { this._includeChildDomainUnits = value; }
        }

        // Check to see if IncludeChildDomainUnits property is set
        internal bool IsSetIncludeChildDomainUnits()
        {
            return this._includeChildDomainUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scrope of the rule.
        /// </para>
        /// </summary>
        public RuleScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}