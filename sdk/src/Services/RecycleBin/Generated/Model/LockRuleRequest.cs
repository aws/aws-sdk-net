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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// Container for the parameters to the LockRule operation.
    /// Locks a retention rule. A locked retention rule can't be modified or deleted.
    /// </summary>
    public partial class LockRuleRequest : AmazonRecycleBinRequest
    {
        private string _identifier;
        private LockConfiguration _lockConfiguration;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique ID of the retention rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property LockConfiguration. 
        /// <para>
        /// Information about the retention rule lock configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LockConfiguration LockConfiguration
        {
            get { return this._lockConfiguration; }
            set { this._lockConfiguration = value; }
        }

        // Check to see if LockConfiguration property is set
        internal bool IsSetLockConfiguration()
        {
            return this._lockConfiguration != null;
        }

    }
}