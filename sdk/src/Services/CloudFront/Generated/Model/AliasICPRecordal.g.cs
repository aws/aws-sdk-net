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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Amazon Web Services services in China customers must file for an Internet Content
    /// Provider (ICP) recordal if they want to serve content publicly on an alternate domain
    /// name, also known as a CNAME, that they've added to CloudFront. AliasICPRecordal provides
    /// the ICP recordal status for CNAMEs associated with distributions. The status is returned
    /// in the CloudFront response; you can't configure it yourself.
    /// 
    ///  
    /// <para>
    /// For more information about ICP recordals, see <a href="https://docs.amazonaws.cn/en_us/aws/latest/userguide/accounts-and-credentials.html">
    /// Signup, Accounts, and Credentials</a> in <i>Getting Started with Amazon Web Services
    /// services in China</i>.
    /// </para>
    /// </summary>
    public partial class AliasICPRecordal
    {
        /// <summary>
        /// Gets and sets the property CNAME. 
        /// <para>
        /// A domain name associated with a distribution.
        /// </para>
        /// </summary>
        public string CNAME { get; set; }

        /// <summary>
        /// Checks to see if the CNAME property is set.
        /// </summary>
        internal bool IsSetCNAME() => this.CNAME != null;

        /// <summary>
        /// Gets and sets the property ICPRecordalStatus. 
        /// <para>
        /// The Internet Content Provider (ICP) recordal status for a CNAME. The ICPRecordalStatus
        /// is set to APPROVED for all CNAMEs (aliases) in Amazon Web Services Regions outside
        /// of China.
        /// </para>
        ///  
        /// <para>
        /// The status values returned are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>APPROVED</b> indicates that the associated CNAME has a valid ICP recordal number.
        /// Multiple CNAMEs can be associated with a distribution, and CNAMEs can correspond to
        /// different ICP recordals. To be marked as APPROVED, that is, valid to use with the
        /// China Regions, a CNAME must have one ICP recordal number associated with it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SUSPENDED</b> indicates that the associated CNAME does not have a valid ICP recordal
        /// number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PENDING</b> indicates that CloudFront can't determine the ICP recordal status
        /// of the CNAME associated with the distribution because there was an error in trying
        /// to determine the status. You can try again to see if the error is resolved in which
        /// case CloudFront returns an APPROVED or SUSPENDED status.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ICPRecordalStatus ICPRecordalStatus { get; set; }

        /// <summary>
        /// Checks to see if the ICPRecordalStatus property is set.
        /// </summary>
        internal bool IsSetICPRecordalStatus() => this.ICPRecordalStatus != null;
    }
}
