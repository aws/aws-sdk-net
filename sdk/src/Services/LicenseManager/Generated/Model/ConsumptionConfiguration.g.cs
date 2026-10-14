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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Details about a consumption configuration.
    /// </summary>
    public partial class ConsumptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property BorrowConfiguration. 
        /// <para>
        /// Details about a borrow configuration.
        /// </para>
        /// </summary>
        public BorrowConfiguration BorrowConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BorrowConfiguration property is set.
        /// </summary>
        internal bool IsSetBorrowConfiguration() => this.BorrowConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProvisionalConfiguration. 
        /// <para>
        /// Details about a provisional configuration.
        /// </para>
        /// </summary>
        public ProvisionalConfiguration ProvisionalConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionalConfiguration property is set.
        /// </summary>
        internal bool IsSetProvisionalConfiguration() => this.ProvisionalConfiguration != null;

        /// <summary>
        /// Gets and sets the property RenewType. 
        /// <para>
        /// Renewal frequency.
        /// </para>
        /// </summary>
        public RenewType RenewType { get; set; }

        /// <summary>
        /// Checks to see if the RenewType property is set.
        /// </summary>
        internal bool IsSetRenewType() => this.RenewType != null;
    }
}
