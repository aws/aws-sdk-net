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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the following actions: 
    /// 
    ///  <ul> <li><a>CreateDBSubnetGroup</a></li> <li><a>ModifyDBSubnetGroup</a></li> <li><a>DescribeDBSubnetGroups</a></li>
    /// <li><a>DeleteDBSubnetGroup</a></li> </ul> 
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBSubnetGroups</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateDBSubnetGroupResult : AmazonWebServiceResponse
    {
        private DBSubnetGroup _response;

        public DBSubnetGroup DBSubnetGroup
        {
            get { return this._response; }
            set { this._response = value; }
        }
    }
}