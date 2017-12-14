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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// A receipt IP address filter enables you to specify whether to accept or reject mail
    /// originating from an IP address or range of IP addresses.
    /// 
    ///  
    /// <para>
    /// For information about setting up IP address filters, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-ip-filters.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class ReceiptFilter
    {
        private ReceiptIpFilter _ipFilter;
        private string _name;

        /// <summary>
        /// Gets and sets the property IpFilter. 
        /// <para>
        /// A structure that provides the IP addresses to block or allow, and whether to block
        /// or allow incoming mail from them.
        /// </para>
        /// </summary>
        public ReceiptIpFilter IpFilter
        {
            get { return this._ipFilter; }
            set { this._ipFilter = value; }
        }

        // Check to see if IpFilter property is set
        internal bool IsSetIpFilter()
        {
            return this._ipFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the IP address filter. The name must:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This value can only contain ASCII letters (a-z, A-Z), numbers (0-9), underscores (_),
        /// or dashes (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start and end with a letter or number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain less than 64 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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

    }
}