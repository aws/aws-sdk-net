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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateStreamForSegments operation. Associates
    /// an Amazon Kinesis data stream to receive segment membership events for a given domain.
    /// This is a domain-level configuration that applies to all segment subscriptions within
    /// the domain. A domain can have only one associated stream at a time.
    /// </summary>
    public partial class AssociateStreamForSegmentsRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis data stream to deliver segment
        /// membership events to. For example, <c>arn:aws:kinesis:region:account-id:stream/stream-name</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property DestinationRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that allows Customer Profiles service
        /// principal to assume the role for conducting AWS Key Management Service (KMS) and Amazon
        /// Kinesis operations. The role must grant the following Amazon Kinesis permissions to
        /// deliver segment membership events to the stream: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>kinesis:PutRecord</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kinesis:PutRecords</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kinesis:DescribeStream</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string DestinationRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRoleArn property is set.
        /// </summary>
        internal bool IsSetDestinationRoleArn() => this.DestinationRoleArn != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;
    }
}
