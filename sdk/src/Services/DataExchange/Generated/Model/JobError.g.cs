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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// An error that occurred with the job request.
    /// </summary>
    public partial class JobError
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code for the job error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Code Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The details about the job error.
        /// </para>
        /// </summary>
        public Details Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property LimitName. 
        /// <para>
        /// The name of the limit that was reached.
        /// </para>
        /// </summary>
        public JobErrorLimitName LimitName { get; set; }

        /// <summary>
        /// Checks to see if the LimitName property is set.
        /// </summary>
        internal bool IsSetLimitName() => this.LimitName != null;

        /// <summary>
        /// Gets and sets the property LimitValue. 
        /// <para>
        /// The value of the exceeded limit.
        /// </para>
        /// </summary>
        public double? LimitValue { get; set; }

        /// <summary>
        /// Checks to see if the LimitValue property is set.
        /// </summary>
        internal bool IsSetLimitValue() => this.LimitValue.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message related to the job error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier for the resource related to the error.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource related to the error.
        /// </para>
        /// </summary>
        public JobErrorResourceTypes ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
