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
    /// Container for the parameters to the GetEventSelectors operation.
    /// Describes the settings for the event selectors that you configured for your trail.
    /// The information returned for your event selectors includes the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The S3 objects that you are logging for data events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your event selector includes management events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your event selector includes read-only events, write-only events, or all. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/create-event-selectors-for-a-trail.html">Configuring
    /// Event Selectors for Trails</a> in the <i>AWS CloudTrail User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetEventSelectorsRequest : AmazonCloudTrailRequest
    {
        private string _trailName;

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
        ///  <code>arn:aws:cloudtrail:us-east-1:123456789012:trail/MyTrail</code> 
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