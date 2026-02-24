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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration that specifies a naming pattern for destination log groups created during
    /// centralization. The pattern supports static text and dynamic variables that are replaced
    /// with source attributes when log groups are created.
    /// </summary>
    public partial class LogGroupNameConfiguration
    {
        private string _logGroupNamePattern;

        /// <summary>
        /// Gets and sets the property LogGroupNamePattern. 
        /// <para>
        /// The pattern used to generate destination log group names during centralization. The
        /// pattern can contain static text and dynamic variables that are replaced with source
        /// attributes. If a variable cannot be resolved, it inherits the value from its parent
        /// variable in the hierarchy. The pattern must be between 1 and 512 characters.
        /// </para>
        ///  
        /// <para>
        /// Supported variables:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>${source.logGroup}</b> — The original log group name from the source account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>${source.accountId}</b> — The AWS account ID where the log originated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>${source.region}</b> — The AWS Region where the log originated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>${source.org.id}</b> — The AWS Organization ID of the source account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>${source.org.ouId}</b> — The organizational unit ID of the source account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>${source.org.rootId}</b> — The organization Root ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>${source.org.path}</b> — The organizational path from account to root.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogGroupNamePattern
        {
            get { return this._logGroupNamePattern; }
            set { this._logGroupNamePattern = value; }
        }

        // Check to see if LogGroupNamePattern property is set
        internal bool IsSetLogGroupNamePattern()
        {
            return this._logGroupNamePattern != null;
        }

    }
}