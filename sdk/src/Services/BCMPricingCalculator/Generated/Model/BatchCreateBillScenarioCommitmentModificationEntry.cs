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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents an entry object in the batch operation to create bill scenario commitment
    /// modifications.
    /// </summary>
    public partial class BatchCreateBillScenarioCommitmentModificationEntry
    {
        private BillScenarioCommitmentModificationAction _commitmentAction;
        private string _group;
        private string _key;
        private string _usageAccountId;

        /// <summary>
        /// Gets and sets the property CommitmentAction. 
        /// <para>
        ///  The specific commitment action to be taken (e.g., adding a Reserved Instance or Savings
        /// Plan). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BillScenarioCommitmentModificationAction CommitmentAction
        {
            get { return this._commitmentAction; }
            set { this._commitmentAction = value; }
        }

        // Check to see if CommitmentAction property is set
        internal bool IsSetCommitmentAction()
        {
            return this._commitmentAction != null;
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        ///  An optional group identifier for the commitment modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  A unique identifier for this entry in the batch operation. This can be any valid
        /// string. This key is useful to identify errors associated with any commitment entry
        /// as any error is returned with this key. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID to which this commitment will be applied to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string UsageAccountId
        {
            get { return this._usageAccountId; }
            set { this._usageAccountId = value; }
        }

        // Check to see if UsageAccountId property is set
        internal bool IsSetUsageAccountId()
        {
            return this._usageAccountId != null;
        }

    }
}