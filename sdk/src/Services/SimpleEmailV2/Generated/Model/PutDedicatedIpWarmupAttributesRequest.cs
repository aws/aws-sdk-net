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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutDedicatedIpWarmupAttributes operation.
    /// 
    /// </summary>
    public partial class PutDedicatedIpWarmupAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _ip;
        private int? _warmupPercentage;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The dedicated IP address that you want to update the warm-up attributes for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property WarmupPercentage. 
        /// <para>
        /// The warm-up percentage that you want to associate with the dedicated IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? WarmupPercentage
        {
            get { return this._warmupPercentage; }
            set { this._warmupPercentage = value; }
        }

        // Check to see if WarmupPercentage property is set
        internal bool IsSetWarmupPercentage()
        {
            return this._warmupPercentage.HasValue; 
        }

    }
}