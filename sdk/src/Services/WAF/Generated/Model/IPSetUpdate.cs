/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Specifies the type of update to perform to an <a>IPSet</a> with <a>UpdateIPSet</a>.
    /// </summary>
    public partial class IPSetUpdate
    {
        private ChangeAction _action;
        private IPSetDescriptor _ipSetDescriptor;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies whether to insert or delete an IP address with <a>UpdateIPSet</a>.
        /// </para>
        /// </summary>
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property IPSetDescriptor. 
        /// <para>
        /// The IP address type (<code>IPV4</code> or <code>IPV6</code>) and the IP address range
        /// (in CIDR notation) that web requests originate from.
        /// </para>
        /// </summary>
        public IPSetDescriptor IPSetDescriptor
        {
            get { return this._ipSetDescriptor; }
            set { this._ipSetDescriptor = value; }
        }

        // Check to see if IPSetDescriptor property is set
        internal bool IsSetIPSetDescriptor()
        {
            return this._ipSetDescriptor != null;
        }

    }
}