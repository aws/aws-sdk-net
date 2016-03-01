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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLimits operation.
    /// Returns the current provisioned-capacity limits for your AWS account in a region,
    /// both for the region as a whole and for any one DynamoDB table you create there.
    /// 
    ///  
    /// <para>
    /// When you establish an AWS account, the account has initial limits on the maximum Read-
    /// and Write-Capacity Units (RCUs and WCUs) that you can provision across all your DynamoDB
    /// tables in a given region, and also per-table limits that apply when you create a table
    /// there. Although you can increase these limits by filing a Case at <a href="https://console.aws.amazon.com/support">AWS
    /// Support Center</a>, obtaining the increase is not instantaneous. The <i>DescribeLimits</i>
    /// API lets you write code to compare the capacity you are currently using to those limits
    /// imposed by your account so you have enough time to apply for an increase before you
    /// hit a limit. For example, you could use one of the AWS SDKs to do the following:
    /// </para>
    ///  <ol> <li>Call <i>DescribeLimits</i> to obtain the current account limits on provisioned
    /// capacity in a region.</li> <li>Call <i>ListTables</i> to obtain a list of all your
    /// DynamoDB tables there.</li> <li>Loop over the tables, calling <i>DescribeTable</i>
    /// on each. Sum the capacity provisioned for each table and all its global secondary
    /// indexes across all the tables, while also keeping track of the table or global secondary
    /// index with the largest provisioned read capacity, and the one with the largest provisioned
    /// write capacity.</li> <li>Report the account limits returned by <i>DescribeLimits</i>
    /// as compared to the current provisioned capacity levels for the account as a whole,
    /// and for the highest current per-table provisioning.</li> </ol> 
    /// <para>
    /// This will let you see whether you are getting close to your account-level limits.
    /// See <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html#d0e53086">Limits
    /// in DynamoDB</a> for a code example written in Python.
    /// </para>
    /// </summary>
    public partial class DescribeLimitsRequest : AmazonDynamoDBRequest
    {

    }
}