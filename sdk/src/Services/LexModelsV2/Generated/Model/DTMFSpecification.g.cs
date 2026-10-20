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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Specifies the DTMF input specifications.
    /// </summary>
    public partial class DTMFSpecification
    {
        /// <summary>
        /// Gets and sets the property DeletionCharacter. 
        /// <para>
        /// The DTMF character that clears the accumulated DTMF digits and immediately ends the
        /// input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeletionCharacter { get; set; }

        /// <summary>
        /// Checks to see if the DeletionCharacter property is set.
        /// </summary>
        internal bool IsSetDeletionCharacter() => this.DeletionCharacter != null;

        /// <summary>
        /// Gets and sets the property EndCharacter. 
        /// <para>
        /// The DTMF character that immediately ends input. If the user does not press this character,
        /// the input ends after the end timeout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EndCharacter { get; set; }

        /// <summary>
        /// Checks to see if the EndCharacter property is set.
        /// </summary>
        internal bool IsSetEndCharacter() => this.EndCharacter != null;

        /// <summary>
        /// Gets and sets the property EndTimeoutMs. 
        /// <para>
        /// How long the bot should wait after the last DTMF character input before assuming that
        /// the input has concluded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? EndTimeoutMs { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeoutMs property is set.
        /// </summary>
        internal bool IsSetEndTimeoutMs() => this.EndTimeoutMs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum number of DTMF digits allowed in an utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;
    }
}
