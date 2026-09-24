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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The domain unit principal to whom the policy is granted.
    /// </summary>
    public partial class DomainUnitPolicyGrantPrincipal
    {
        /// <summary>
        /// Gets and sets the property DomainUnitDesignation. 
        /// <para>
        /// Specifes the designation of the domain unit users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DomainUnitDesignation DomainUnitDesignation { get; set; }

        /// <summary>
        /// Checks to see if the DomainUnitDesignation property is set.
        /// </summary>
        internal bool IsSetDomainUnitDesignation() => this.DomainUnitDesignation != null;

        /// <summary>
        /// Gets and sets the property DomainUnitGrantFilter. 
        /// <para>
        /// The grant filter for the domain unit.
        /// </para>
        /// </summary>
        public DomainUnitGrantFilter DomainUnitGrantFilter { get; set; }

        /// <summary>
        /// Checks to see if the DomainUnitGrantFilter property is set.
        /// </summary>
        internal bool IsSetDomainUnitGrantFilter() => this.DomainUnitGrantFilter != null;

        /// <summary>
        /// Gets and sets the property DomainUnitIdentifier. 
        /// <para>
        /// The ID of the domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DomainUnitIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainUnitIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainUnitIdentifier() => this.DomainUnitIdentifier != null;
    }
}
