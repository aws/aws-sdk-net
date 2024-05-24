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
    /// This is the response object from the DescribeAttack operation.
    /// </summary>
    public partial class DescribeAttackResponse : AmazonWebServiceResponse
    {
        private AttackDetail _attack;

        /// <summary>
        /// Gets and sets the property Attack. 
        /// <para>
        /// The attack that you requested. 
        /// </para>
        /// </summary>
        public AttackDetail Attack
        {
            get { return this._attack; }
            set { this._attack = value; }
        }

        // Check to see if Attack property is set
        internal bool IsSetAttack()
        {
            return this._attack != null;
        }

    }
}