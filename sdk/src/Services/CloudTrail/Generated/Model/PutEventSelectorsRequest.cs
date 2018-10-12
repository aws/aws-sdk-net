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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the PutEventSelectors operation.
    /// Configures an event selector for your trail. Use event selectors to further specify
    /// the management and data event settings for your trail. By default, trails created
    /// without specific event selectors will be configured to log all read and write management
    /// events, and no data events. 
    /// 
    ///  
    /// <para>
    /// When an event occurs in your account, CloudTrail evaluates the event selectors in
    /// all trails. For each trail, if the event matches any event selector, the trail processes
    /// and logs the event. If the event doesn't match any event selector, the trail doesn't
    /// log the event. 
    /// </para>
    ///  
    /// <para>
    /// Example
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// You create an event selector for a trail and specify that you want write-only events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The EC2 <code>GetConsoleOutput</code> and <code>RunInstances</code> API operations
    /// occur in your account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudTrail evaluates whether the events match your event selectors.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>RunInstances</code> is a write-only event and it matches your event selector.
    /// The trail logs the event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>GetConsoleOutput</code> is a read-only event but it doesn't match your event
    /// selector. The trail doesn't log the event. 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// The <code>PutEventSelectors</code> operation must be called from the region in which
    /// the trail was created; otherwise, an <code>InvalidHomeRegionException</code> is thrown.
    /// </para>
    ///  
    /// <para>
    /// You can configure up to five event selectors for each trail. For more information,
    /// see <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-and-data-events-with-cloudtrail.html">Logging
    /// Data and Management Events for Trails </a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Limits
    /// in AWS CloudTrail</a> in the <i>AWS CloudTrail User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutEventSelectorsRequest : AmazonCloudTrailRequest
    {
        private List<EventSelector> _eventSelectors = new List<EventSelector>();
        private string _trailName;

        /// <summary>
        /// Gets and sets the property EventSelectors. 
        /// <para>
        /// Specifies the settings for your event selectors. You can configure up to five event
        /// selectors for a trail.
        /// </para>
        /// </summary>
        public List<EventSelector> EventSelectors
        {
            get { return this._eventSelectors; }
            set { this._eventSelectors = value; }
        }

        // Check to see if EventSelectors property is set
        internal bool IsSetEventSelectors()
        {
            return this._eventSelectors != null && this._eventSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrailName. 
        /// <para>
        /// Specifies the name of the trail or trail ARN. If you specify a trail name, the string
        /// must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify a trail ARN, it must be in the format:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </summary>
        public string TrailName
        {
            get { return this._trailName; }
            set { this._trailName = value; }
        }

        // Check to see if TrailName property is set
        internal bool IsSetTrailName()
        {
            return this._trailName != null;
        }

    }
}