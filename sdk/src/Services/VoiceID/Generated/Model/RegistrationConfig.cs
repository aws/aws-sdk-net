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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// The registration configuration to be used during the batch fraudster registration
    /// job.
    /// </summary>
    public partial class RegistrationConfig
    {
        private DuplicateRegistrationAction _duplicateRegistrationAction;
        private int? _fraudsterSimilarityThreshold;
        private List<string> _watchlistIds = new List<string>();

        /// <summary>
        /// Gets and sets the property DuplicateRegistrationAction. 
        /// <para>
        /// The action to take when a fraudster is identified as a duplicate. The default action
        /// is <code>SKIP</code>, which skips registering the duplicate fraudster. Setting the
        /// value to <code>REGISTER_AS_NEW</code> always registers a new fraudster into the specified
        /// domain.
        /// </para>
        /// </summary>
        public DuplicateRegistrationAction DuplicateRegistrationAction
        {
            get { return this._duplicateRegistrationAction; }
            set { this._duplicateRegistrationAction = value; }
        }

        // Check to see if DuplicateRegistrationAction property is set
        internal bool IsSetDuplicateRegistrationAction()
        {
            return this._duplicateRegistrationAction != null;
        }

        /// <summary>
        /// Gets and sets the property FraudsterSimilarityThreshold. 
        /// <para>
        /// The minimum similarity score between the new and old fraudsters in order to consider
        /// the new fraudster a duplicate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int FraudsterSimilarityThreshold
        {
            get { return this._fraudsterSimilarityThreshold.GetValueOrDefault(); }
            set { this._fraudsterSimilarityThreshold = value; }
        }

        // Check to see if FraudsterSimilarityThreshold property is set
        internal bool IsSetFraudsterSimilarityThreshold()
        {
            return this._fraudsterSimilarityThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WatchlistIds. 
        /// <para>
        /// The identifiers of watchlists that a fraudster is registered to. If a watchlist isn't
        /// provided, the fraudsters are registered to the default watchlist. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> WatchlistIds
        {
            get { return this._watchlistIds; }
            set { this._watchlistIds = value; }
        }

        // Check to see if WatchlistIds property is set
        internal bool IsSetWatchlistIds()
        {
            return this._watchlistIds != null && this._watchlistIds.Count > 0; 
        }

    }
}