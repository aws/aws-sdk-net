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
    /// The domain unit filter of the project grant filter.
    /// </summary>
    public partial class DomainUnitFilterForProject
    {
        private string _domainUnit;
        private bool? _includeChildDomainUnits;

        /// <summary>
        /// Gets and sets the property DomainUnit. 
        /// <para>
        /// The domain unit ID to use in the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DomainUnit
        {
            get { return this._domainUnit; }
            set { this._domainUnit = value; }
        }

        // Check to see if DomainUnit property is set
        internal bool IsSetDomainUnit()
        {
            return this._domainUnit != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeChildDomainUnits. 
        /// <para>
        /// Specifies whether to include child domain units.
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