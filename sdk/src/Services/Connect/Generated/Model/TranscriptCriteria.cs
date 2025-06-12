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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A structure that defines search criteria base on words or phrases, participants in
    /// the Contact Lens conversational analytics transcript.
    /// </summary>
    public partial class TranscriptCriteria
    {
        private SearchContactsMatchType _matchType;
        private ParticipantRole _participantRole;
        private List<string> _searchText = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MatchType. 
        /// <para>
        /// The match type combining search criteria using multiple search texts in a transcript
        /// criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchContactsMatchType MatchType
        {
            get { return this._matchType; }
            set { this._matchType = value; }
        }

        // Check to see if MatchType property is set
        internal bool IsSetMatchType()
        {
            return this._matchType != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The participant role in a transcript
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParticipantRole ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

        /// <summary>
        /// Gets and sets the property SearchText. 
        /// <para>
        /// The words or phrases used to search within a transcript.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> SearchText
        {
            get { return this._searchText; }
            set { this._searchText = value; }
        }

        // Check to see if SearchText property is set
        internal bool IsSetSearchText()
        {
            return this._searchText != null && (this._searchText.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}