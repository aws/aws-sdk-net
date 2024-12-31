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
    /// The target for the domain unit.
    /// </summary>
    public partial class DomainUnitTarget
    {
        private string _domainUnitId;
        private bool? _includeChildDomainUnits;

        /// <summary>
        /// Gets and sets the property DomainUnitId. 
        /// <para>
        /// The ID of the domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DomainUnitId
        {
            get { return this._domainUnitId; }
            set { this._domainUnitId = value; }
        }

        // Check to see if DomainUnitId property is set
        internal bool IsSetDomainUnitId()
        {
            return this._domainUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeChildDomainUnits. 
        /// <para>
        /// Specifies whether to apply a rule to the child domain units.
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

    }
}