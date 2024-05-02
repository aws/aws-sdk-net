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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Information about a receipt rule set.
    /// 
    ///  
    /// <para>
    /// A receipt rule set is a collection of rules that specify what Amazon SES should do
    /// with mail it receives on behalf of your account's verified domains.
    /// </para>
    ///  
    /// <para>
    /// For information about setting up receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-concepts.html#receiving-email-concepts-rules">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class ReceiptRuleSetMetadata
    {
        private DateTime? _createdTimestamp;
        private string _name;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The date and time the receipt rule set was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the receipt rule set. The name must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start and end with a letter or number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain 64 characters or fewer.
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