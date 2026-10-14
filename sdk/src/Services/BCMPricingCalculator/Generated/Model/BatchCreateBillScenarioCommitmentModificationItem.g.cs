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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents a successfully created item in a batch operation for bill scenario commitment
    /// modifications.
    /// </summary>
    public partial class BatchCreateBillScenarioCommitmentModificationItem
    {
        /// <summary>
        /// Gets and sets the property CommitmentAction. 
        /// <para>
        ///  The specific commitment action that was taken. 
        /// </para>
        /// </summary>
        public BillScenarioCommitmentModificationAction CommitmentAction { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentAction property is set.
        /// </summary>
        internal bool IsSetCommitmentAction() => this.CommitmentAction != null;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        ///  The group identifier for the created commitment modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public string Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier assigned to the created commitment modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  The key of the successfully created entry. This can be any valid string. This key
        /// is useful to identify errors associated with any commitment entry as any error is
        /// returned with this key. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with the created commitment modification.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string UsageAccountId { get; set; }

        /// <summary>
        /// Checks to see if the UsageAccountId property is set.
        /// </summary>
        internal bool IsSetUsageAccountId() => this.UsageAccountId != null;
    }
}
