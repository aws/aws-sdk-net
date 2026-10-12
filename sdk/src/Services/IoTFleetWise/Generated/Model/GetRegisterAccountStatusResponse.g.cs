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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// This is the response object from the GetRegisterAccountStatus operation.
    /// </summary>
    public partial class GetRegisterAccountStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountStatus. 
        /// <para>
        ///  The status of registering your account and resources. The status can be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REGISTRATION_SUCCESS</c> - The Amazon Web Services resource is successfully registered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGISTRATION_PENDING</c> - Amazon Web Services IoT FleetWise is processing the
        /// registration request. This process takes approximately five minutes to complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGISTRATION_FAILURE</c> - Amazon Web Services IoT FleetWise can't register the
        /// AWS resource. Try again later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistrationStatus AccountStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountStatus property is set.
        /// </summary>
        internal bool IsSetAccountStatus() => this.AccountStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time the account was registered, in seconds since epoch (January 1, 1970 at midnight
        /// UTC time). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerAccountId. 
        /// <para>
        ///  The unique ID of the Amazon Web Services account, provided at account creation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CustomerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAccountId property is set.
        /// </summary>
        internal bool IsSetCustomerAccountId() => this.CustomerAccountId != null;

        /// <summary>
        /// Gets and sets the property IamRegistrationResponse. 
        /// <para>
        ///  Information about the registered IAM resources or errors, if any. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IamRegistrationResponse IamRegistrationResponse { get; set; }

        /// <summary>
        /// Checks to see if the IamRegistrationResponse property is set.
        /// </summary>
        internal bool IsSetIamRegistrationResponse() => this.IamRegistrationResponse != null;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        ///  The time this registration was last updated, in seconds since epoch (January 1, 1970
        /// at midnight UTC time). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property TimestreamRegistrationResponse. 
        /// <para>
        ///  Information about the registered Amazon Timestream resources or errors, if any.
        /// </para>
        /// </summary>
        public TimestreamRegistrationResponse TimestreamRegistrationResponse { get; set; }

        /// <summary>
        /// Checks to see if the TimestreamRegistrationResponse property is set.
        /// </summary>
        internal bool IsSetTimestreamRegistrationResponse() => this.TimestreamRegistrationResponse != null;
    }
}
