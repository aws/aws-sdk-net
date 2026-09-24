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
    /// Describes a related item.
    /// </summary>
    public partial class ItemValue
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the related item, if the related item is an Amazon
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property MetricDefinition. 
        /// <para>
        /// The metric definition, if the related item is a metric in Amazon CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 4000)]
        public string MetricDefinition { get; set; }

        /// <summary>
        /// Checks to see if the MetricDefinition property is set.
        /// </summary>
        internal bool IsSetMetricDefinition() => this.MetricDefinition != null;

        /// <summary>
        /// Gets and sets the property PagerDutyIncidentDetail. 
        /// <para>
        /// Details about an incident that is associated with a PagerDuty incident.
        /// </para>
        /// </summary>
        public PagerDutyIncidentDetail PagerDutyIncidentDetail { get; set; }

        /// <summary>
        /// Checks to see if the PagerDutyIncidentDetail property is set.
        /// </summary>
        internal bool IsSetPagerDutyIncidentDetail() => this.PagerDutyIncidentDetail != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL, if the related item is a non-Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
