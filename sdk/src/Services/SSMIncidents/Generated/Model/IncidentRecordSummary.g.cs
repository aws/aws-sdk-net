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
    /// Details describing an incident record.
    /// </summary>
    public partial class IncidentRecordSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp for when the incident was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// Defines the impact to customers and applications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public int? Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact.HasValue;

        /// <summary>
        /// Gets and sets the property IncidentRecordSource. 
        /// <para>
        /// What caused Incident Manager to create the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IncidentRecordSource IncidentRecordSource { get; set; }

        /// <summary>
        /// Checks to see if the IncidentRecordSource property is set.
        /// </summary>
        internal bool IsSetIncidentRecordSource() => this.IncidentRecordSource != null;

        /// <summary>
        /// Gets and sets the property ResolvedTime. 
        /// <para>
        /// The timestamp for when the incident was resolved.
        /// </para>
        /// </summary>
        public DateTime? ResolvedTime { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedTime property is set.
        /// </summary>
        internal bool IsSetResolvedTime() => this.ResolvedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IncidentRecordStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the incident. This value is either provided by the response plan or overwritten
        /// on creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
