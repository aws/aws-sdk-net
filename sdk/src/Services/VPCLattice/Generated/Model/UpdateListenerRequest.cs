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
    /// Container for the parameters to the UpdateListener operation.
    /// Updates the specified listener for the specified service.
    /// </summary>
    public partial class UpdateListenerRequest : AmazonVPCLatticeRequest
    {
        private RuleAction _defaultAction;
        private string _listenerIdentifier;
        private string _serviceIdentifier;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action for the default rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleAction DefaultAction
        {
            get { return this._defaultAction; }
            set { this._defaultAction = value; }
        }

        // Check to see if DefaultAction property is set
        internal bool IsSetDefaultAction()
        {
            return this._defaultAction != null;
        }

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