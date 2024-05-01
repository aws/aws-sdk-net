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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
        private int? _degraded;
        private int? _info;
        private int? _noData;
        private int? _ok;
        private int? _pending;
        private int? _severe;
        private int? _unknown;
        private int? _warning;

        /// <summary>
        /// Gets and sets the property Degraded. 
        /// <para>
        ///  <b>Red.</b> The health agent is reporting a high number of request failures or other
        /// issues for an instance or environment.
        /// </para>
        /// </summary>
        public int? Degraded
        {
            get { return this._degraded; }
            set { this._degraded = value; }
        }

        // Check to see if Degraded property is set
        internal bool IsSetDegraded()
        {
            return this._degraded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        ///  <b>Green.</b> An operation is in progress on an instance.
        /// </para>
        /// </summary>
        public int? Info
        {
            get { return this._info; }
            set { this._info = value; }
        }

        // Check to see if Info property is set
        internal bool IsSetInfo()
        {
            return this._info.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoData. 
        /// <para>
        ///  <b>Grey.</b> AWS Elastic Beanstalk and the health agent are reporting no data on
        /// an instance.
        /// </para>
        /// </summary>
        public int? NoData
        {
            get { return this._noData; }
            set { this._noData = value; }
        }

        // Check to see if NoData property is set
        internal bool IsSetNoData()
        {
            return this._noData.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ok. 
        /// <para>
        ///  <b>Green.</b> An instance is passing health checks and the health agent is not reporting
        /// any problems.
        /// </para>
        /// </summary>
        public int? Ok
        {
            get { return this._ok; }
            set { this._ok = value; }
        }

        // Check to see if Ok property is set
        internal bool IsSetOk()
        {
            return this._ok.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        ///  <b>Grey.</b> An operation is in progress on an instance within the command timeout.
        /// </para>
        /// </summary>
        public int? Pending
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Severe. 
        /// <para>
        ///  <b>Red.</b> The health agent is reporting a very high number of request failures
        /// or other issues for an instance or environment.
        /// </para>
        /// </summary>
        public int? Severe
        {
            get { return this._severe; }
            set { this._severe = value; }
        }

        // Check to see if Severe property is set
        internal bool IsSetSevere()
        {
            return this._severe.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        ///  <b>Grey.</b> AWS Elastic Beanstalk and the health agent are reporting an insufficient
        /// amount of data on an instance.
        /// </para>
        /// </summary>
        public int? Unknown
        {
            get { return this._unknown; }
            set { this._unknown = value; }
        }

        // Check to see if Unknown property is set
        internal bool IsSetUnknown()
        {
            return this._unknown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        ///  <b>Yellow.</b> The health agent is reporting a moderate number of request failures
        /// or other issues for an instance or environment.
        /// </para>
        /// </summary>
        public int? Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning.HasValue; 
        }

    }
}