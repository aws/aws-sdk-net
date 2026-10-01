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

namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// Information about a Recycle Bin retention rule.
    /// </summary>
    public partial class RuleSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The retention rule description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique ID of the retention rule.
        /// </para>
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LockState. 
        /// <para>
        /// [Region-level retention rules only] The lock state for the retention rule.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>locked</c> - The retention rule is locked and can't be modified or deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending_unlock</c> - The retention rule has been unlocked but it is still within
        /// the unlock delay period. The retention rule can be modified or deleted only after
        /// the unlock delay period has expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unlocked</c> - The retention rule is unlocked and it can be modified or deleted
        /// by any user with the required permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>null</c> - The retention rule has never been locked. Once a retention rule has
        /// been locked, it can transition between the <c>locked</c> and <c>unlocked</c> states
        /// only; it can never transition back to <c>null</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LockState LockState { get; set; }

        /// <summary>
        /// Checks to see if the LockState property is set.
        /// </summary>
        internal bool IsSetLockState() => this.LockState != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// Information about the retention period for which the retention rule is to retain resources.
        /// </para>
        /// </summary>
        public RetentionPeriod RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod != null;

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the retention rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1011)]
        public string RuleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleArn property is set.
        /// </summary>
        internal bool IsSetRuleArn() => this.RuleArn != null;
    }
}
