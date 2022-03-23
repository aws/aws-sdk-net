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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGameConfiguration operation.
    /// Updates one or more sections of the game configuration.
    /// </summary>
    public partial class UpdateGameConfigurationRequest : AmazonGameSparksRequest
    {
        private string _gameName;
        private List<SectionModification> _modifications = new List<SectionModification>();

        /// <summary>
        /// Gets and sets the property GameName. 
        /// <para>
        /// The name of the game.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string GameName
        {
            get { return this._gameName; }
            set { this._gameName = value; }
        }

        // Check to see if GameName property is set
        internal bool IsSetGameName()
        {
            return this._gameName != null;
        }

        /// <summary>
        /// Gets and sets the property Modifications. 
        /// <para>
        /// The list of modifications to make.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<SectionModification> Modifications
        {
            get { return this._modifications; }
            set { this._modifications = value; }
        }

        // Check to see if Modifications property is set
        internal bool IsSetModifications()
        {
            return this._modifications != null && this._modifications.Count > 0; 
        }

    }
}