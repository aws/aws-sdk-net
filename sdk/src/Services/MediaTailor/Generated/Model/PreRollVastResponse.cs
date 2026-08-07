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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The settings that control how MediaTailor processes VAST responses from the ad decision
    /// server for live pre-roll ad breaks.
    /// </summary>
    public partial class PreRollVastResponse
    {
        private PreRollAdSequencingMode _adSequencingMode;

        /// <summary>
        /// Gets and sets the property AdSequencingMode. 
        /// <para>
        /// The ad sequencing mode for live pre-roll ads. <c>FOLLOW_AD_SEQUENCE</c> inserts sequenced
        /// ads in increasing order and uses standalone ads only as replacements when a sequenced
        /// ad fails. <c>IGNORE_AD_SEQUENCE</c> inserts ads in the order they appear in the VAST
        /// response, regardless of sequence attributes. The default behavior is <c>IGNORE_AD_SEQUENCE</c>.
        /// </para>
        /// </summary>
        public PreRollAdSequencingMode AdSequencingMode
        {
            get { return this._adSequencingMode; }
            set { this._adSequencingMode = value; }
        }

        // Check to see if AdSequencingMode property is set
        internal bool IsSetAdSequencingMode()
        {
            return this._adSequencingMode != null;
        }

    }
}