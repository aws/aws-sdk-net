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

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Error information returned when a <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetailsForOrganization.html">DescribeEventDetailsForOrganization</a>
    /// operation can't find a specified event.
    /// </summary>
    public partial class OrganizationEventDetailsErrorItem
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// Error information returned when a <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetailsForOrganization.html">DescribeEventDetailsForOrganization</a>
        /// operation can't find a specified event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message that describes the error.
        /// </para>
        ///  
        /// <para>
        /// If you call the <c>DescribeEventDetailsForOrganization</c> operation and receive one
        /// of the following errors, follow the recommendations in the message:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// We couldn't find a public event that matches your request. To find an event that is
        /// account specific, you must enter an Amazon Web Services account ID in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// We couldn't find an account specific event for the specified Amazon Web Services account.
        /// To find an event that is public, you must enter a null value for the Amazon Web Services
        /// account ID in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your Amazon Web Services account doesn't include the Amazon Web Services Support plan
        /// required to use the Health API. You must have either a Business, Enterprise On-Ramp,
        /// or Enterprise Support plan.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ErrorName. 
        /// <para>
        /// The name of the error.
        /// </para>
        /// </summary>
        public string ErrorName { get; set; }

        /// <summary>
        /// Checks to see if the ErrorName property is set.
        /// </summary>
        internal bool IsSetErrorName() => this.ErrorName != null;

        /// <summary>
        /// Gets and sets the property EventArn. 
        /// <para>
        /// The unique identifier for the event. The event ARN has the <c>arn:aws:health:<i>event-region</i>::event/<i>SERVICE</i>/<i>EVENT_TYPE_CODE</i>/<i>EVENT_TYPE_PLUS_ID</i>
        /// </c> format.
        /// </para>
        ///  
        /// <para>
        /// For example, an event ARN might look like the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:health:us-east-1::event/EC2/EC2_INSTANCE_RETIREMENT_SCHEDULED/EC2_INSTANCE_RETIREMENT_SCHEDULED_ABC123-DEF456</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1600)]
        public string EventArn { get; set; }

        /// <summary>
        /// Checks to see if the EventArn property is set.
        /// </summary>
        internal bool IsSetEventArn() => this.EventArn != null;
    }
}
