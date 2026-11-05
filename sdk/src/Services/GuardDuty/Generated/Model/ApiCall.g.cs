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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about an API call that was observed as part of an activity.
    /// </summary>
    public partial class ApiCall
    {
        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error code that was returned, if the API call failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The name of the API operation that was invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service that the API operation was invoked against.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// User agent in the request to the API operation
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;
    }
}
