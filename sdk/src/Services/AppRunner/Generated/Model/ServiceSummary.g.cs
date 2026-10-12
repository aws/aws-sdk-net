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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Provides summary information for an App Runner service.
    /// 
    ///  
    /// <para>
    /// This type contains limited information about a service. It doesn't include configuration
    /// details. It's returned by the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_ListServices.html">ListServices</a>
    /// action. Complete service information is returned by the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_CreateService.html">CreateService</a>,
    /// <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_DescribeService.html">DescribeService</a>,
    /// and <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_DeleteService.html">DeleteService</a>
    /// actions using the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_Service.html">Service</a>
    /// type.
    /// </para>
    /// </summary>
    public partial class ServiceSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the App Runner service was created. It's in the Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// An ID that App Runner generated for this service. It's unique within the Amazon Web
        /// Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The customer-provided service name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceUrl. 
        /// <para>
        /// A subdomain URL that App Runner generated for this service. You can use this URL to
        /// access your service web application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 51200)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUrl property is set.
        /// </summary>
        internal bool IsSetServiceUrl() => this.ServiceUrl != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the App Runner service. These particular values mean the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> – The service failed to create. The failed service isn't usable,
        /// and still counts towards your service quota. To troubleshoot this failure, read the
        /// failure events and logs, change any parameters that need to be fixed, and rebuild
        /// your service using <c>UpdateService</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c> – The service failed to delete and can't be successfully recovered.
        /// Retry the service deletion call to ensure that all related resources are removed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ServiceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the App Runner service was last updated. It's in theUnix time stamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
