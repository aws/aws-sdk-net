/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Represents CPU utilization information from the specified instance that belongs to
    /// the AWS Elastic Beanstalk environment. Use the <code>instanceId</code> property to
    /// specify the application instance for which you'd like to return data.
    /// </summary>
    public partial class CPUUtilization
    {
        private double? _idle;
        private double? _ioWait;
        private double? _irq;
        private double? _nice;
        private double? _softIRQ;
        private double? _system;
        private double? _user;

        /// <summary>
        /// Gets and sets the property Idle. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <code>Idle</code> state over the
        /// last 10 seconds.
        /// </para>
        /// </summary>
        public double Idle
        {
            get { return this._idle.GetValueOrDefault(); }
            set { this._idle = value; }
        }

        // Check to see if Idle property is set
        internal bool IsSetIdle()
        {
            return this._idle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IOWait. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <code>I/O Wait</code> state over
        /// the last 10 seconds.
        /// </para>
        /// </summary>
        public double IOWait
        {
            get { return this._ioWait.GetValueOrDefault(); }
            set { this._ioWait = value; }
        }

        // Check to see if IOWait property is set
        internal bool IsSetIOWait()
        {
            return this._ioWait.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IRQ. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <code>IRQ</code> state over the last
        /// 10 seconds.
        /// </para>
        /// </summary>
        public double IRQ
        {
            get { return this._irq.GetValueOrDefault(); }
            set { this._irq = value; }
        }

        // Check to see if IRQ property is set
        internal bool IsSetIRQ()
        {
            return this._irq.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Nice. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <code>Nice</code> state over the
        /// last 10 seconds.
        /// </para>
        /// </summary>
        public double Nice
        {
            get { return this._nice.GetValueOrDefault(); }
            set { this._nice = value; }
        }

        // Check to see if Nice property is set
        internal bool IsSetNice()
        {
            return this._nice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SoftIRQ. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <code>SoftIRQ</code> state over the
        /// last 10 seconds.
        /// </para>
        /// </summary>
        public double SoftIRQ
        {
            get { return this._softIRQ.GetValueOrDefault(); }
            set { this._softIRQ = value; }
        }

        // Check to see if SoftIRQ property is set
        internal bool IsSetSoftIRQ()
        {
            return this._softIRQ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <code>System</code> state over the
        /// last 10 seconds.
        /// </para>
        /// </summary>
        public double System
        {
            get { return this._system.GetValueOrDefault(); }
            set { this._system = value; }
        }

        // Check to see if System property is set
        internal bool IsSetSystem()
        {
            return this._system.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <code>User</code> state over the
        /// last 10 seconds.
        /// </para>
        /// </summary>
        public double User
        {
            get { return this._user.GetValueOrDefault(); }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user.HasValue; 
        }

    }
}