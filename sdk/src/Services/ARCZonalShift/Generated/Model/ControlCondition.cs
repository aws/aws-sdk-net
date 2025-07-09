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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
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
namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// A control condition is an alarm that you specify for a practice run. When you configure
    /// practice runs with zonal autoshift for a resource, you specify Amazon CloudWatch alarms,
    /// which you create in CloudWatch to use with the practice run. The alarms that you specify
    /// are an <i>outcome alarm</i>, to monitor application health during practice runs and,
    /// optionally, a <i>blocking alarm</i>, to block practice runs from starting or to interrupt
    /// a practice run in progress.
    /// 
    ///  
    /// <para>
    /// Control condition alarms do not apply for autoshifts.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
    /// Considerations when you configure zonal autoshift</a> in the Amazon Application Recovery
    /// Controller Developer Guide.
    /// </para>
    /// </summary>
    public partial class ControlCondition
    {
        private string _alarmIdentifier;
        private ControlConditionType _type;

        /// <summary>
        /// Gets and sets the property AlarmIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an Amazon CloudWatch alarm that you specify as
        /// a control condition for a practice run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=1024)]
        public string AlarmIdentifier
        {
            get { return this._alarmIdentifier; }
            set { this._alarmIdentifier = value; }
        }

        // Check to see if AlarmIdentifier property is set
        internal bool IsSetAlarmIdentifier()
        {
            return this._alarmIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of alarm specified for a practice run. You can only specify Amazon CloudWatch
        /// alarms for practice runs, so the only valid value is <c>CLOUDWATCH</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlConditionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}