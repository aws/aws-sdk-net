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
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
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
    /// This data type is used as a response element in the <a>DescribeReservedDBInstances</a>
    /// and <a>PurchaseReservedDBInstancesOffering</a> actions.
    /// </summary>
    public partial class PurchaseReservedDBInstancesOfferingResult : AmazonWebServiceResponse
    {
        private ReservedDBInstance _response;

        public ReservedDBInstance ReservedDBInstance
        {
            get { return this._response; }
            set { this._response = value; }
        }
    }
}