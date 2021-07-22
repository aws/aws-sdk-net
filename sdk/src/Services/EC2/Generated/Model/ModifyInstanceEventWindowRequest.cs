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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceEventWindow operation.
    /// Modifies the specified event window.
    /// 
    ///  
    /// <para>
    /// You can define either a set of time ranges or a cron expression when modifying the
    /// event window, but not both.
    /// </para>
    ///  
    /// <para>
    /// To modify the targets associated with the event window, use the <a>AssociateInstanceEventWindow</a>
    /// and <a>DisassociateInstanceEventWindow</a> API.
    /// </para>
    ///  
    /// <para>
    /// If Amazon Web Services has already scheduled an event, modifying an event window won't
    /// change the time of the scheduled event.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
    /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyInstanceEventWindowRequest : AmazonEC2Request
    {
        private string _cronExpression;
        private string _instanceEventWindowId;
        private string _name;
        private List<InstanceEventWindowTimeRangeRequest> _timeRanges = new List<InstanceEventWindowTimeRangeRequest>();

        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The cron expression of the event window, for example, <code>* 0-4,20-23 * * 1,5</code>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Only hour and day of the week values are supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For day of the week values, you can specify either integers <code>0</code> through
        /// <code>6</code>, or alternative single values <code>SUN</code> through <code>SAT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The minute, month, and year must be specified by <code>*</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The hour value must be one or a multiple range, for example, <code>0-4</code> or <code>0-4,20-23</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each hour range must be &gt;= 2 hours, for example, <code>0-2</code> or <code>20-23</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The event window must be &gt;= 4 hours. The combined total time ranges in the event
        /// window must be &gt;= 4 hours.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about cron expressions, see <a href="https://en.wikipedia.org/wiki/Cron">cron</a>
        /// on the <i>Wikipedia website</i>.
        /// </para>
        /// </summary>
        public string CronExpression
        {
            get { return this._cronExpression; }
            set { this._cronExpression = value; }
        }

        // Check to see if CronExpression property is set
        internal bool IsSetCronExpression()
        {
            return this._cronExpression != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceEventWindowId. 
        /// <para>
        /// The ID of the event window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceEventWindowId
        {
            get { return this._instanceEventWindowId; }
            set { this._instanceEventWindowId = value; }
        }

        // Check to see if InstanceEventWindowId property is set
        internal bool IsSetInstanceEventWindowId()
        {
            return this._instanceEventWindowId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event window.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRanges. 
        /// <para>
        /// The time ranges of the event window.
        /// </para>
        /// </summary>
        public List<InstanceEventWindowTimeRangeRequest> TimeRanges
        {
            get { return this._timeRanges; }
            set { this._timeRanges = value; }
        }

        // Check to see if TimeRanges property is set
        internal bool IsSetTimeRanges()
        {
            return this._timeRanges != null && this._timeRanges.Count > 0; 
        }

    }
}