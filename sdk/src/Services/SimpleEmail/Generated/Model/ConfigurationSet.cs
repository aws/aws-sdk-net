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
    /// The name of the configuration set.
    /// 
    ///  
    /// <para>
    /// Configuration sets let you create groups of rules that you can apply to the emails
    /// you send using Amazon SES. For more information about using configuration sets, see
    /// <a href="https://docs.aws.amazon.com/ses/latest/dg/using-configuration-sets.html">Using
    /// Amazon SES Configuration Sets</a> in the <a href="https://docs.aws.amazon.com/ses/latest/dg/">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class ConfigurationSet
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration set. The name must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain 64 characters or fewer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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