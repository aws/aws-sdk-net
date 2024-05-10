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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Provides information about a single utterance that was made to your bot.
    /// </summary>
    public partial class UtteranceData
    {
        private int? _count;
        private int? _distinctUsers;
        private DateTime? _firstUtteredDate;
        private DateTime? _lastUtteredDate;
        private string _utteranceString;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of times that the utterance was processed.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DistinctUsers. 
        /// <para>
        /// The total number of individuals that used the utterance.
        /// </para>
        /// </summary>
        public int? DistinctUsers
        {
            get { return this._distinctUsers; }
            set { this._distinctUsers = value; }
        }

        // Check to see if DistinctUsers property is set
        internal bool IsSetDistinctUsers()
        {
            return this._distinctUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstUtteredDate. 
        /// <para>
        /// The date that the utterance was first recorded.
        /// </para>
        /// </summary>
        public DateTime? FirstUtteredDate
        {
            get { return this._firstUtteredDate; }
            set { this._firstUtteredDate = value; }
        }

        // Check to see if FirstUtteredDate property is set
        internal bool IsSetFirstUtteredDate()
        {
            return this._firstUtteredDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUtteredDate. 
        /// <para>
        /// The date that the utterance was last recorded.
        /// </para>
        /// </summary>
        public DateTime? LastUtteredDate
        {
            get { return this._lastUtteredDate; }
            set { this._lastUtteredDate = value; }
        }

        // Check to see if LastUtteredDate property is set
        internal bool IsSetLastUtteredDate()
        {
            return this._lastUtteredDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtteranceString. 
        /// <para>
        /// The text that was entered by the user or the text representation of an audio clip.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string UtteranceString
        {
            get { return this._utteranceString; }
            set { this._utteranceString = value; }
        }

        // Check to see if UtteranceString property is set
        internal bool IsSetUtteranceString()
        {
            return this._utteranceString != null;
        }

    }
}