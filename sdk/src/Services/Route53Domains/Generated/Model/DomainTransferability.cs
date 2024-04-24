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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// A complex type that contains information about whether the specified domain can be
    /// transferred to Route 53.
    /// </summary>
    public partial class DomainTransferability
    {
        private Transferable _transferable;

        /// <summary>
        /// Gets and sets the property Transferable.
        /// </summary>
        public Transferable Transferable
        {
            get { return this._transferable; }
            set { this._transferable = value; }
        }

        // Check to see if Transferable property is set
        internal bool IsSetTransferable()
        {
            return this._transferable != null;
        }

    }
}