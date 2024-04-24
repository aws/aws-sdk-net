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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
        private BorrowConfiguration _borrowConfiguration;
        private ProvisionalConfiguration _provisionalConfiguration;
        private RenewType _renewType;

        /// <summary>
        /// Gets and sets the property BorrowConfiguration. 
        /// <para>
        /// Details about a borrow configuration.
        /// </para>
        /// </summary>
        public BorrowConfiguration BorrowConfiguration
        {
            get { return this._borrowConfiguration; }
            set { this._borrowConfiguration = value; }
        }

        // Check to see if BorrowConfiguration property is set
        internal bool IsSetBorrowConfiguration()
        {
            return this._borrowConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionalConfiguration. 
        /// <para>
        /// Details about a provisional configuration.
        /// </para>
        /// </summary>
        public ProvisionalConfiguration ProvisionalConfiguration
        {
            get { return this._provisionalConfiguration; }
            set { this._provisionalConfiguration = value; }
        }

        // Check to see if ProvisionalConfiguration property is set
        internal bool IsSetProvisionalConfiguration()
        {
            return this._provisionalConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RenewType. 
        /// <para>
        /// Renewal frequency.
        /// </para>
        /// </summary>
        public RenewType RenewType
        {
            get { return this._renewType; }
            set { this._renewType = value; }
        }

        // Check to see if RenewType property is set
        internal bool IsSetRenewType()
        {
            return this._renewType != null;
        }

    }
}