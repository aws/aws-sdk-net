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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details about what created the incident record and when it was created.
    /// </summary>
    public partial class IncidentRecordSource
    {
        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The principal that started the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property InvokedBy. 
        /// <para>
        /// The service principal that assumed the role specified in <c>createdBy</c>. If no service
        /// principal assumed the role this will be left blank.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string InvokedBy { get; set; }

        /// <summary>
        /// Checks to see if the InvokedBy property is set.
        /// </summary>
        internal bool IsSetInvokedBy() => this.InvokedBy != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The resource that caused the incident to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The service that started the incident. This can be manually created from Incident
        /// Manager, automatically created using an Amazon CloudWatch alarm, or Amazon EventBridge
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 50)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
