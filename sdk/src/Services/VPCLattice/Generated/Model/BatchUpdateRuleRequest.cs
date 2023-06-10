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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateRule operation.
    /// Updates the listener rules in a batch. You can use this operation to change the priority
    /// of listener rules. This can be useful when bulk updating or swapping rule priority.
    /// </summary>
    public partial class BatchUpdateRuleRequest : AmazonVPCLatticeRequest
    {
        private string _listenerIdentifier;
        private List<RuleUpdate> _rules = new List<RuleUpdate>();
        private string _serviceIdentifier;

        /// <summary>
        /// Gets and sets the property ListenerIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ListenerIdentifier
        {
            get { return this._listenerIdentifier; }
            set { this._listenerIdentifier = value; }
        }

        // Check to see if ListenerIdentifier property is set
        internal bool IsSetListenerIdentifier()
        {
            return this._listenerIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The rules for the specified listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<RuleUpdate> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string ServiceIdentifier
        {
            get { return this._serviceIdentifier; }
            set { this._serviceIdentifier = value; }
        }

        // Check to see if ServiceIdentifier property is set
        internal bool IsSetServiceIdentifier()
        {
            return this._serviceIdentifier != null;
        }

    }
}