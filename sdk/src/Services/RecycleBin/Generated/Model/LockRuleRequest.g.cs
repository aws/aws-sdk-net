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
    /// Container for the parameters to the LockRule operation. Locks a Region-level retention
    /// rule. A locked retention rule can't be modified or deleted. <note> <para> You can't
    /// lock tag-level retention rules, or Region-level retention rules that have exclusion
    /// tags. </para> </note>
    /// </summary>
    public partial class LockRuleRequest : AmazonRecycleBinRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique ID of the retention rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LockConfiguration. 
        /// <para>
        /// Information about the retention rule lock configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LockConfiguration LockConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LockConfiguration property is set.
        /// </summary>
        internal bool IsSetLockConfiguration() => this.LockConfiguration != null;
    }
}
