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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lex.Model
{
    /// <summary>
    /// A context is a variable that contains information about the current state of the conversation
    /// between a user and Amazon Lex. Context can be set automatically by Amazon Lex when
    /// an intent is fulfilled, or it can be set at runtime using the <code>PutContent</code>,
    /// <code>PutText</code>, or <code>PutSession</code> operation.
    /// </summary>
    public partial class ActiveContext
    {
        private string _name;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private ActiveContextTimeToLive _timeToLive;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// State variables for the current context. You can use these values as default values
        /// for slots in subsequent events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// The length of time or number of turns that a context remains active.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActiveContextTimeToLive TimeToLive
        {
            get { return this._timeToLive; }
            set { this._timeToLive = value; }
        }

        // Check to see if TimeToLive property is set
        internal bool IsSetTimeToLive()
        {
            return this._timeToLive != null;
        }

    }
}