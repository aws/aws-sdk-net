/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOfferings operation.
    /// <para>Describes one or more of the Offerings that are currently available for creating new Connections. The results include offerings for
    /// all regions.</para> <para>To order a new Connection you will need to select a specific Offering ID.</para>
    /// </summary>
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferings"/>
    public class DescribeOfferingsRequest : AmazonWebServiceRequest
    {
    }
}
    
