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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The organization name providing Amazon Web Services services.
    /// </summary>
    public partial class Entity
    {
        private string _invoicingEntity;

        /// <summary>
        /// Gets and sets the property InvoicingEntity. 
        /// <para>
        /// The name of the entity that issues the Amazon Web Services invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string InvoicingEntity
        {
            get { return this._invoicingEntity; }
            set { this._invoicingEntity = value; }
        }

        // Check to see if InvoicingEntity property is set
        internal bool IsSetInvoicingEntity()
        {
            return this._invoicingEntity != null;
        }

    }
}