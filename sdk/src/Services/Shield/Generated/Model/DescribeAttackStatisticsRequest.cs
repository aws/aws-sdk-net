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
    /// Container for the parameters to the DescribeAttackStatistics operation.
    /// Provides information about the number and type of attacks Shield has detected in the
    /// last year for all resources that belong to your account, regardless of whether you've
    /// defined Shield protections for them. This operation is available to Shield customers
    /// as well as to Shield Advanced customers.
    /// 
    ///  
    /// <para>
    /// The operation returns data for the time range of midnight UTC, one year ago, to midnight
    /// UTC, today. For example, if the current time is <c>2020-10-26 15:39:32 PDT</c>, equal
    /// to <c>2020-10-26 22:39:32 UTC</c>, then the time range for the attack data returned
    /// is from <c>2019-10-26 00:00:00 UTC</c> to <c>2020-10-26 00:00:00 UTC</c>. 
    /// </para>
    ///  
    /// <para>
    /// The time range indicates the period covered by the attack statistics data items.
    /// </para>
    /// </summary>
    public partial class DescribeAttackStatisticsRequest : AmazonShieldRequest
    {

    }
}