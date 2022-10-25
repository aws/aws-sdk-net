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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// MediaTailor only places (consumes) prefetched ads if the ad break meets the criteria
    /// defined by the dynamic variables. This gives you granular control over which ad break
    /// to place the prefetched ads into.
    /// 
    ///  
    /// <para>
    /// As an example, let's say that you set <code>DynamicVariable</code> to <code>scte.event_id</code>
    /// and <code>Operator</code> to <code>EQUALS</code>, and your playback configuration
    /// has an ADS URL of <code>https://my.ads.server.com/path?&amp;podId=[scte.avail_num]&amp;event=[scte.event_id]&amp;duration=[session.avail_duration_secs]</code>.
    /// And the prefetch request to the ADS contains these values <code>https://my.ads.server.com/path?&amp;podId=3&amp;event=my-awesome-event&amp;duration=30</code>.
    /// MediaTailor will only insert the prefetched ads into the ad break if has a SCTE marker
    /// with an event id of <code>my-awesome-event</code>, since it must match the event id
    /// that MediaTailor uses to query the ADS.
    /// </para>
    ///  
    /// <para>
    /// You can specify up to five <code>AvailMatchingCriteria</code>. If you specify multiple
    /// <code>AvailMatchingCriteria</code>, MediaTailor combines them to match using a logical
    /// <code>AND</code>. You can model logical <code>OR</code> combinations by creating multiple
    /// prefetch schedules.
    /// </para>
    /// </summary>
    public partial class AvailMatchingCriteria
    {
        private string _dynamicVariable;
        private Operator _operator;

        /// <summary>
        /// Gets and sets the property DynamicVariable. 
        /// <para>
        /// The dynamic variable(s) that MediaTailor should use as avail matching criteria. MediaTailor
        /// only places the prefetched ads into the avail if the avail matches the criteria defined
        /// by the dynamic variable. For information about dynamic variables, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/variables.html">Using
        /// dynamic ad variables</a> in the <i>MediaTailor User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can include up to 100 dynamic variables.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DynamicVariable
        {
            get { return this._dynamicVariable; }
            set { this._dynamicVariable = value; }
        }

        // Check to see if DynamicVariable property is set
        internal bool IsSetDynamicVariable()
        {
            return this._dynamicVariable != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// For the <code>DynamicVariable</code> specified in <code>AvailMatchingCriteria</code>,
        /// the Operator that is used for the comparison.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Operator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

    }
}