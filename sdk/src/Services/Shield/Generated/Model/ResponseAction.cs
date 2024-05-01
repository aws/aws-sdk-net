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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Specifies the action setting that Shield Advanced should use in the WAF rules that
    /// it creates on behalf of the protected resource in response to DDoS attacks. You specify
    /// this as part of the configuration for the automatic application layer DDoS mitigation
    /// feature, when you enable or update automatic mitigation. Shield Advanced creates the
    /// WAF rules in a Shield Advanced-managed rule group, inside the web ACL that you have
    /// associated with the resource.
    /// </summary>
    public partial class ResponseAction
    {
        private BlockAction _block;
        private CountAction _count;

        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        /// Specifies that Shield Advanced should configure its WAF rules with the WAF <c>Block</c>
        /// action. 
        /// </para>
        ///  
        /// <para>
        /// You must specify exactly one action, either <c>Block</c> or <c>Count</c>.
        /// </para>
        /// </summary>
        public BlockAction Block
        {
            get { return this._block; }
            set { this._block = value; }
        }

        // Check to see if Block property is set
        internal bool IsSetBlock()
        {
            return this._block != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// Specifies that Shield Advanced should configure its WAF rules with the WAF <c>Count</c>
        /// action. 
        /// </para>
        ///  
        /// <para>
        /// You must specify exactly one action, either <c>Block</c> or <c>Count</c>.
        /// </para>
        /// </summary>
        public CountAction Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count != null;
        }

    }
}