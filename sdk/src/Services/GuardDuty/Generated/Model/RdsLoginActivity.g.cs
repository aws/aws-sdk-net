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
    /// Contains details about login activity on an Amazon RDS database.
    /// </summary>
    public partial class RdsLoginActivity
    {
        /// <summary>
        /// Gets and sets the property ActivityWindow. 
        /// <para>
        /// The time range of the login activity.
        /// </para>
        /// </summary>
        public ActivityWindow ActivityWindow { get; set; }

        /// <summary>
        /// Checks to see if the ActivityWindow property is set.
        /// </summary>
        internal bool IsSetActivityWindow() => this.ActivityWindow != null;

        /// <summary>
        /// Gets and sets the property AnomalyContext. 
        /// <para>
        /// An explanation of how the login activity deviates from normal behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string AnomalyContext { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyContext property is set.
        /// </summary>
        internal bool IsSetAnomalyContext() => this.AnomalyContext != null;

        /// <summary>
        /// Gets and sets the property Enrichment. 
        /// <para>
        /// Additional context about the login activity, such as geolocation information.
        /// </para>
        /// </summary>
        public Enrichment Enrichment { get; set; }

        /// <summary>
        /// Checks to see if the Enrichment property is set.
        /// </summary>
        internal bool IsSetEnrichment() => this.Enrichment != null;

        /// <summary>
        /// Gets and sets the property LoginCount. 
        /// <para>
        /// The number of login attempts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LoginCount { get; set; }

        /// <summary>
        /// Checks to see if the LoginCount property is set.
        /// </summary>
        internal bool IsSetLoginCount() => this.LoginCount.HasValue;

        /// <summary>
        /// Gets and sets the property Outcome. 
        /// <para>
        /// The outcome of the login attempts.
        /// </para>
        /// </summary>
        public string Outcome { get; set; }

        /// <summary>
        /// Checks to see if the Outcome property is set.
        /// </summary>
        internal bool IsSetOutcome() => this.Outcome != null;

        /// <summary>
        /// Gets and sets the property Rate. 
        /// <para>
        /// The rate of the login attempts.
        /// </para>
        /// </summary>
        public string Rate { get; set; }

        /// <summary>
        /// Checks to see if the Rate property is set.
        /// </summary>
        internal bool IsSetRate() => this.Rate != null;
    }
}
