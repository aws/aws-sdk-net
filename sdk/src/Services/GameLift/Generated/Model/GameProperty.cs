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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This key-value pair can store custom data about a game session. For example, you might
    /// use a <c>GameProperty</c> to track a game session's map, level of difficulty, or remaining
    /// time. The difficulty level could be specified like this: <c>{"Key": "difficulty",
    /// "Value":"Novice"}</c>. 
    /// 
    ///  
    /// <para>
    ///  You can set game properties when creating a game session. You can also modify game
    /// properties of an active game session. When searching for game sessions, you can filter
    /// on game property keys and values. You can't delete game properties from a game session.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For examples of working with game properties, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-client-api.html#game-properties">Create
    /// a game session with properties</a>. 
    /// </para>
    /// </summary>
    public partial class GameProperty
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The game property identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The game property value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=96)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}