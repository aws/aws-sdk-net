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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Represents summary information about the health of an instance. For more information,
    /// see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">Health
    /// Colors and Statuses</a>.
    /// </summary>
    public partial class InstanceHealthSummary
    {
        /// <summary>
        /// Gets and sets the property Degraded. 
        /// <para>
        ///  <b>Red.</b> The health agent is reporting a high number of request failures or other
        /// issues for an instance or environment.
        /// </para>
        /// </summary>
        public int? Degraded { get; set; }

        /// <summary>
        /// Checks to see if the Degraded property is set.
        /// </summary>
        internal bool IsSetDegraded() => this.Degraded.HasValue;

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        ///  <b>Green.</b> An operation is in progress on an instance.
        /// </para>
        /// </summary>
        public int? Info { get; set; }

        /// <summary>
        /// Checks to see if the Info property is set.
        /// </summary>
        internal bool IsSetInfo() => this.Info.HasValue;

        /// <summary>
        /// Gets and sets the property NoData. 
        /// <para>
        ///  <b>Grey.</b> Elastic Beanstalk and the health agent are reporting no data on an instance.
        /// </para>
        /// </summary>
        public int? NoData { get; set; }

        /// <summary>
        /// Checks to see if the NoData property is set.
        /// </summary>
        internal bool IsSetNoData() => this.NoData.HasValue;

        /// <summary>
        /// Gets and sets the property Ok. 
        /// <para>
        ///  <b>Green.</b> An instance is passing health checks and the health agent is not reporting
        /// any problems.
        /// </para>
        /// </summary>
        public int? Ok { get; set; }

        /// <summary>
        /// Checks to see if the Ok property is set.
        /// </summary>
        internal bool IsSetOk() => this.Ok.HasValue;

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        ///  <b>Grey.</b> An operation is in progress on an instance within the command timeout.
        /// </para>
        /// </summary>
        public int? Pending { get; set; }

        /// <summary>
        /// Checks to see if the Pending property is set.
        /// </summary>
        internal bool IsSetPending() => this.Pending.HasValue;

        /// <summary>
        /// Gets and sets the property Severe. 
        /// <para>
        ///  <b>Red.</b> The health agent is reporting a very high number of request failures
        /// or other issues for an instance or environment.
        /// </para>
        /// </summary>
        public int? Severe { get; set; }

        /// <summary>
        /// Checks to see if the Severe property is set.
        /// </summary>
        internal bool IsSetSevere() => this.Severe.HasValue;

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        ///  <b>Grey.</b> Elastic Beanstalk and the health agent are reporting an insufficient
        /// amount of data on an instance.
        /// </para>
        /// </summary>
        public int? Unknown { get; set; }

        /// <summary>
        /// Checks to see if the Unknown property is set.
        /// </summary>
        internal bool IsSetUnknown() => this.Unknown.HasValue;

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        ///  <b>Yellow.</b> The health agent is reporting a moderate number of request failures
        /// or other issues for an instance or environment.
        /// </para>
        /// </summary>
        public int? Warning { get; set; }

        /// <summary>
        /// Checks to see if the Warning property is set.
        /// </summary>
        internal bool IsSetWarning() => this.Warning.HasValue;
    }
}
