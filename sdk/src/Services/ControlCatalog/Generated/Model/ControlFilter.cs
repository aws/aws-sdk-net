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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// A structure that defines filtering criteria for the ListControls operation. You can
    /// use this filter to narrow down the list of controls based on their implementation
    /// details.
    /// </summary>
    public partial class ControlFilter
    {
        private ImplementationFilter _implementations;

        /// <summary>
        /// Gets and sets the property Implementations. 
        /// <para>
        /// A filter that narrows the results to controls with specific implementation types or
        /// identifiers. This field allows you to find controls that are implemented by specific
        /// Amazon Web Services services or with specific service identifiers.
        /// </para>
        /// </summary>
        public ImplementationFilter Implementations
        {
            get { return this._implementations; }
            set { this._implementations = value; }
        }

        // Check to see if Implementations property is set
        internal bool IsSetImplementations()
        {
            return this._implementations != null;
        }

    }
}