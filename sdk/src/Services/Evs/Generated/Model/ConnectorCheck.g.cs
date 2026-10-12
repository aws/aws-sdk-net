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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// A check on a connector to identify connectivity health.
    /// </summary>
    public partial class ConnectorCheck
    {
        /// <summary>
        /// Gets and sets the property ImpairedSince. 
        /// <para>
        /// The time when connector health began to be impaired.
        /// </para>
        /// </summary>
        public DateTime? ImpairedSince { get; set; }

        /// <summary>
        /// Checks to see if the ImpairedSince property is set.
        /// </summary>
        internal bool IsSetImpairedSince() => this.ImpairedSince.HasValue;

        /// <summary>
        /// Gets and sets the property LastCheckAttempt. 
        /// <para>
        /// The date and time of the last check attempt.
        /// </para>
        /// </summary>
        public DateTime? LastCheckAttempt { get; set; }

        /// <summary>
        /// Checks to see if the LastCheckAttempt property is set.
        /// </summary>
        internal bool IsSetLastCheckAttempt() => this.LastCheckAttempt.HasValue;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The check result.
        /// </para>
        /// </summary>
        public CheckResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The check type.
        /// </para>
        /// </summary>
        public CheckType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
