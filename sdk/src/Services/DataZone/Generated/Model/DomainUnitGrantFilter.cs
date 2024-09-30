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
    /// The grant filter for the domain unit. In the current release of Amazon DataZone, the
    /// only supported filter is the <c>allDomainUnitsGrantFilter</c>.
    /// </summary>
    public partial class DomainUnitGrantFilter
    {
        private AllDomainUnitsGrantFilter _allDomainUnitsGrantFilter;

        /// <summary>
        /// Gets and sets the property AllDomainUnitsGrantFilter. 
        /// <para>
        /// Specifies a grant filter containing all domain units.
        /// </para>
        /// </summary>
        public AllDomainUnitsGrantFilter AllDomainUnitsGrantFilter
        {
            get { return this._allDomainUnitsGrantFilter; }
            set { this._allDomainUnitsGrantFilter = value; }
        }

        // Check to see if AllDomainUnitsGrantFilter property is set
        internal bool IsSetAllDomainUnitsGrantFilter()
        {
            return this._allDomainUnitsGrantFilter != null;
        }

    }
}