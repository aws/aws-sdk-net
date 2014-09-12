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
 * Do not modify this file. This file is generated from the elasticache-2014-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the output of one of the following operations:
    /// 
    ///  <ul> <li> <i>AuthorizeCacheSecurityGroupIngress</i> </li> <li> <i>CreateCacheSecurityGroup</i>
    /// </li> <li> <i>RevokeCacheSecurityGroupIngress</i> </li> </ul>
    /// </summary>
    public partial class RevokeCacheSecurityGroupIngressResult : AmazonWebServiceResponse
    {
        private CacheSecurityGroup _response;

        public CacheSecurityGroup CacheSecurityGroup
        {
            get { return this._response; }
            set { this._response = value; }
        }
    }
}