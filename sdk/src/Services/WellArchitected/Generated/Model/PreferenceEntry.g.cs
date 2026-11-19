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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A single Well-Architected Agent preference and its current state.
    /// </summary>
    public partial class PreferenceEntry
    {
        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// A human-readable explanation present only when status is FAILED, describing what went
        /// wrong and how to recover.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Detail { get; set; }

        /// <summary>
        /// Checks to see if the Detail property is set.
        /// </summary>
        internal bool IsSetDetail() => this.Detail != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Which preference this entry describes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PreferenceKey Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current state of the preference. ENABLED and DISABLED reflect the result of the most
        /// recent successful change. FAILED reflects a stored failure surfaced on a read and
        /// is accompanied by a detail message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PreferenceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
